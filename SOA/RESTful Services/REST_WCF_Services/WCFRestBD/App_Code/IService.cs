/*
lufer

WCF REST sobre Bases de Dados 
*/
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

[ServiceContract]
public interface IService
{
    [OperationContract]
    [WebGet( ResponseFormat =WebMessageFormat.Xml, UriTemplate = "All")] //RESTful
    List<Hotel> GetHotelsList();

    [OperationContract]
    [WebGet(ResponseFormat = WebMessageFormat.Json,UriTemplate ="All/json")]
    List<Hotel> GetHotelsListJson();

    [OperationContract]
    [WebGet(UriTemplate = "Hotel/{id}")]
    Hotel GetHotelById(string id);

    [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetHotel/{n}/{c}")]
    Hotel GetHotelByIDII(string n, string c);

    [OperationContract]
    [WebInvoke(Method ="POST", UriTemplate = "AddHotel",RequestFormat =WebMessageFormat.Json)]
    void AddHotel(Hotel h);
    //Nota: Como é POST não pode ser invocado do browser...testar com Postman!

    [OperationContract]
    [WebInvoke(Method = "POST", UriTemplate = "AddOneHotel", RequestFormat =WebMessageFormat.Json, ResponseFormat =WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
    List<Hotel> AddOneHotel(Hotel h);

    [OperationContract]
    [WebInvoke(Method ="PUT", UriTemplate = "UpdateHotel/{hotelName}/{capacity}")]
    void UpdateHotel(string hotelName, string capacity);

    [OperationContract]
    [WebInvoke(Method ="DELETE", UriTemplate = "DeleteHotel/{id}")]
    void DeleteHotel(string id);

    [OperationContract]
    [WebInvoke(Method ="POST", 
        ResponseFormat =WebMessageFormat.Xml,
        RequestFormat =WebMessageFormat.Xml,
        UriTemplate ="Auth")]
    ResponseData Auth(RequestData data);


}



[DataContract(Namespace = "http://www.ipca.pt/isi")]
public class Hotel
{
    string id;
    string nome;
    string cidade;   //passar a private
    int capacidade;  //passar a private


    public Hotel() { }

    public Hotel(string n, string c, int cp)
    {
        nome = n;
        cidade = c;
        capacidade = cp;
    }

    [DataMember]
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    [DataMember]
    public string Cidade
    {
        get { return cidade; }
        set { cidade = value; }
    }

    [DataMember]
    public int Capacidade
    {
        get { return capacidade; }
        set { capacidade = value; }
    }
}
