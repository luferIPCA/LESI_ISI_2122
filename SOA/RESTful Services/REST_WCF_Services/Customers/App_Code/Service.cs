/*
 * 
 * OAuth:
 * Adptado de https://csharp.hotexamples.com/pt/examples/OAuth/OAuthBase/-/php-oauthbase-class-examples.html
 * */

using System.Collections.Generic;
using System.Collections.Specialized;   //OAuth; NameValueCollection
using System.Net;                       //OAuth; HttpStatusCode
using System.ServiceModel.Web;          //OAuth; WebOperationContext
using System.Text;

public class Service : IService1, IService2
{
    List<Customers> lstCustomers = new List<Customers>();
    
    //Metodo SOAP
    public void Add(Customers cust)
    {
        if(!lstCustomers.Contains(cust))
             lstCustomers.Add(cust);
    }

    //Método REST
    public List<Customers> GetCustomers()
    {
        lstCustomers.Add(new Customers { CustomerID = 1, CustomerName = "Um", CustomerCity = "Barcelos" });
        return lstCustomers;
    }

    public string GetSampleMethodWithoutOAuth(string strUserName)
    {
        StringBuilder strReturnValue = new StringBuilder();
        // return username prefixed as shown below
        strReturnValue.Append(string.Format("Olá {0}", strUserName));
        return strReturnValue.ToString();
    }

   

  
}
