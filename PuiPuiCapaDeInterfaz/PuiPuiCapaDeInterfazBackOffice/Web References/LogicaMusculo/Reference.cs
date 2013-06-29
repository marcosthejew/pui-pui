﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18047
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.18047.
// 
#pragma warning disable 1591

namespace PuiPuiCapaDeInterfazBackOffice.LogicaMusculo {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="FachadaMusculosSoap", Namespace="http://tempuri.org/")]
    public partial class FachadaMusculos : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ServicioAgregarMusculoOperationCompleted;
        
        private System.Threading.SendOrPostCallback ServicioConsultarTodosLosMusculosOperationCompleted;
        
        private System.Threading.SendOrPostCallback ServicioDesactivarMusculoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public FachadaMusculos() {
            this.Url = global::PuiPuiCapaDeInterfazBackOffice.Properties.Settings.Default.PuiPuiCapaDeInterfazBackOffice_LogicaMusculo_FachadaMusculos;
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
        public event ServicioAgregarMusculoCompletedEventHandler ServicioAgregarMusculoCompleted;
        
        /// <remarks/>
        public event ServicioConsultarTodosLosMusculosCompletedEventHandler ServicioConsultarTodosLosMusculosCompleted;
        
        /// <remarks/>
        public event ServicioDesactivarMusculoCompletedEventHandler ServicioDesactivarMusculoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ServicioAgregarMusculo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ServicioAgregarMusculo(string nombre, string descripcion) {
            object[] results = this.Invoke("ServicioAgregarMusculo", new object[] {
                        nombre,
                        descripcion});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ServicioAgregarMusculoAsync(string nombre, string descripcion) {
            this.ServicioAgregarMusculoAsync(nombre, descripcion, null);
        }
        
        /// <remarks/>
        public void ServicioAgregarMusculoAsync(string nombre, string descripcion, object userState) {
            if ((this.ServicioAgregarMusculoOperationCompleted == null)) {
                this.ServicioAgregarMusculoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnServicioAgregarMusculoOperationCompleted);
            }
            this.InvokeAsync("ServicioAgregarMusculo", new object[] {
                        nombre,
                        descripcion}, this.ServicioAgregarMusculoOperationCompleted, userState);
        }
        
        private void OnServicioAgregarMusculoOperationCompleted(object arg) {
            if ((this.ServicioAgregarMusculoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ServicioAgregarMusculoCompleted(this, new ServicioAgregarMusculoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ServicioConsultarTodosLosMusculos", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ServicioConsultarTodosLosMusculos() {
            object[] results = this.Invoke("ServicioConsultarTodosLosMusculos", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ServicioConsultarTodosLosMusculosAsync() {
            this.ServicioConsultarTodosLosMusculosAsync(null);
        }
        
        /// <remarks/>
        public void ServicioConsultarTodosLosMusculosAsync(object userState) {
            if ((this.ServicioConsultarTodosLosMusculosOperationCompleted == null)) {
                this.ServicioConsultarTodosLosMusculosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnServicioConsultarTodosLosMusculosOperationCompleted);
            }
            this.InvokeAsync("ServicioConsultarTodosLosMusculos", new object[0], this.ServicioConsultarTodosLosMusculosOperationCompleted, userState);
        }
        
        private void OnServicioConsultarTodosLosMusculosOperationCompleted(object arg) {
            if ((this.ServicioConsultarTodosLosMusculosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ServicioConsultarTodosLosMusculosCompleted(this, new ServicioConsultarTodosLosMusculosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ServicioDesactivarMusculo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ServicioDesactivarMusculo(int idMusculo, string nombre) {
            object[] results = this.Invoke("ServicioDesactivarMusculo", new object[] {
                        idMusculo,
                        nombre});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ServicioDesactivarMusculoAsync(int idMusculo, string nombre) {
            this.ServicioDesactivarMusculoAsync(idMusculo, nombre, null);
        }
        
        /// <remarks/>
        public void ServicioDesactivarMusculoAsync(int idMusculo, string nombre, object userState) {
            if ((this.ServicioDesactivarMusculoOperationCompleted == null)) {
                this.ServicioDesactivarMusculoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnServicioDesactivarMusculoOperationCompleted);
            }
            this.InvokeAsync("ServicioDesactivarMusculo", new object[] {
                        idMusculo,
                        nombre}, this.ServicioDesactivarMusculoOperationCompleted, userState);
        }
        
        private void OnServicioDesactivarMusculoOperationCompleted(object arg) {
            if ((this.ServicioDesactivarMusculoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ServicioDesactivarMusculoCompleted(this, new ServicioDesactivarMusculoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void ServicioAgregarMusculoCompletedEventHandler(object sender, ServicioAgregarMusculoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ServicioAgregarMusculoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ServicioAgregarMusculoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void ServicioConsultarTodosLosMusculosCompletedEventHandler(object sender, ServicioConsultarTodosLosMusculosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ServicioConsultarTodosLosMusculosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ServicioConsultarTodosLosMusculosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void ServicioDesactivarMusculoCompletedEventHandler(object sender, ServicioDesactivarMusculoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ServicioDesactivarMusculoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ServicioDesactivarMusculoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591