/*
 * lufer
 * 
 * Restfull services implementation
 * */
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;      //necessário

[ServiceContract]
public interface ICalc
{

    [OperationContract]
    [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "Add/{x}/{y}")]
    int Soma(string x, string y);

	[OperationContract]
    [WebInvoke(Method ="GET",ResponseFormat =WebMessageFormat.Xml,UriTemplate = "SomaSub/{x}/{y}")]
    //[WebInvoke(Method ="POST", ResponseFormat =WebMessageFormat.Json, UriTemplate = "SomaSub/{x}/{y}")]
    Varios SumSub(string x, string y);

    [OperationContract]
    [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Div/{x}/{y}")]
    double Div(string x, string y);

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

