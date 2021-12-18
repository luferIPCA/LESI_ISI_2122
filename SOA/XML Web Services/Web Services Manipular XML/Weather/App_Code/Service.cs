/*
 * by lufer
 * 
 * Web Service que lida com XML
 *
 * Ver mais em:
 * http://msdn.microsoft.com/en-us/library/d5awd922.aspx
 * 
 * WSDL (Serviço já não disponível)
 * http://www.webservicex.com/globalweather.asmx?wsdl
 * */
using System.Web.Services;
using System.Xml;
using System.Xml.XPath;

[WebService(Namespace = "http://www.ipca.pt/")]
public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    /// <summary>
    /// Analisa o XML e coloca na classe Weather o que lhe interessa
    /// </summary>
    /// <param name="c"></param>
    /// <param name="p"></param>
    /// <returns></returns>
    [WebMethod]
    public Weather GetWeather(string c, string p)
    {
        //Instancia serviço
        WeatherWS.GlobalWeather ws = new WeatherWS.GlobalWeather();

        //invoca método
        string xml = ws.GetWeather(c, p);

        //Tratar XML resultante
        XmlDocument document = new XmlDocument();
        XPathNavigator navigator;
        document.LoadXml(xml);
        navigator = document.CreateNavigator();

        navigator.MoveToRoot();
        navigator.MoveToFirstChild();

        string aux = "";
        Weather w = new Weather();
        do
        {
            if (navigator.Name == "CurrentWeather")
            {
                navigator.MoveToFirstChild();
                do
                {
                    aux = navigator.Name;
                    switch (aux)
                    {
                        case "Location": w.Location = navigator.Value; break;
                        case "Temperature": w.Temperature = navigator.Value; break;
                        case "SkyConditions": w.SkyConditions = navigator.Value; break;
                        case "Wind": w.Wind = navigator.Value; break;
                        case "DewPoint": w.DewPoint = navigator.Value; break;
                        case "RelativeHumidity": w.RelativeHumidity = navigator.Value; break;
                        case "Pressure": w.Pressure = navigator.Value; break;
                        case "Visibility": w.Visibility = navigator.Value; break;
                        case "Time": w.Time = navigator.Value; break;                        
                    }
                } while (navigator.MoveToNext());
            }           
        }
        while (navigator.MoveToNext());

        return w;
    }



    /// <summary>
    ///  Guardar Informação sobre Meterologia
    /// </summary>
    public class Weather
    {
        string location;
        string temperature;
        string wind;
        string dewPoint;
        string skyConditions;
        string relativeHumidity;
        string pressure;
        string visibility;
        string time;


        public Weather() { }

        public string Location
        {
            get;
            set;
        }

        public string Temperature
        {
            get;
            set;
        }

        public string Wind
        {
            get;
            set;
        }

        public string DewPoint
        {
            get;
            set;
        }

        public string SkyConditions
        {
            get;
            set;
        }

        public string RelativeHumidity
        {
            get;
            set;
        }

        public string Pressure
        {
            get;
            set;
        }

        public string Visibility
        {
            get;
            set;
        }

        public string Time
        {
            get;
            set;
        }
    }
    
}