﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações a este ficheiro poderão provocar um comportamento incorrecto e perder-se-ão se
//     o código for regenerado.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UsaBD.WSHoteis {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSHoteis.IDB")]
    public interface IDB {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDB/GetHoteis", ReplyAction="http://tempuri.org/IDB/GetHoteisResponse")]
        System.Data.DataSet GetHoteis();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDBChannel : UsaBD.WSHoteis.IDB, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DBClient : System.ServiceModel.ClientBase<UsaBD.WSHoteis.IDB>, UsaBD.WSHoteis.IDB {
        
        public DBClient() {
        }
        
        public DBClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DBClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetHoteis() {
            return base.Channel.GetHoteis();
        }
    }
}
