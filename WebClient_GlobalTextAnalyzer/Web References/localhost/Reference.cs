﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Этот исходный текст был создан автоматически: Microsoft.VSDesigner, версия: 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WebClient_GlobalTextAnalyzer.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="HelloWorldPortBinding", Namespace="http://example/")]
    public partial class HelloWorldService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback makeCapsOperationCompleted;
        
        private System.Threading.SendOrPostCallback countOneWordOperationCompleted;
        
        private System.Threading.SendOrPostCallback countWordsOperationCompleted;
        
        private System.Threading.SendOrPostCallback countCharactersOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public HelloWorldService() {
            this.Url = global::WebClient_GlobalTextAnalyzer.Properties.Settings.Default.WebClient_GlobalTextAnalyzer_localhost_HelloWorldService;
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
        public event makeCapsCompletedEventHandler makeCapsCompleted;
        
        /// <remarks/>
        public event countOneWordCompletedEventHandler countOneWordCompleted;
        
        /// <remarks/>
        public event countWordsCompletedEventHandler countWordsCompleted;
        
        /// <remarks/>
        public event countCharactersCompletedEventHandler countCharactersCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://example/", ResponseNamespace="http://example/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string makeCaps([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string text) {
            object[] results = this.Invoke("makeCaps", new object[] {
                        text});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void makeCapsAsync(string text) {
            this.makeCapsAsync(text, null);
        }
        
        /// <remarks/>
        public void makeCapsAsync(string text, object userState) {
            if ((this.makeCapsOperationCompleted == null)) {
                this.makeCapsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmakeCapsOperationCompleted);
            }
            this.InvokeAsync("makeCaps", new object[] {
                        text}, this.makeCapsOperationCompleted, userState);
        }
        
        private void OnmakeCapsOperationCompleted(object arg) {
            if ((this.makeCapsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.makeCapsCompleted(this, new makeCapsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://example/", ResponseNamespace="http://example/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int countOneWord([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string text, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string word) {
            object[] results = this.Invoke("countOneWord", new object[] {
                        text,
                        word});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void countOneWordAsync(string text, string word) {
            this.countOneWordAsync(text, word, null);
        }
        
        /// <remarks/>
        public void countOneWordAsync(string text, string word, object userState) {
            if ((this.countOneWordOperationCompleted == null)) {
                this.countOneWordOperationCompleted = new System.Threading.SendOrPostCallback(this.OncountOneWordOperationCompleted);
            }
            this.InvokeAsync("countOneWord", new object[] {
                        text,
                        word}, this.countOneWordOperationCompleted, userState);
        }
        
        private void OncountOneWordOperationCompleted(object arg) {
            if ((this.countOneWordCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.countOneWordCompleted(this, new countOneWordCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://example/", ResponseNamespace="http://example/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public pair[] countWords([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string text) {
            object[] results = this.Invoke("countWords", new object[] {
                        text});
            return ((pair[])(results[0]));
        }
        
        /// <remarks/>
        public void countWordsAsync(string text) {
            this.countWordsAsync(text, null);
        }
        
        /// <remarks/>
        public void countWordsAsync(string text, object userState) {
            if ((this.countWordsOperationCompleted == null)) {
                this.countWordsOperationCompleted = new System.Threading.SendOrPostCallback(this.OncountWordsOperationCompleted);
            }
            this.InvokeAsync("countWords", new object[] {
                        text}, this.countWordsOperationCompleted, userState);
        }
        
        private void OncountWordsOperationCompleted(object arg) {
            if ((this.countWordsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.countWordsCompleted(this, new countWordsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://example/", ResponseNamespace="http://example/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public pair[] countCharacters([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string text) {
            object[] results = this.Invoke("countCharacters", new object[] {
                        text});
            return ((pair[])(results[0]));
        }
        
        /// <remarks/>
        public void countCharactersAsync(string text) {
            this.countCharactersAsync(text, null);
        }
        
        /// <remarks/>
        public void countCharactersAsync(string text, object userState) {
            if ((this.countCharactersOperationCompleted == null)) {
                this.countCharactersOperationCompleted = new System.Threading.SendOrPostCallback(this.OncountCharactersOperationCompleted);
            }
            this.InvokeAsync("countCharacters", new object[] {
                        text}, this.countCharactersOperationCompleted, userState);
        }
        
        private void OncountCharactersOperationCompleted(object arg) {
            if ((this.countCharactersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.countCharactersCompleted(this, new countCharactersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://example/")]
    public partial class pair {
        
        private string xField;
        
        private int yField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void makeCapsCompletedEventHandler(object sender, makeCapsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class makeCapsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal makeCapsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void countOneWordCompletedEventHandler(object sender, countOneWordCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class countOneWordCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal countOneWordCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void countWordsCompletedEventHandler(object sender, countWordsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class countWordsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal countWordsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public pair[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((pair[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void countCharactersCompletedEventHandler(object sender, countCharactersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class countCharactersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal countCharactersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public pair[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((pair[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591