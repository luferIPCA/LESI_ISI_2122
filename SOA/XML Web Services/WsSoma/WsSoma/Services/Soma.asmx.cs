/*
 * lufer
 * email: lufer@ipca.pt
 * Desc: Conjunto de Serviços de Cálculo
 * */

using System.Web.Services;

namespace WSHoje.Services
{
    /// <summary>
    /// Serviços Web ISI - Calcula a Soma
    /// </summary>
    [WebService(Namespace = "http://www.ipca.pt/isi/", Description ="Serviços Web para ISI - 2021")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Soma : System.Web.Services.WebService
    {

        [WebMethod(Description="Calcula a soma de dois valores inteiros")]
        public int Somar(int x, int y)
        {
            return x+y;
        }

        [WebMethod(Description ="Multiplca dois números")]
        public int Multiplica(int x, int y)
        {
            return (x * y);
        }


        [WebMethod(Description ="Calcula duas operações (soma e produto)")]
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public SomaProd SomaEMultiplica(int x, int y)
        {
            SomaProd aux = new SomaProd(x, y);

            return (aux);
        }
    }


    /// <summary>
    /// Class Auxiliar para Serialização
    /// </summary>
    public class SomaProd
    {
        int p;
        int s;

        public SomaProd()
        {
            p = s = 0;
        }

        public SomaProd(int x, int y)
        {
            p = x * y;
            s = x + y;
        }

        public int P
        {
            get { return p; }
            set { p = value; }
        }

        public int S
        {
            get { return s; }
            set { s = value; }
        }
    }
}
