//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.239.
// 
#pragma warning disable 1591

namespace Apps.Estruturados {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceSoap", Namespace="http://www.ipca.pt/isi")]
    public partial class Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback VariosCalculosOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetPessoasOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReverseStringOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateXMLFileOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service() {
            this.Url = global::Apps.Properties.Settings.Default.Apps_Estruturados_Service;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event VariosCalculosCompletedEventHandler VariosCalculosCompleted;
        
        /// <remarks/>
        public event GetPessoasCompletedEventHandler GetPessoasCompleted;
        
        /// <remarks/>
        public event ReverseStringCompletedEventHandler ReverseStringCompleted;
        
        /// <remarks/>
        public event CreateXMLFileCompletedEventHandler CreateXMLFileCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ipca.pt/isi/VariosCalculos", RequestNamespace="http://www.ipca.pt/isi", ResponseNamespace="http://www.ipca.pt/isi", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Varios VariosCalculos(int x, int y) {
            object[] results = this.Invoke("VariosCalculos", new object[] {
                        x,
                        y});
            return ((Varios)(results[0]));
        }
        
        /// <remarks/>
        public void VariosCalculosAsync(int x, int y) {
            this.VariosCalculosAsync(x, y, null);
        }
        
        /// <remarks/>
        public void VariosCalculosAsync(int x, int y, object userState) {
            if ((this.VariosCalculosOperationCompleted == null)) {
                this.VariosCalculosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVariosCalculosOperationCompleted);
            }
            this.InvokeAsync("VariosCalculos", new object[] {
                        x,
                        y}, this.VariosCalculosOperationCompleted, userState);
        }
        
        private void OnVariosCalculosOperationCompleted(object arg) {
            if ((this.VariosCalculosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.VariosCalculosCompleted(this, new VariosCalculosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ipca.pt/isi/GetPessoas", RequestNamespace="http://www.ipca.pt/isi", ResponseNamespace="http://www.ipca.pt/isi", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Pessoa[] GetPessoas() {
            object[] results = this.Invoke("GetPessoas", new object[0]);
            return ((Pessoa[])(results[0]));
        }
        
        /// <remarks/>
        public void GetPessoasAsync() {
            this.GetPessoasAsync(null);
        }
        
        /// <remarks/>
        public void GetPessoasAsync(object userState) {
            if ((this.GetPessoasOperationCompleted == null)) {
                this.GetPessoasOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPessoasOperationCompleted);
            }
            this.InvokeAsync("GetPessoas", new object[0], this.GetPessoasOperationCompleted, userState);
        }
        
        private void OnGetPessoasOperationCompleted(object arg) {
            if ((this.GetPessoasCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPessoasCompleted(this, new GetPessoasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ipca.pt/isi/ReverseString", RequestNamespace="http://www.ipca.pt/isi", ResponseNamespace="http://www.ipca.pt/isi", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ReverseString(string s) {
            object[] results = this.Invoke("ReverseString", new object[] {
                        s});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ReverseStringAsync(string s) {
            this.ReverseStringAsync(s, null);
        }
        
        /// <remarks/>
        public void ReverseStringAsync(string s, object userState) {
            if ((this.ReverseStringOperationCompleted == null)) {
                this.ReverseStringOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReverseStringOperationCompleted);
            }
            this.InvokeAsync("ReverseString", new object[] {
                        s}, this.ReverseStringOperationCompleted, userState);
        }
        
        private void OnReverseStringOperationCompleted(object arg) {
            if ((this.ReverseStringCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReverseStringCompleted(this, new ReverseStringCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ipca.pt/isi/CreateXMLFile", RequestNamespace="http://www.ipca.pt/isi", ResponseNamespace="http://www.ipca.pt/isi", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreateXMLFile(string algo) {
            this.Invoke("CreateXMLFile", new object[] {
                        algo});
        }
        
        /// <remarks/>
        public void CreateXMLFileAsync(string algo) {
            this.CreateXMLFileAsync(algo, null);
        }
        
        /// <remarks/>
        public void CreateXMLFileAsync(string algo, object userState) {
            if ((this.CreateXMLFileOperationCompleted == null)) {
                this.CreateXMLFileOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateXMLFileOperationCompleted);
            }
            this.InvokeAsync("CreateXMLFile", new object[] {
                        algo}, this.CreateXMLFileOperationCompleted, userState);
        }
        
        private void OnCreateXMLFileOperationCompleted(object arg) {
            if ((this.CreateXMLFileCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateXMLFileCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ipca.pt/isi")]
    public partial class Varios {
        
        private int somaField;
        
        private int subField;
        
        /// <remarks/>
        public int Soma {
            get {
                return this.somaField;
            }
            set {
                this.somaField = value;
            }
        }
        
        /// <remarks/>
        public int Sub {
            get {
                return this.subField;
            }
            set {
                this.subField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ipca.pt/isi")]
    public partial class Pessoa {
        
        private int idadeField;
        
        private string nomeField;
        
        /// <remarks/>
        public int Idade {
            get {
                return this.idadeField;
            }
            set {
                this.idadeField = value;
            }
        }
        
        /// <remarks/>
        public string Nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void VariosCalculosCompletedEventHandler(object sender, VariosCalculosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class VariosCalculosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal VariosCalculosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Varios Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Varios)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetPessoasCompletedEventHandler(object sender, GetPessoasCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetPessoasCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetPessoasCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Pessoa[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Pessoa[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void ReverseStringCompletedEventHandler(object sender, ReverseStringCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReverseStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ReverseStringCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void CreateXMLFileCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591