﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34014
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM_Client.AnalyticsReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultService", Namespace="http://schemas.datacontract.org/2004/07/CRM_Service")]
    [System.SerializableAttribute()]
    public partial class ResultService : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ValueField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
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
        public int Value {
            get {
                return this.ValueField;
            }
            set {
                if ((this.ValueField.Equals(value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AnalyticsReference.IAnalytics")]
    public interface IAnalytics {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalytics/Top5CustomersSummaDeal", ReplyAction="http://tempuri.org/IAnalytics/Top5CustomersSummaDealResponse")]
        CRM_Client.AnalyticsReference.ResultService[] Top5CustomersSummaDeal(System.DateTime fromDate, System.DateTime toDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalytics/Top5CustomersSummaDeal", ReplyAction="http://tempuri.org/IAnalytics/Top5CustomersSummaDealResponse")]
        System.Threading.Tasks.Task<CRM_Client.AnalyticsReference.ResultService[]> Top5CustomersSummaDealAsync(System.DateTime fromDate, System.DateTime toDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalytics/Top5CustomersRelevance", ReplyAction="http://tempuri.org/IAnalytics/Top5CustomersRelevanceResponse")]
        CRM_Client.AnalyticsReference.ResultService[] Top5CustomersRelevance(System.DateTime fromDate, System.DateTime toDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalytics/Top5CustomersRelevance", ReplyAction="http://tempuri.org/IAnalytics/Top5CustomersRelevanceResponse")]
        System.Threading.Tasks.Task<CRM_Client.AnalyticsReference.ResultService[]> Top5CustomersRelevanceAsync(System.DateTime fromDate, System.DateTime toDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalytics/Top5StaffSummaDeal", ReplyAction="http://tempuri.org/IAnalytics/Top5StaffSummaDealResponse")]
        CRM_Client.AnalyticsReference.ResultService[] Top5StaffSummaDeal(System.DateTime fromDate, System.DateTime toDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalytics/Top5StaffSummaDeal", ReplyAction="http://tempuri.org/IAnalytics/Top5StaffSummaDealResponse")]
        System.Threading.Tasks.Task<CRM_Client.AnalyticsReference.ResultService[]> Top5StaffSummaDealAsync(System.DateTime fromDate, System.DateTime toDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalytics/Top5StaffRelevance", ReplyAction="http://tempuri.org/IAnalytics/Top5StaffRelevanceResponse")]
        CRM_Client.AnalyticsReference.ResultService[] Top5StaffRelevance(System.DateTime fromDate, System.DateTime toDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalytics/Top5StaffRelevance", ReplyAction="http://tempuri.org/IAnalytics/Top5StaffRelevanceResponse")]
        System.Threading.Tasks.Task<CRM_Client.AnalyticsReference.ResultService[]> Top5StaffRelevanceAsync(System.DateTime fromDate, System.DateTime toDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalytics/StateTransactions", ReplyAction="http://tempuri.org/IAnalytics/StateTransactionsResponse")]
        CRM_Client.AnalyticsReference.ResultService[] StateTransactions(System.DateTime fromDate, System.DateTime toDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalytics/StateTransactions", ReplyAction="http://tempuri.org/IAnalytics/StateTransactionsResponse")]
        System.Threading.Tasks.Task<CRM_Client.AnalyticsReference.ResultService[]> StateTransactionsAsync(System.DateTime fromDate, System.DateTime toDate);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAnalyticsChannel : CRM_Client.AnalyticsReference.IAnalytics, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AnalyticsClient : System.ServiceModel.ClientBase<CRM_Client.AnalyticsReference.IAnalytics>, CRM_Client.AnalyticsReference.IAnalytics {
        
        public AnalyticsClient() {
        }
        
        public AnalyticsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AnalyticsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AnalyticsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AnalyticsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CRM_Client.AnalyticsReference.ResultService[] Top5CustomersSummaDeal(System.DateTime fromDate, System.DateTime toDate) {
            return base.Channel.Top5CustomersSummaDeal(fromDate, toDate);
        }
        
        public System.Threading.Tasks.Task<CRM_Client.AnalyticsReference.ResultService[]> Top5CustomersSummaDealAsync(System.DateTime fromDate, System.DateTime toDate) {
            return base.Channel.Top5CustomersSummaDealAsync(fromDate, toDate);
        }
        
        public CRM_Client.AnalyticsReference.ResultService[] Top5CustomersRelevance(System.DateTime fromDate, System.DateTime toDate) {
            return base.Channel.Top5CustomersRelevance(fromDate, toDate);
        }
        
        public System.Threading.Tasks.Task<CRM_Client.AnalyticsReference.ResultService[]> Top5CustomersRelevanceAsync(System.DateTime fromDate, System.DateTime toDate) {
            return base.Channel.Top5CustomersRelevanceAsync(fromDate, toDate);
        }
        
        public CRM_Client.AnalyticsReference.ResultService[] Top5StaffSummaDeal(System.DateTime fromDate, System.DateTime toDate) {
            return base.Channel.Top5StaffSummaDeal(fromDate, toDate);
        }
        
        public System.Threading.Tasks.Task<CRM_Client.AnalyticsReference.ResultService[]> Top5StaffSummaDealAsync(System.DateTime fromDate, System.DateTime toDate) {
            return base.Channel.Top5StaffSummaDealAsync(fromDate, toDate);
        }
        
        public CRM_Client.AnalyticsReference.ResultService[] Top5StaffRelevance(System.DateTime fromDate, System.DateTime toDate) {
            return base.Channel.Top5StaffRelevance(fromDate, toDate);
        }
        
        public System.Threading.Tasks.Task<CRM_Client.AnalyticsReference.ResultService[]> Top5StaffRelevanceAsync(System.DateTime fromDate, System.DateTime toDate) {
            return base.Channel.Top5StaffRelevanceAsync(fromDate, toDate);
        }
        
        public CRM_Client.AnalyticsReference.ResultService[] StateTransactions(System.DateTime fromDate, System.DateTime toDate) {
            return base.Channel.StateTransactions(fromDate, toDate);
        }
        
        public System.Threading.Tasks.Task<CRM_Client.AnalyticsReference.ResultService[]> StateTransactionsAsync(System.DateTime fromDate, System.DateTime toDate) {
            return base.Channel.StateTransactionsAsync(fromDate, toDate);
        }
    }
}
