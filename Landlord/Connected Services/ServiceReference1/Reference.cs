﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Landlord.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceCase", Namespace="http://schemas.datacontract.org/2004/07/WcfBackEndv2")]
    [System.SerializableAttribute()]
    public partial class ServiceCase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] ApiErrorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CaseNrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactEmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FlatNrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Landlord.ServiceReference1.ServiceCasePost[] PostsField;
        
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
        public string[] ApiErrors {
            get {
                return this.ApiErrorsField;
            }
            set {
                if ((object.ReferenceEquals(this.ApiErrorsField, value) != true)) {
                    this.ApiErrorsField = value;
                    this.RaisePropertyChanged("ApiErrors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CaseNr {
            get {
                return this.CaseNrField;
            }
            set {
                if ((this.CaseNrField.Equals(value) != true)) {
                    this.CaseNrField = value;
                    this.RaisePropertyChanged("CaseNr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactEmail {
            get {
                return this.ContactEmailField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactEmailField, value) != true)) {
                    this.ContactEmailField = value;
                    this.RaisePropertyChanged("ContactEmail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FlatNr {
            get {
                return this.FlatNrField;
            }
            set {
                if ((this.FlatNrField.Equals(value) != true)) {
                    this.FlatNrField = value;
                    this.RaisePropertyChanged("FlatNr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Landlord.ServiceReference1.ServiceCasePost[] Posts {
            get {
                return this.PostsField;
            }
            set {
                if ((object.ReferenceEquals(this.PostsField, value) != true)) {
                    this.PostsField = value;
                    this.RaisePropertyChanged("Posts");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceCasePost", Namespace="http://schemas.datacontract.org/2004/07/WcfBackEndv2")]
    [System.SerializableAttribute()]
    public partial class ServiceCasePost : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] ApiErrorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PrivateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserDisplayNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserEmailField;
        
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
        public string[] ApiErrors {
            get {
                return this.ApiErrorsField;
            }
            set {
                if ((object.ReferenceEquals(this.ApiErrorsField, value) != true)) {
                    this.ApiErrorsField = value;
                    this.RaisePropertyChanged("ApiErrors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Private {
            get {
                return this.PrivateField;
            }
            set {
                if ((this.PrivateField.Equals(value) != true)) {
                    this.PrivateField = value;
                    this.RaisePropertyChanged("Private");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserDisplayName {
            get {
                return this.UserDisplayNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserDisplayNameField, value) != true)) {
                    this.UserDisplayNameField = value;
                    this.RaisePropertyChanged("UserDisplayName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserEmail {
            get {
                return this.UserEmailField;
            }
            set {
                if ((object.ReferenceEquals(this.UserEmailField, value) != true)) {
                    this.UserEmailField = value;
                    this.RaisePropertyChanged("UserEmail");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllCases", ReplyAction="http://tempuri.org/IService1/GetAllCasesResponse")]
        Landlord.ServiceReference1.ServiceCase[] GetAllCases();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllCases", ReplyAction="http://tempuri.org/IService1/GetAllCasesResponse")]
        System.Threading.Tasks.Task<Landlord.ServiceReference1.ServiceCase[]> GetAllCasesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCase", ReplyAction="http://tempuri.org/IService1/GetCaseResponse")]
        Landlord.ServiceReference1.ServiceCase GetCase(int caseNr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCase", ReplyAction="http://tempuri.org/IService1/GetCaseResponse")]
        System.Threading.Tasks.Task<Landlord.ServiceReference1.ServiceCase> GetCaseAsync(int caseNr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateCase", ReplyAction="http://tempuri.org/IService1/CreateCaseResponse")]
        Landlord.ServiceReference1.ServiceCase CreateCase(Landlord.ServiceReference1.ServiceCase serviceCase);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateCase", ReplyAction="http://tempuri.org/IService1/CreateCaseResponse")]
        System.Threading.Tasks.Task<Landlord.ServiceReference1.ServiceCase> CreateCaseAsync(Landlord.ServiceReference1.ServiceCase serviceCase);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddPost", ReplyAction="http://tempuri.org/IService1/AddPostResponse")]
        Landlord.ServiceReference1.ServiceCasePost AddPost(int caseNr, Landlord.ServiceReference1.ServiceCasePost serviceCasePost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddPost", ReplyAction="http://tempuri.org/IService1/AddPostResponse")]
        System.Threading.Tasks.Task<Landlord.ServiceReference1.ServiceCasePost> AddPostAsync(int caseNr, Landlord.ServiceReference1.ServiceCasePost serviceCasePost);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Landlord.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Landlord.ServiceReference1.IService1>, Landlord.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Landlord.ServiceReference1.ServiceCase[] GetAllCases() {
            return base.Channel.GetAllCases();
        }
        
        public System.Threading.Tasks.Task<Landlord.ServiceReference1.ServiceCase[]> GetAllCasesAsync() {
            return base.Channel.GetAllCasesAsync();
        }
        
        public Landlord.ServiceReference1.ServiceCase GetCase(int caseNr) {
            return base.Channel.GetCase(caseNr);
        }
        
        public System.Threading.Tasks.Task<Landlord.ServiceReference1.ServiceCase> GetCaseAsync(int caseNr) {
            return base.Channel.GetCaseAsync(caseNr);
        }
        
        public Landlord.ServiceReference1.ServiceCase CreateCase(Landlord.ServiceReference1.ServiceCase serviceCase) {
            return base.Channel.CreateCase(serviceCase);
        }
        
        public System.Threading.Tasks.Task<Landlord.ServiceReference1.ServiceCase> CreateCaseAsync(Landlord.ServiceReference1.ServiceCase serviceCase) {
            return base.Channel.CreateCaseAsync(serviceCase);
        }
        
        public Landlord.ServiceReference1.ServiceCasePost AddPost(int caseNr, Landlord.ServiceReference1.ServiceCasePost serviceCasePost) {
            return base.Channel.AddPost(caseNr, serviceCasePost);
        }
        
        public System.Threading.Tasks.Task<Landlord.ServiceReference1.ServiceCasePost> AddPostAsync(int caseNr, Landlord.ServiceReference1.ServiceCasePost serviceCasePost) {
            return base.Channel.AddPostAsync(caseNr, serviceCasePost);
        }
    }
}
