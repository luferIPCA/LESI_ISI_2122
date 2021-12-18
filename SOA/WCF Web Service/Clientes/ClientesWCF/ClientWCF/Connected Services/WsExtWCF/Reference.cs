﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientWCF.WsExtWCF {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pessoa", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Pessoa : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Idade {
            get {
                return this.IdadeField;
            }
            set {
                if ((this.IdadeField.Equals(value) != true)) {
                    this.IdadeField = value;
                    this.RaisePropertyChanged("Idade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WsExtWCF.ICalc")]
    public interface ICalc {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/Soma", ReplyAction="http://tempuri.org/ICalc/SomaResponse")]
        int Soma(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ICalc/Soma", ReplyAction="http://tempuri.org/ICalc/SomaResponse")]
        System.IAsyncResult BeginSoma(int x, int y, System.AsyncCallback callback, object asyncState);
        
        int EndSoma(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/GetPessoa", ReplyAction="http://tempuri.org/ICalc/GetPessoaResponse")]
        ClientWCF.WsExtWCF.Pessoa GetPessoa(string nome, int idade);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ICalc/GetPessoa", ReplyAction="http://tempuri.org/ICalc/GetPessoaResponse")]
        System.IAsyncResult BeginGetPessoa(string nome, int idade, System.AsyncCallback callback, object asyncState);
        
        ClientWCF.WsExtWCF.Pessoa EndGetPessoa(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/GetAll", ReplyAction="http://tempuri.org/ICalc/GetAllResponse")]
        ClientWCF.WsExtWCF.Pessoa[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ICalc/GetAll", ReplyAction="http://tempuri.org/ICalc/GetAllResponse")]
        System.IAsyncResult BeginGetAll(System.AsyncCallback callback, object asyncState);
        
        ClientWCF.WsExtWCF.Pessoa[] EndGetAll(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalc/GetPessoas", ReplyAction="http://tempuri.org/ICalc/GetPessoasResponse")]
        ClientWCF.WsExtWCF.Pessoa[] GetPessoas();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ICalc/GetPessoas", ReplyAction="http://tempuri.org/ICalc/GetPessoasResponse")]
        System.IAsyncResult BeginGetPessoas(System.AsyncCallback callback, object asyncState);
        
        ClientWCF.WsExtWCF.Pessoa[] EndGetPessoas(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalcChannel : ClientWCF.WsExtWCF.ICalc, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SomaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public SomaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetPessoaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetPessoaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public ClientWCF.WsExtWCF.Pessoa Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((ClientWCF.WsExtWCF.Pessoa)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public ClientWCF.WsExtWCF.Pessoa[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((ClientWCF.WsExtWCF.Pessoa[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetPessoasCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetPessoasCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public ClientWCF.WsExtWCF.Pessoa[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((ClientWCF.WsExtWCF.Pessoa[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcClient : System.ServiceModel.ClientBase<ClientWCF.WsExtWCF.ICalc>, ClientWCF.WsExtWCF.ICalc {
        
        private BeginOperationDelegate onBeginSomaDelegate;
        
        private EndOperationDelegate onEndSomaDelegate;
        
        private System.Threading.SendOrPostCallback onSomaCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetPessoaDelegate;
        
        private EndOperationDelegate onEndGetPessoaDelegate;
        
        private System.Threading.SendOrPostCallback onGetPessoaCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAllDelegate;
        
        private EndOperationDelegate onEndGetAllDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetPessoasDelegate;
        
        private EndOperationDelegate onEndGetPessoasDelegate;
        
        private System.Threading.SendOrPostCallback onGetPessoasCompletedDelegate;
        
        public CalcClient() {
        }
        
        public CalcClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalcClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<SomaCompletedEventArgs> SomaCompleted;
        
        public event System.EventHandler<GetPessoaCompletedEventArgs> GetPessoaCompleted;
        
        public event System.EventHandler<GetAllCompletedEventArgs> GetAllCompleted;
        
        public event System.EventHandler<GetPessoasCompletedEventArgs> GetPessoasCompleted;
        
        public int Soma(int x, int y) {
            return base.Channel.Soma(x, y);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginSoma(int x, int y, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSoma(x, y, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public int EndSoma(System.IAsyncResult result) {
            return base.Channel.EndSoma(result);
        }
        
        private System.IAsyncResult OnBeginSoma(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int x = ((int)(inValues[0]));
            int y = ((int)(inValues[1]));
            return this.BeginSoma(x, y, callback, asyncState);
        }
        
        private object[] OnEndSoma(System.IAsyncResult result) {
            int retVal = this.EndSoma(result);
            return new object[] {
                    retVal};
        }
        
        private void OnSomaCompleted(object state) {
            if ((this.SomaCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SomaCompleted(this, new SomaCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SomaAsync(int x, int y) {
            this.SomaAsync(x, y, null);
        }
        
        public void SomaAsync(int x, int y, object userState) {
            if ((this.onBeginSomaDelegate == null)) {
                this.onBeginSomaDelegate = new BeginOperationDelegate(this.OnBeginSoma);
            }
            if ((this.onEndSomaDelegate == null)) {
                this.onEndSomaDelegate = new EndOperationDelegate(this.OnEndSoma);
            }
            if ((this.onSomaCompletedDelegate == null)) {
                this.onSomaCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSomaCompleted);
            }
            base.InvokeAsync(this.onBeginSomaDelegate, new object[] {
                        x,
                        y}, this.onEndSomaDelegate, this.onSomaCompletedDelegate, userState);
        }
        
        public ClientWCF.WsExtWCF.Pessoa GetPessoa(string nome, int idade) {
            return base.Channel.GetPessoa(nome, idade);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetPessoa(string nome, int idade, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetPessoa(nome, idade, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public ClientWCF.WsExtWCF.Pessoa EndGetPessoa(System.IAsyncResult result) {
            return base.Channel.EndGetPessoa(result);
        }
        
        private System.IAsyncResult OnBeginGetPessoa(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string nome = ((string)(inValues[0]));
            int idade = ((int)(inValues[1]));
            return this.BeginGetPessoa(nome, idade, callback, asyncState);
        }
        
        private object[] OnEndGetPessoa(System.IAsyncResult result) {
            ClientWCF.WsExtWCF.Pessoa retVal = this.EndGetPessoa(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetPessoaCompleted(object state) {
            if ((this.GetPessoaCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetPessoaCompleted(this, new GetPessoaCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetPessoaAsync(string nome, int idade) {
            this.GetPessoaAsync(nome, idade, null);
        }
        
        public void GetPessoaAsync(string nome, int idade, object userState) {
            if ((this.onBeginGetPessoaDelegate == null)) {
                this.onBeginGetPessoaDelegate = new BeginOperationDelegate(this.OnBeginGetPessoa);
            }
            if ((this.onEndGetPessoaDelegate == null)) {
                this.onEndGetPessoaDelegate = new EndOperationDelegate(this.OnEndGetPessoa);
            }
            if ((this.onGetPessoaCompletedDelegate == null)) {
                this.onGetPessoaCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetPessoaCompleted);
            }
            base.InvokeAsync(this.onBeginGetPessoaDelegate, new object[] {
                        nome,
                        idade}, this.onEndGetPessoaDelegate, this.onGetPessoaCompletedDelegate, userState);
        }
        
        public ClientWCF.WsExtWCF.Pessoa[] GetAll() {
            return base.Channel.GetAll();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAll(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAll(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public ClientWCF.WsExtWCF.Pessoa[] EndGetAll(System.IAsyncResult result) {
            return base.Channel.EndGetAll(result);
        }
        
        private System.IAsyncResult OnBeginGetAll(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetAll(callback, asyncState);
        }
        
        private object[] OnEndGetAll(System.IAsyncResult result) {
            ClientWCF.WsExtWCF.Pessoa[] retVal = this.EndGetAll(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllCompleted(object state) {
            if ((this.GetAllCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllCompleted(this, new GetAllCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllAsync() {
            this.GetAllAsync(null);
        }
        
        public void GetAllAsync(object userState) {
            if ((this.onBeginGetAllDelegate == null)) {
                this.onBeginGetAllDelegate = new BeginOperationDelegate(this.OnBeginGetAll);
            }
            if ((this.onEndGetAllDelegate == null)) {
                this.onEndGetAllDelegate = new EndOperationDelegate(this.OnEndGetAll);
            }
            if ((this.onGetAllCompletedDelegate == null)) {
                this.onGetAllCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllDelegate, null, this.onEndGetAllDelegate, this.onGetAllCompletedDelegate, userState);
        }
        
        public ClientWCF.WsExtWCF.Pessoa[] GetPessoas() {
            return base.Channel.GetPessoas();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetPessoas(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetPessoas(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public ClientWCF.WsExtWCF.Pessoa[] EndGetPessoas(System.IAsyncResult result) {
            return base.Channel.EndGetPessoas(result);
        }
        
        private System.IAsyncResult OnBeginGetPessoas(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetPessoas(callback, asyncState);
        }
        
        private object[] OnEndGetPessoas(System.IAsyncResult result) {
            ClientWCF.WsExtWCF.Pessoa[] retVal = this.EndGetPessoas(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetPessoasCompleted(object state) {
            if ((this.GetPessoasCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetPessoasCompleted(this, new GetPessoasCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetPessoasAsync() {
            this.GetPessoasAsync(null);
        }
        
        public void GetPessoasAsync(object userState) {
            if ((this.onBeginGetPessoasDelegate == null)) {
                this.onBeginGetPessoasDelegate = new BeginOperationDelegate(this.OnBeginGetPessoas);
            }
            if ((this.onEndGetPessoasDelegate == null)) {
                this.onEndGetPessoasDelegate = new EndOperationDelegate(this.OnEndGetPessoas);
            }
            if ((this.onGetPessoasCompletedDelegate == null)) {
                this.onGetPessoasCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetPessoasCompleted);
            }
            base.InvokeAsync(this.onBeginGetPessoasDelegate, null, this.onEndGetPessoasDelegate, this.onGetPessoasCompletedDelegate, userState);
        }
    }
}
