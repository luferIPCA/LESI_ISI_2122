/*
 * lufer
 * Cliente RESTful
 * */

using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;        //Serializar JSON
using System.Text;
using System.Windows.Forms;


namespace CalcRest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //URI: http://localhost:12394/Service.svc/Soma/2/3

            //1º Definir URI
            StringBuilder uri = new StringBuilder();
            uri.Append("http://localhost:12394/Service.svc/");
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

                // JSON

                //DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Response));
                //object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                //Response jsonResponse = (Response)objResponse;// ou "as Response";


                StreamReader reader = new StreamReader(response.GetResponseStream());
                string result = reader.ReadToEnd();
                MessageBox.Show(result);

            }
            #endregion

        }

        /// <summary>
        /// Dados estruturados em JSON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //URI: http://localhost:12394/Service.svc/SomaSub/2/3

            //1º Definir URI
            StringBuilder uri = new StringBuilder();
            uri.Append("http://localhost:12394/Service.svc/");
            uri.Append("SomaSub/2/3");

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

                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Result));
                object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                Result jsonResponse = (Result)objResponse;// ou "as Result";

                MessageBox.Show(jsonResponse.Sub.ToString() + " : " + jsonResponse.Soma.ToString());
            }
            #endregion
        }

       
    }


    public class Result
    {
        public int Soma { get; set; }
        public int Sub { get; set; }
        public bool Succ { get; set; }
    }



}
