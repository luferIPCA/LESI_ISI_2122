/*
 * lufer
 * Cliente que usa SOAP e REST
 * */
using System;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows.Forms;

namespace UsaSOAPeREST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Usa SOAP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            WSSoap.CalcSOAPClient ws = new WSSoap.CalcSOAPClient();
            MessageBox.Show(ws.Add(2, 3).ToString());
           
        }

        /// <summary>
        /// Termina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Usa REST
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            // URI: http://localhost:12394/Service.svc/rest/Add/{X}/{Y}

            //1º Definir URI
            StringBuilder uri = new StringBuilder();
            uri.Append("http://localhost:12394/Service.svc/rest/");
            uri.Append("Add/2/3");

            #region Prepara Pedido
            HttpWebRequest request = WebRequest.Create(uri.ToString()) as HttpWebRequest;
            #endregion

            #region Faz pedido e analisa resposta
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    string message = String.Format("GET falhou. Recebido HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(int));
                object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                int jsonResponse = (int)objResponse;// ou "as Result";

                MessageBox.Show(jsonResponse.ToString());
            }
            #endregion
        }
    }
}
