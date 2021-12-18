/*
 * lufer
 * WCF REST com POST
 * 
 * Classe para Pedido
 * */
using System.Runtime.Serialization;


[DataContract(Namespace = "http://www.ipca.pt/isi")]
    public class RequestData
    {
        [DataMember]
        public string details { get; set; }
    }
