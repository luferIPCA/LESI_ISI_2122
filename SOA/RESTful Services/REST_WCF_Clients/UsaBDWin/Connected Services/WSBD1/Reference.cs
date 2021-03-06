//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UsaWCF_BD_WIN.WSBD1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSBD1.IDB")]
    public interface IDB {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDB/GetAllHoteis", ReplyAction="http://tempuri.org/IDB/GetAllHoteisResponse")]
        System.Data.DataSet GetAllHoteis();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IDB/GetAllHoteis", ReplyAction="http://tempuri.org/IDB/GetAllHoteisResponse")]
        System.IAsyncResult BeginGetAllHoteis(System.AsyncCallback callback, object asyncState);
        
        System.Data.DataSet EndGetAllHoteis(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDB/GetAllHoteisCidade", ReplyAction="http://tempuri.org/IDB/GetAllHoteisCidadeResponse")]
        System.Data.DataSet GetAllHoteisCidade(string cidade);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IDB/GetAllHoteisCidade", ReplyAction="http://tempuri.org/IDB/GetAllHoteisCidadeResponse")]
        System.IAsyncResult BeginGetAllHoteisCidade(string cidade, System.AsyncCallback callback, object asyncState);
        
        System.Data.DataSet EndGetAllHoteisCidade(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDB/GetAllHoteisComCapacidade", ReplyAction="http://tempuri.org/IDB/GetAllHoteisComCapacidadeResponse")]
        System.Data.DataSet GetAllHoteisComCapacidade(int capacidade);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IDB/GetAllHoteisComCapacidade", ReplyAction="http://tempuri.org/IDB/GetAllHoteisComCapacidadeResponse")]
        System.IAsyncResult BeginGetAllHoteisComCapacidade(int capacidade, System.AsyncCallback callback, object asyncState);
        
        System.Data.DataSet EndGetAllHoteisComCapacidade(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDBChannel : UsaWCF_BD_WIN.WSBD1.IDB, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllHoteisCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllHoteisCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Data.DataSet Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllHoteisCidadeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllHoteisCidadeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Data.DataSet Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllHoteisComCapacidadeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllHoteisComCapacidadeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Data.DataSet Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DBClient : System.ServiceModel.ClientBase<UsaWCF_BD_WIN.WSBD1.IDB>, UsaWCF_BD_WIN.WSBD1.IDB {
        
        private BeginOperationDelegate onBeginGetAllHoteisDelegate;
        
        private EndOperationDelegate onEndGetAllHoteisDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllHoteisCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAllHoteisCidadeDelegate;
        
        private EndOperationDelegate onEndGetAllHoteisCidadeDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllHoteisCidadeCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAllHoteisComCapacidadeDelegate;
        
        private EndOperationDelegate onEndGetAllHoteisComCapacidadeDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllHoteisComCapacidadeCompletedDelegate;
        
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
        
        public event System.EventHandler<GetAllHoteisCompletedEventArgs> GetAllHoteisCompleted;
        
        public event System.EventHandler<GetAllHoteisCidadeCompletedEventArgs> GetAllHoteisCidadeCompleted;
        
        public event System.EventHandler<GetAllHoteisComCapacidadeCompletedEventArgs> GetAllHoteisComCapacidadeCompleted;
        
        public System.Data.DataSet GetAllHoteis() {
            return base.Channel.GetAllHoteis();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAllHoteis(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllHoteis(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Data.DataSet EndGetAllHoteis(System.IAsyncResult result) {
            return base.Channel.EndGetAllHoteis(result);
        }
        
        private System.IAsyncResult OnBeginGetAllHoteis(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetAllHoteis(callback, asyncState);
        }
        
        private object[] OnEndGetAllHoteis(System.IAsyncResult result) {
            System.Data.DataSet retVal = this.EndGetAllHoteis(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllHoteisCompleted(object state) {
            if ((this.GetAllHoteisCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllHoteisCompleted(this, new GetAllHoteisCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllHoteisAsync() {
            this.GetAllHoteisAsync(null);
        }
        
        public void GetAllHoteisAsync(object userState) {
            if ((this.onBeginGetAllHoteisDelegate == null)) {
                this.onBeginGetAllHoteisDelegate = new BeginOperationDelegate(this.OnBeginGetAllHoteis);
            }
            if ((this.onEndGetAllHoteisDelegate == null)) {
                this.onEndGetAllHoteisDelegate = new EndOperationDelegate(this.OnEndGetAllHoteis);
            }
            if ((this.onGetAllHoteisCompletedDelegate == null)) {
                this.onGetAllHoteisCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllHoteisCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllHoteisDelegate, null, this.onEndGetAllHoteisDelegate, this.onGetAllHoteisCompletedDelegate, userState);
        }
        
        public System.Data.DataSet GetAllHoteisCidade(string cidade) {
            return base.Channel.GetAllHoteisCidade(cidade);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAllHoteisCidade(string cidade, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllHoteisCidade(cidade, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Data.DataSet EndGetAllHoteisCidade(System.IAsyncResult result) {
            return base.Channel.EndGetAllHoteisCidade(result);
        }
        
        private System.IAsyncResult OnBeginGetAllHoteisCidade(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string cidade = ((string)(inValues[0]));
            return this.BeginGetAllHoteisCidade(cidade, callback, asyncState);
        }
        
        private object[] OnEndGetAllHoteisCidade(System.IAsyncResult result) {
            System.Data.DataSet retVal = this.EndGetAllHoteisCidade(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllHoteisCidadeCompleted(object state) {
            if ((this.GetAllHoteisCidadeCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllHoteisCidadeCompleted(this, new GetAllHoteisCidadeCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllHoteisCidadeAsync(string cidade) {
            this.GetAllHoteisCidadeAsync(cidade, null);
        }
        
        public void GetAllHoteisCidadeAsync(string cidade, object userState) {
            if ((this.onBeginGetAllHoteisCidadeDelegate == null)) {
                this.onBeginGetAllHoteisCidadeDelegate = new BeginOperationDelegate(this.OnBeginGetAllHoteisCidade);
            }
            if ((this.onEndGetAllHoteisCidadeDelegate == null)) {
                this.onEndGetAllHoteisCidadeDelegate = new EndOperationDelegate(this.OnEndGetAllHoteisCidade);
            }
            if ((this.onGetAllHoteisCidadeCompletedDelegate == null)) {
                this.onGetAllHoteisCidadeCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllHoteisCidadeCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllHoteisCidadeDelegate, new object[] {
                        cidade}, this.onEndGetAllHoteisCidadeDelegate, this.onGetAllHoteisCidadeCompletedDelegate, userState);
        }
        
        public System.Data.DataSet GetAllHoteisComCapacidade(int capacidade) {
            return base.Channel.GetAllHoteisComCapacidade(capacidade);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAllHoteisComCapacidade(int capacidade, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllHoteisComCapacidade(capacidade, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Data.DataSet EndGetAllHoteisComCapacidade(System.IAsyncResult result) {
            return base.Channel.EndGetAllHoteisComCapacidade(result);
        }
        
        private System.IAsyncResult OnBeginGetAllHoteisComCapacidade(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int capacidade = ((int)(inValues[0]));
            return this.BeginGetAllHoteisComCapacidade(capacidade, callback, asyncState);
        }
        
        private object[] OnEndGetAllHoteisComCapacidade(System.IAsyncResult result) {
            System.Data.DataSet retVal = this.EndGetAllHoteisComCapacidade(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllHoteisComCapacidadeCompleted(object state) {
            if ((this.GetAllHoteisComCapacidadeCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllHoteisComCapacidadeCompleted(this, new GetAllHoteisComCapacidadeCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllHoteisComCapacidadeAsync(int capacidade) {
            this.GetAllHoteisComCapacidadeAsync(capacidade, null);
        }
        
        public void GetAllHoteisComCapacidadeAsync(int capacidade, object userState) {
            if ((this.onBeginGetAllHoteisComCapacidadeDelegate == null)) {
                this.onBeginGetAllHoteisComCapacidadeDelegate = new BeginOperationDelegate(this.OnBeginGetAllHoteisComCapacidade);
            }
            if ((this.onEndGetAllHoteisComCapacidadeDelegate == null)) {
                this.onEndGetAllHoteisComCapacidadeDelegate = new EndOperationDelegate(this.OnEndGetAllHoteisComCapacidade);
            }
            if ((this.onGetAllHoteisComCapacidadeCompletedDelegate == null)) {
                this.onGetAllHoteisComCapacidadeCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllHoteisComCapacidadeCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllHoteisComCapacidadeDelegate, new object[] {
                        capacidade}, this.onEndGetAllHoteisComCapacidadeDelegate, this.onGetAllHoteisComCapacidadeCompletedDelegate, userState);
        }
    }
}
