/*
 * Manipulação de REST POST
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFRestIII
{    
    [ServiceContract]
    public interface IEmployeeService
    {

        [OperationContract]
        [WebGet(UriTemplate = "/GetEmployeeDetails/{EmpId}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        EmployeeDataContract GetEmployeeDetails(string EmpId);

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddNewEmployee", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool AddNewEmployee(EmployeeDataContract emp);

        [OperationContract]
        [WebInvoke(Method = "PUT", ResponseFormat = WebMessageFormat.Json)]
        void UpdateEmployee(EmployeeDataContract contact);

        [OperationContract]
        [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "DeleteEmployee/{EmpId}")]
        void DeleteEmployee(string EmpId);

    }

    [DataContract]
    public class EmployeeDataContract
    {
        [DataMember]
        public string EmployeeID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string JoiningDate { get; set; }

        [DataMember]
        public string CompanyName { get; set; }

        [DataMember]
        public string Address { get; set; }
    }
}
