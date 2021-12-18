/*
 * lufer
 * 
 * Restfull services implementation
 * */
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;      //necessário

//SOAP
[ServiceContract]
public interface ICalcSOAP
{
    [OperationContract]    
    int Add(int x, int y);

	[OperationContract]
    Varios SumSub(int x, int y);

    [OperationContract]  
    double Div(int x, int y);

}




//REST
[ServiceContract]
public interface ICalcREST
{
    [OperationContract]
    [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "Add/{x}/{y}")]
    int AddRest(string x, string y);

    [OperationContract]
    [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "SomaSub/{x}/{y}")]    
    Varios SumSubRest(string x, string y);

    [OperationContract]
    [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Div/{x}/{y}")]
    double DivRest(string x, string y);

}

[DataContract]
public class Varios
{
    int soma;
    int sub;
    bool succ;


    public Varios(int x, int y)
    {

    }

    public Varios()
    {

    }

    [DataMember]
	public int Soma
	{
		get { return soma; }
		set { soma = value; }
	}

	[DataMember]
	public int Sub
	{
		get { return sub; }
		set { sub = value; }
	}

    [DataMember]
    public bool Succ
    {
        get { return succ; }
        set { succ = value; }
    }

}

[DataContract]
public class MyCustomErrorDetail
{
    public MyCustomErrorDetail(string errorInfo, string errorDetails)
    {
        Reason = errorInfo;
        ErrorDetails = errorDetails;
    }
    [DataMember]
    public string Reason { get; private set; }
    [DataMember]
    public string ErrorDetails { get; private set; }
}

