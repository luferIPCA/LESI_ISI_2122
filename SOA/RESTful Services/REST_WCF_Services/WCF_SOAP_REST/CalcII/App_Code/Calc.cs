/*
 * lufer
 * 
 * RESTful services Calculator 
 * 
 * REST e SOAP
 * 
 * 2017-2018
 * */

using System.Net;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;   //necessário


public class CalcService : ICalcREST, ICalcSOAP
{
    #region IMPLEMENT_REST
    public int AddRest(string x, string y)
    {
        return (int.Parse(x) + int.Parse(y));
    }

    public Varios SumSubRest(string a, string b)
    {
        Varios v = new Varios();
        int x = int.Parse(a);
        int y = int.Parse(b);
        v.Soma = x + y;
        v.Sub = x - y;
        v.Succ = true;
        return v;
    }

    public double DivRest(string x, string y)
    {

        //if (double.Parse(y)==0) throw  new System.ServiceModel.Web.WebFaultException<string>("Erro", System.Net.HttpStatusCode.BadRequest);

        if (double.Parse(y) == 0)
        {
            MyCustomErrorDetail customError = new MyCustomErrorDetail("Divide by Zero!", "Impossivel");
            throw new WebFaultException<MyCustomErrorDetail>(customError, HttpStatusCode.NotFound);
        }
        return double.Parse(x) / double.Parse(y);
    }

    #endregion

    #region IMPLEMENT_SOAP
    public int Add(int x, int y)
    {
        return x + y;
    }

    public Varios SumSub(int x, int y)
    {
        return new Varios(x, y);
    }

    public double Div(int x, int y)
    {
        return (x / y);
    }
    #endregion
}

//public class CalcService : ICalcREST
//{
//    #region IMPLEMENT_REST
//    public int AddRest(string x, string y)
//    {
//        return (int.Parse(x) + int.Parse(y));
//    }

//    public Varios SumSubRest(string a, string b)
//    {
//        Varios v = new Varios();
//        int x = int.Parse(a);
//        int y = int.Parse(b);
//        v.Soma = x + y;
//        v.Sub = x - y;
//        v.Succ = true;
//        return v;
//    }

//    public double DivRest(string x, string y)
//    {
//        return double.Parse(x) / double.Parse(y);
//    }

//    #endregion

//}
