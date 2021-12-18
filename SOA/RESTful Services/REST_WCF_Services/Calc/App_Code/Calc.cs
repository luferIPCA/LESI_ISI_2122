/*
 * lufer
 * 
 * RESTful services Calculator 
 * */

using System.Net;
using System.ServiceModel.Web;

public class Calc : ICalc
{
	
    public int Soma(string x, string y)
    {
        return (int.Parse(x) + int.Parse(y));
    }

    public Varios SumSub(string a, string b)
    {
        Varios v = new Varios();
        int x = int.Parse(a);
        int y = int.Parse(b);
        v.Soma = x + y;
        v.Sub = x - y;
        v.Succ = true;
        return v;
    }

    public double Div(string x, string y)
    {
        
        //if (double.Parse(y)==0) throw  new System.ServiceModel.Web.WebFaultException<string>("Erro", System.Net.HttpStatusCode.BadRequest);
       
        return double.Parse(x) / double.Parse(y);
    }
}
