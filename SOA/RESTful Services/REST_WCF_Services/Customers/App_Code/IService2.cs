/*
 * */

using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

//Interface para REST
[ServiceContract]
public interface IService2
{
    [OperationContract]
    [WebGet(UriTemplate = "/GetCustomer", RequestFormat = WebMessageFormat.Json,
    ResponseFormat = WebMessageFormat.Json)]
    List<Customers> GetCustomers();

    [OperationContract(Name = "GetSampleMethodWithoutOAuth")]
    [WebGet(UriTemplate = "GetSampleMethodWithoutOAuth/inputStr/{name}")]
    string GetSampleMethodWithoutOAuth(string name);

    
}
