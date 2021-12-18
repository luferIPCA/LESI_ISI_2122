/*
 * lufer
 * email: lufer@ipca.pt
 * Desc: Conjunto de Serviços Avançados de Cálculo
 * */

using System;
using System.Web.Services;

namespace CalcPlus.Services
{
    /// <summary>
    /// Summary description for CalcPlus
    /// </summary>
    [WebService(Namespace = "http://www.ipca.pt/", Description ="ISI XML Web Services")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
  
    public class CalcPlus : WebService
    {
        [WebMethod(Description ="Cálculo da Potência de um número")]
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
        [WebMethod(Description ="Calcula a Soma de dois valores")]
        public int Soma(int x, int y)
        {
            WsExt.SomaSoapClient ws = new WsExt.SomaSoapClient();
            return (ws.Somar(x, y));
        }

        [WebMethod(Description = "Get All Continent Names")]
        /// <summary>
        /// Usa serviço externo
        /// http://webservices.oorsprong.org/websamples.countryinfo/CountryInfoService.wso?WSDL
        /// </summary>
        /// <returns></returns>
        public string[] ContinentsNames ()
        {
            CountryInfoWs.CountryInfoServiceSoapTypeClient ws = new CountryInfoWs.CountryInfoServiceSoapTypeClient();
            CountryInfoWs.tContinent[] aux = ws.ListOfContinentsByName();
            string[] nomesPaises = new string[aux.Length];
            int i = 0;
            foreach(CountryInfoWs.tContinent c in aux)
            {
                nomesPaises[i++] = c.sName;
            }
            return nomesPaises;
        }

    }
}
