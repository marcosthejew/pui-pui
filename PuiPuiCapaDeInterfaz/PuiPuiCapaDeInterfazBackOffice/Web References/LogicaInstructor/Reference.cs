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

namespace PuiPuiCapaDeInterfazBackOffice.LogicaInstructor {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="FachadaInstructorSoap", Namespace="http://tempuri.org/")]
    public partial class FachadaInstructor : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ServicioConsultarTodosInstructorOperationCompleted;
        
        private System.Threading.SendOrPostCallback ServicioConsultarPorIdInstructorOperationCompleted;
        
        private System.Threading.SendOrPostCallback ServicioInactivarInstructorOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public FachadaInstructor() {
            this.Url = global::PuiPuiCapaDeInterfazBackOffice.Properties.Settings.Default.PuiPuiCapaDeInterfazBackOffice_LogicaInstructor_FachadaInstructor;
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
        public event ServicioConsultarTodosInstructorCompletedEventHandler ServicioConsultarTodosInstructorCompleted;
        
        /// <remarks/>
        public event ServicioConsultarPorIdInstructorCompletedEventHandler ServicioConsultarPorIdInstructorCompleted;
        
        /// <remarks/>
        public event ServicioInactivarInstructorCompletedEventHandler ServicioInactivarInstructorCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ServicioConsultarTodosInstructor", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ServicioConsultarTodosInstructor() {
            object[] results = this.Invoke("ServicioConsultarTodosInstructor", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ServicioConsultarTodosInstructorAsync() {
            this.ServicioConsultarTodosInstructorAsync(null);
        }
        
        /// <remarks/>
        public void ServicioConsultarTodosInstructorAsync(object userState) {
            if ((this.ServicioConsultarTodosInstructorOperationCompleted == null)) {
                this.ServicioConsultarTodosInstructorOperationCompleted = new System.Threading.SendOrPostCallback(this.OnServicioConsultarTodosInstructorOperationCompleted);
            }
            this.InvokeAsync("ServicioConsultarTodosInstructor", new object[0], this.ServicioConsultarTodosInstructorOperationCompleted, userState);
        }
        
        private void OnServicioConsultarTodosInstructorOperationCompleted(object arg) {
            if ((this.ServicioConsultarTodosInstructorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ServicioConsultarTodosInstructorCompleted(this, new ServicioConsultarTodosInstructorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ServicioConsultarPorIdInstructor", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ServicioConsultarPorIdInstructor(int id) {
            object[] results = this.Invoke("ServicioConsultarPorIdInstructor", new object[] {
                        id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ServicioConsultarPorIdInstructorAsync(int id) {
            this.ServicioConsultarPorIdInstructorAsync(id, null);
        }
        
        /// <remarks/>
        public void ServicioConsultarPorIdInstructorAsync(int id, object userState) {
            if ((this.ServicioConsultarPorIdInstructorOperationCompleted == null)) {
                this.ServicioConsultarPorIdInstructorOperationCompleted = new System.Threading.SendOrPostCallback(this.OnServicioConsultarPorIdInstructorOperationCompleted);
            }
            this.InvokeAsync("ServicioConsultarPorIdInstructor", new object[] {
                        id}, this.ServicioConsultarPorIdInstructorOperationCompleted, userState);
        }
        
        private void OnServicioConsultarPorIdInstructorOperationCompleted(object arg) {
            if ((this.ServicioConsultarPorIdInstructorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ServicioConsultarPorIdInstructorCompleted(this, new ServicioConsultarPorIdInstructorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ServicioInactivarInstructor", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ServicioInactivarInstructor(int id) {
            object[] results = this.Invoke("ServicioInactivarInstructor", new object[] {
                        id});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ServicioInactivarInstructorAsync(int id) {
            this.ServicioInactivarInstructorAsync(id, null);
        }
        
        /// <remarks/>
        public void ServicioInactivarInstructorAsync(int id, object userState) {
            if ((this.ServicioInactivarInstructorOperationCompleted == null)) {
                this.ServicioInactivarInstructorOperationCompleted = new System.Threading.SendOrPostCallback(this.OnServicioInactivarInstructorOperationCompleted);
            }
            this.InvokeAsync("ServicioInactivarInstructor", new object[] {
                        id}, this.ServicioInactivarInstructorOperationCompleted, userState);
        }
        
        private void OnServicioInactivarInstructorOperationCompleted(object arg) {
            if ((this.ServicioInactivarInstructorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ServicioInactivarInstructorCompleted(this, new ServicioInactivarInstructorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void ServicioConsultarTodosInstructorCompletedEventHandler(object sender, ServicioConsultarTodosInstructorCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ServicioConsultarTodosInstructorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ServicioConsultarTodosInstructorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void ServicioConsultarPorIdInstructorCompletedEventHandler(object sender, ServicioConsultarPorIdInstructorCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ServicioConsultarPorIdInstructorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ServicioConsultarPorIdInstructorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void ServicioInactivarInstructorCompletedEventHandler(object sender, ServicioInactivarInstructorCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ServicioInactivarInstructorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ServicioInactivarInstructorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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