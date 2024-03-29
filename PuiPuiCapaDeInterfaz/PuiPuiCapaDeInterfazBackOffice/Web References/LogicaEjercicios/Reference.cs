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

namespace PuiPuiCapaDeInterfazBackOffice.LogicaEjercicios {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="FachadaEjerciciosBackOfficeSoap", Namespace="http://tempuri.org/")]
    public partial class FachadaEjerciciosBackOffice : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ServicioAgregarEjercicioOperationCompleted;
        
        private System.Threading.SendOrPostCallback ServicioConsultarEjecicioIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback ServicioConsultarEjercicioTodosOperationCompleted;
        
        private System.Threading.SendOrPostCallback ServicioInactivarEjercicioOperationCompleted;
        
        private System.Threading.SendOrPostCallback ServicioModificarEjercicioOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public FachadaEjerciciosBackOffice() {
            this.Url = global::PuiPuiCapaDeInterfazBackOffice.Properties.Settings.Default.PuiPuiCapaDeInterfazBackOffice_LogicaEjercicios_FachadaEjerciciosBackOffice;
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
        public event ServicioAgregarEjercicioCompletedEventHandler ServicioAgregarEjercicioCompleted;
        
        /// <remarks/>
        public event ServicioConsultarEjecicioIdCompletedEventHandler ServicioConsultarEjecicioIdCompleted;
        
        /// <remarks/>
        public event ServicioConsultarEjercicioTodosCompletedEventHandler ServicioConsultarEjercicioTodosCompleted;
        
        /// <remarks/>
        public event ServicioInactivarEjercicioCompletedEventHandler ServicioInactivarEjercicioCompleted;
        
        /// <remarks/>
        public event ServicioModificarEjercicioCompletedEventHandler ServicioModificarEjercicioCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ServicioAgregarEjercicio", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ServicioAgregarEjercicio(string nombre, string descripcion, int idMusculo, string nombreMusculo) {
            object[] results = this.Invoke("ServicioAgregarEjercicio", new object[] {
                        nombre,
                        descripcion,
                        idMusculo,
                        nombreMusculo});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ServicioAgregarEjercicioAsync(string nombre, string descripcion, int idMusculo, string nombreMusculo) {
            this.ServicioAgregarEjercicioAsync(nombre, descripcion, idMusculo, nombreMusculo, null);
        }
        
        /// <remarks/>
        public void ServicioAgregarEjercicioAsync(string nombre, string descripcion, int idMusculo, string nombreMusculo, object userState) {
            if ((this.ServicioAgregarEjercicioOperationCompleted == null)) {
                this.ServicioAgregarEjercicioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnServicioAgregarEjercicioOperationCompleted);
            }
            this.InvokeAsync("ServicioAgregarEjercicio", new object[] {
                        nombre,
                        descripcion,
                        idMusculo,
                        nombreMusculo}, this.ServicioAgregarEjercicioOperationCompleted, userState);
        }
        
        private void OnServicioAgregarEjercicioOperationCompleted(object arg) {
            if ((this.ServicioAgregarEjercicioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ServicioAgregarEjercicioCompleted(this, new ServicioAgregarEjercicioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ServicioConsultarEjecicioId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ServicioConsultarEjecicioId(int id, string nombre) {
            object[] results = this.Invoke("ServicioConsultarEjecicioId", new object[] {
                        id,
                        nombre});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ServicioConsultarEjecicioIdAsync(int id, string nombre) {
            this.ServicioConsultarEjecicioIdAsync(id, nombre, null);
        }
        
        /// <remarks/>
        public void ServicioConsultarEjecicioIdAsync(int id, string nombre, object userState) {
            if ((this.ServicioConsultarEjecicioIdOperationCompleted == null)) {
                this.ServicioConsultarEjecicioIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnServicioConsultarEjecicioIdOperationCompleted);
            }
            this.InvokeAsync("ServicioConsultarEjecicioId", new object[] {
                        id,
                        nombre}, this.ServicioConsultarEjecicioIdOperationCompleted, userState);
        }
        
        private void OnServicioConsultarEjecicioIdOperationCompleted(object arg) {
            if ((this.ServicioConsultarEjecicioIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ServicioConsultarEjecicioIdCompleted(this, new ServicioConsultarEjecicioIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ServicioConsultarEjercicioTodos", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ServicioConsultarEjercicioTodos() {
            object[] results = this.Invoke("ServicioConsultarEjercicioTodos", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ServicioConsultarEjercicioTodosAsync() {
            this.ServicioConsultarEjercicioTodosAsync(null);
        }
        
        /// <remarks/>
        public void ServicioConsultarEjercicioTodosAsync(object userState) {
            if ((this.ServicioConsultarEjercicioTodosOperationCompleted == null)) {
                this.ServicioConsultarEjercicioTodosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnServicioConsultarEjercicioTodosOperationCompleted);
            }
            this.InvokeAsync("ServicioConsultarEjercicioTodos", new object[0], this.ServicioConsultarEjercicioTodosOperationCompleted, userState);
        }
        
        private void OnServicioConsultarEjercicioTodosOperationCompleted(object arg) {
            if ((this.ServicioConsultarEjercicioTodosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ServicioConsultarEjercicioTodosCompleted(this, new ServicioConsultarEjercicioTodosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ServicioInactivarEjercicio", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ServicioInactivarEjercicio(int id, string nombre) {
            object[] results = this.Invoke("ServicioInactivarEjercicio", new object[] {
                        id,
                        nombre});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ServicioInactivarEjercicioAsync(int id, string nombre) {
            this.ServicioInactivarEjercicioAsync(id, nombre, null);
        }
        
        /// <remarks/>
        public void ServicioInactivarEjercicioAsync(int id, string nombre, object userState) {
            if ((this.ServicioInactivarEjercicioOperationCompleted == null)) {
                this.ServicioInactivarEjercicioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnServicioInactivarEjercicioOperationCompleted);
            }
            this.InvokeAsync("ServicioInactivarEjercicio", new object[] {
                        id,
                        nombre}, this.ServicioInactivarEjercicioOperationCompleted, userState);
        }
        
        private void OnServicioInactivarEjercicioOperationCompleted(object arg) {
            if ((this.ServicioInactivarEjercicioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ServicioInactivarEjercicioCompleted(this, new ServicioInactivarEjercicioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ServicioModificarEjercicio", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ServicioModificarEjercicio(string nombreEjercicio, string descripcionEjercicio, string nombreMusculo) {
            object[] results = this.Invoke("ServicioModificarEjercicio", new object[] {
                        nombreEjercicio,
                        descripcionEjercicio,
                        nombreMusculo});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ServicioModificarEjercicioAsync(string nombreEjercicio, string descripcionEjercicio, string nombreMusculo) {
            this.ServicioModificarEjercicioAsync(nombreEjercicio, descripcionEjercicio, nombreMusculo, null);
        }
        
        /// <remarks/>
        public void ServicioModificarEjercicioAsync(string nombreEjercicio, string descripcionEjercicio, string nombreMusculo, object userState) {
            if ((this.ServicioModificarEjercicioOperationCompleted == null)) {
                this.ServicioModificarEjercicioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnServicioModificarEjercicioOperationCompleted);
            }
            this.InvokeAsync("ServicioModificarEjercicio", new object[] {
                        nombreEjercicio,
                        descripcionEjercicio,
                        nombreMusculo}, this.ServicioModificarEjercicioOperationCompleted, userState);
        }
        
        private void OnServicioModificarEjercicioOperationCompleted(object arg) {
            if ((this.ServicioModificarEjercicioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ServicioModificarEjercicioCompleted(this, new ServicioModificarEjercicioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void ServicioAgregarEjercicioCompletedEventHandler(object sender, ServicioAgregarEjercicioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ServicioAgregarEjercicioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ServicioAgregarEjercicioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void ServicioConsultarEjecicioIdCompletedEventHandler(object sender, ServicioConsultarEjecicioIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ServicioConsultarEjecicioIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ServicioConsultarEjecicioIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void ServicioConsultarEjercicioTodosCompletedEventHandler(object sender, ServicioConsultarEjercicioTodosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ServicioConsultarEjercicioTodosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ServicioConsultarEjercicioTodosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void ServicioInactivarEjercicioCompletedEventHandler(object sender, ServicioInactivarEjercicioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ServicioInactivarEjercicioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ServicioInactivarEjercicioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void ServicioModificarEjercicioCompletedEventHandler(object sender, ServicioModificarEjercicioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ServicioModificarEjercicioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ServicioModificarEjercicioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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