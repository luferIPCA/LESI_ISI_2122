//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalcPlus.WsExt {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SomaProd", Namespace="http://www.ipca.pt/isi/")]
    [System.SerializableAttribute()]
    public partial class SomaProd : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int PField;
        
        private int SField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int P {
            get {
                return this.PField;
            }
            set {
                if ((this.PField.Equals(value) != true)) {
                    this.PField = value;
                    this.RaisePropertyChanged("P");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int S {
            get {
                return this.SField;
            }
            set {
                if ((this.SField.Equals(value) != true)) {
                    this.SField = value;
                    this.RaisePropertyChanged("S");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.ipca.pt/isi/", ConfigurationName="WsExt.SomaSoap")]
    public interface SomaSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ipca.pt/isi/Somar", ReplyAction="*")]
        int Somar(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ipca.pt/isi/Somar", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SomarAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ipca.pt/isi/Multiplica", ReplyAction="*")]
        int Multiplica(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ipca.pt/isi/Multiplica", ReplyAction="*")]
        System.Threading.Tasks.Task<int> MultiplicaAsync(int x, int y);
        
        // CODEGEN: Generating message contract since element name SomaEMultiplicaResult from namespace http://www.ipca.pt/isi/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ipca.pt/isi/SomaEMultiplica", ReplyAction="*")]
        CalcPlus.WsExt.SomaEMultiplicaResponse SomaEMultiplica(CalcPlus.WsExt.SomaEMultiplicaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ipca.pt/isi/SomaEMultiplica", ReplyAction="*")]
        System.Threading.Tasks.Task<CalcPlus.WsExt.SomaEMultiplicaResponse> SomaEMultiplicaAsync(CalcPlus.WsExt.SomaEMultiplicaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SomaEMultiplicaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SomaEMultiplica", Namespace="http://www.ipca.pt/isi/", Order=0)]
        public CalcPlus.WsExt.SomaEMultiplicaRequestBody Body;
        
        public SomaEMultiplicaRequest() {
        }
        
        public SomaEMultiplicaRequest(CalcPlus.WsExt.SomaEMultiplicaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.ipca.pt/isi/")]
    public partial class SomaEMultiplicaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int x;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int y;
        
        public SomaEMultiplicaRequestBody() {
        }
        
        public SomaEMultiplicaRequestBody(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SomaEMultiplicaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SomaEMultiplicaResponse", Namespace="http://www.ipca.pt/isi/", Order=0)]
        public CalcPlus.WsExt.SomaEMultiplicaResponseBody Body;
        
        public SomaEMultiplicaResponse() {
        }
        
        public SomaEMultiplicaResponse(CalcPlus.WsExt.SomaEMultiplicaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.ipca.pt/isi/")]
    public partial class SomaEMultiplicaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CalcPlus.WsExt.SomaProd SomaEMultiplicaResult;
        
        public SomaEMultiplicaResponseBody() {
        }
        
        public SomaEMultiplicaResponseBody(CalcPlus.WsExt.SomaProd SomaEMultiplicaResult) {
            this.SomaEMultiplicaResult = SomaEMultiplicaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SomaSoapChannel : CalcPlus.WsExt.SomaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SomaSoapClient : System.ServiceModel.ClientBase<CalcPlus.WsExt.SomaSoap>, CalcPlus.WsExt.SomaSoap {
        
        public SomaSoapClient() {
        }
        
        public SomaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SomaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SomaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SomaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Somar(int x, int y) {
            return base.Channel.Somar(x, y);
        }
        
        public System.Threading.Tasks.Task<int> SomarAsync(int x, int y) {
            return base.Channel.SomarAsync(x, y);
        }
        
        public int Multiplica(int x, int y) {
            return base.Channel.Multiplica(x, y);
        }
        
        public System.Threading.Tasks.Task<int> MultiplicaAsync(int x, int y) {
            return base.Channel.MultiplicaAsync(x, y);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CalcPlus.WsExt.SomaEMultiplicaResponse CalcPlus.WsExt.SomaSoap.SomaEMultiplica(CalcPlus.WsExt.SomaEMultiplicaRequest request) {
            return base.Channel.SomaEMultiplica(request);
        }
        
        public CalcPlus.WsExt.SomaProd SomaEMultiplica(int x, int y) {
            CalcPlus.WsExt.SomaEMultiplicaRequest inValue = new CalcPlus.WsExt.SomaEMultiplicaRequest();
            inValue.Body = new CalcPlus.WsExt.SomaEMultiplicaRequestBody();
            inValue.Body.x = x;
            inValue.Body.y = y;
            CalcPlus.WsExt.SomaEMultiplicaResponse retVal = ((CalcPlus.WsExt.SomaSoap)(this)).SomaEMultiplica(inValue);
            return retVal.Body.SomaEMultiplicaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CalcPlus.WsExt.SomaEMultiplicaResponse> CalcPlus.WsExt.SomaSoap.SomaEMultiplicaAsync(CalcPlus.WsExt.SomaEMultiplicaRequest request) {
            return base.Channel.SomaEMultiplicaAsync(request);
        }
        
        public System.Threading.Tasks.Task<CalcPlus.WsExt.SomaEMultiplicaResponse> SomaEMultiplicaAsync(int x, int y) {
            CalcPlus.WsExt.SomaEMultiplicaRequest inValue = new CalcPlus.WsExt.SomaEMultiplicaRequest();
            inValue.Body = new CalcPlus.WsExt.SomaEMultiplicaRequestBody();
            inValue.Body.x = x;
            inValue.Body.y = y;
            return ((CalcPlus.WsExt.SomaSoap)(this)).SomaEMultiplicaAsync(inValue);
        }
    }
}
