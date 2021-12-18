/*
 * */
using System.Collections.Generic;
using System.ServiceModel;

//Interface para SOAP
[ServiceContract]
public interface IService1
{
    [OperationContract]
    void Add(Customers cust);
}

public class Customers
{
    public int CustomerID { get; set; }
    public string CustomerName { get; set; }
    public string CustomerCity { get; set; }
}


