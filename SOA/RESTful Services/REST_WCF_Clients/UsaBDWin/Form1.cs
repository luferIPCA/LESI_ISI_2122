/*
 * Cliente Windows usa WCF REST sobre Base de Dados
 * lufer@ipca.pt
 * 
 * */
using System;
using System.Data;  //DataSet
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows.Forms;
using System.IO;        //Stream
using System.Diagnostics;


                         //NameSpace referência

//Adicionar COM System.Runtime.Serialization em "Project Properties"
using System.Runtime.Serialization;         //DataContract
using System.Web;
using System.Xml;

namespace UsaWCF_BD_WIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Método para devolver o conteúdo de uma página em string
        /// </summary>
        /// <param name="address">URI completo</param>
        /// <returns></returns>
        public static string GetPageAsString(String address)
        {
            string result = "";

            // Cria pedido Web 
            HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;
            // Analisa a resposta  
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                // Obtem a Resposta 
                StreamReader reader = new StreamReader(response.GetResponseStream());
                // Lê e converte em string
                result = reader.ReadToEnd();
            }
            return result;
        }


        /// <summary>
        /// Trata XML
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static void GetXMLData(Stream f)
        {
            DataSet ds = new DataSet();
            // converte o Stream num DataSet
            ds.ReadXml(f);
            // Mostra o XML do DataSet
            PrintDataSet(ds);
        }

        /// <summary>
        /// Prepara output de XML
        /// </summary>
        /// <param name="ds">Dataset</param>
        public static void PrintDataSet(DataSet ds)
        {
            //int x = ds.Tables.Count;
            foreach (DataTable table in ds.Tables)
            {
                for (int rn = 0; rn < table.Rows.Count; rn++)
                {
                    for (int cn = 0; cn < table.Columns.Count; cn++)
                    {

                        Debug.WriteLine("Row: {0} : Col: {1} <{2}> = {3}", rn, cn, table.Columns[cn].Caption, table.Rows[rn][cn]);
                    }
                }

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            
        }

        /// <summary>
        /// Mostrar JSON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            HttpWebRequest request;
            string jsonText;
            try
            {
                string url = "http://services.groupkt.com/country/get/all";

                request = WebRequest.Create(url) as HttpWebRequest;

                //analisa resposta
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)     //via GET
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        string message = String.Format("GET falhou. Recebido HTTP {0}", response.StatusCode);
                        throw new ApplicationException(message);
                    }


                    // h1: JSON para classes com Json.Net
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Response));
                    object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                    Response jsonResponse = (Response)objResponse;// ou "as Response";
                    dataGridView1.DataSource = jsonResponse.response.results;

                    // h2: Com Newtonsoft.Json
                    //StreamReader reader = new StreamReader(response.GetResponseStream());
                    //jsonText = reader.ReadToEnd();
                    //Response jsonResponse2 = new Response();
                    //Newtonsoft.Json.JsonConvert.PopulateObject(jsonText.ToString(), jsonResponse2);
                    //dataGridView1.DataSource = jsonResponse.response.results;
                }
            }
            catch (WebException e1)
            {
                Debug.WriteLine(e1.Message);

            }

        }


        /// <summary>
        /// Mostrar XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            HttpWebRequest request;
            string url = "http://localhost:6418/Service.svc/All";   //XML

            //Debug.WriteLine(GetPageAsString(url));

            request = WebRequest.Create(url) as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)     //via GET
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    string message = String.Format("GET falhou. Recebido HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                DataSet ds = new DataSet();
                // converte o Stream num DataSet
                ds.ReadXml(response.GetResponseStream());

                dataGridView1.DataSource = ds.Tables[0];
                //Analisar XML
                //GetXMLData(response.GetResponseStream());  
            }
        }

        /// <summary>
        /// Auth - cliente com POST com parametro XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            HttpWebRequest req = null;
            HttpWebResponse res = null;
            try
            {
                const string url = "http://localhost:6418/Service.svc/Auth";
                req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "POST";
                req.ContentType = "application/xml; charset=utf-8";
                req.Timeout = 30000;
                req.Headers.Add("SOAPAction", url);

                //Instancia parametro para o serviço
                var xmlDoc = new XmlDocument { XmlResolver = null };
                xmlDoc.Load("Dados.xml");
                string sXml = xmlDoc.InnerXml;
                req.ContentLength = sXml.Length;
                var sw = new StreamWriter(req.GetRequestStream());
                sw.Write(sXml);
                sw.Close();

                res = (HttpWebResponse)req.GetResponse();
                Stream responseStream = res.GetResponseStream();
                var streamReader = new StreamReader(responseStream);

                //Analisa resposta e coloca num documento xml
                var soapResonseXmlDocument = new XmlDocument();
                soapResonseXmlDocument.LoadXml(streamReader.ReadToEnd());

                textBox1.Text = soapResonseXmlDocument.InnerXml;
                //Debug.WriteLine(soapResonseXMLDocument.InnerXml);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }


        /// <summary>
        /// Insere Hotel via POST
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            //usar a classe do serviço
            //ou criar uma nova classe
            HotelWS.Hotel h = new HotelWS.Hotel()
            {
                Nome = textBox2.Text,
                Cidade = textBox3.Text,
                Capacidade = int.Parse(textBox4.Text)
            };

            //h.Nome = textBox1.Text;
            //h.Cidade = textBox2.Text;
            //h.Capacidade = int.Parse(textBox3.Text);

            DataContractJsonSerializer objseria = new DataContractJsonSerializer(typeof(HotelWS.Hotel));
            MemoryStream mem = new MemoryStream();
            objseria.WriteObject(mem, h);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
            WebClient webClient = new WebClient();
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            webClient.UploadString("http://localhost:6418/Service.svc/AddHotel", "POST", data);
            label4.Text = "Sucesso!";
        }
    }


    #region ClassesJSON
    //json2charp

    [DataContract]
    public class RespostaJSON
    {
        public int Capacidade { get; set; }
        public string Cidade { get; set; }
        public string Nome { get; set; }
    }

    [DataContract]
    internal class Response
    {
        [DataMember(Name = "RestResponse")]
        public RestResponse response { get; set; }

    }

    [DataContract]
    internal class RestResponse
    {
        [DataMember(Name = "messages")]
        public string[] messages { get; set; }
        [DataMember(Name = "result")]
        public Result[] results { get; set; }
    }

    [DataContract]
    internal class Result
    {
        [DataMember(Name = "name")]
        public string name { get; set; }
        [DataMember(Name = "alpha2_code")]
        public string alpha2_code { get; set; }
        [DataMember(Name = "alpha3_code")]
        public string alpha3_code { get; set; }
    }

    #endregion
}

