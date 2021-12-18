/*
 * lufer
 * email: lufer@ipca.pt
 * Desc: Conjunto de Serviços Avançados de Cálculo
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WsCalc.Services
{
    /// <summary>
    /// Summary description for CalcPlus
    /// </summary>
    [WebService(Namespace = "http://www.ipca.pt/", Description = "ISI XML Web Services")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class CalcWS : System.Web.Services.WebService
    {

        [WebMethod(Description = "Cálculo da Potência de um número")]
        public double Power(int b, int e)
        {
            return (Math.Pow(b, e));
        }

        /// <summary>
        /// Calcula a Soma usando serviço externo
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [WebMethod(Description = "Calcula a Soma de dois valores")]
        public int Soma(int x, int y)
        {
            WsExt.SomaSoapClient ws = new WsExt.SomaSoapClient();
            return (ws.Somar(x, y));
        }

        [WebMethod(Description = "Convert Fahrenheit to Celcius")]
        /// <summary>
        /// Usa serviço externo
        /// https://www.learnwebservices.com/services/tempconverter?wsdl
        /// </summary>
        /// <returns></returns>
        public double ToCelcius(double f)
        {
            ConvWs.fahrenheitToCelsiusRequest r = new ConvWs.fahrenheitToCelsiusRequest();
            r.TemperatureInFahrenheit = f;
            ConvWs.TempConverterEndpointClient ws = new ConvWs.TempConverterEndpointClient();
            
            return ws.FahrenheitToCelsius(r).TemperatureInCelsius;
        }
    }
}
