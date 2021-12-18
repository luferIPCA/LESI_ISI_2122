using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IService
{

	[OperationContract]
	[WebGet(RequestFormat =WebMessageFormat.Json, ResponseFormat =WebMessageFormat.Json,UriTemplate ="/Prod/{x}/{y}")]
	int Prod(string x, string y);
	
}

