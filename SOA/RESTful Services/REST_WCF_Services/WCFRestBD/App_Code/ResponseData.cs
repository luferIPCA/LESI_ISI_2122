/*
 * lufer
 * WCF REST com POST
 * Classe para Resposta
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


    [DataContract]
    public class ResponseData
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Age { get; set; }

        [DataMember]
        public string Exp { get; set; }

        [DataMember]
        public string Technology { get; set; }
    }

