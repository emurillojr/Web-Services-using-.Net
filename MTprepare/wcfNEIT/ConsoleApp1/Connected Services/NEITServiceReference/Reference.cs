﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1.NEITServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/wcfNEIT")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsoleApp1.NEITServiceReference.Item[] itemsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string orderIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string shopperAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string shopperNameField;
        
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
        public ConsoleApp1.NEITServiceReference.Item[] items {
            get {
                return this.itemsField;
            }
            set {
                if ((object.ReferenceEquals(this.itemsField, value) != true)) {
                    this.itemsField = value;
                    this.RaisePropertyChanged("items");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string orderId {
            get {
                return this.orderIdField;
            }
            set {
                if ((object.ReferenceEquals(this.orderIdField, value) != true)) {
                    this.orderIdField = value;
                    this.RaisePropertyChanged("orderId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shopperAddress {
            get {
                return this.shopperAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.shopperAddressField, value) != true)) {
                    this.shopperAddressField = value;
                    this.RaisePropertyChanged("shopperAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shopperName {
            get {
                return this.shopperNameField;
            }
            set {
                if ((object.ReferenceEquals(this.shopperNameField, value) != true)) {
                    this.shopperNameField = value;
                    this.RaisePropertyChanged("shopperName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/wcfNEIT")]
    [System.SerializableAttribute()]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsoleApp1.NEITServiceReference.CustomerOptions OptionsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string costField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string skuField;
        
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
        public ConsoleApp1.NEITServiceReference.CustomerOptions Options {
            get {
                return this.OptionsField;
            }
            set {
                if ((object.ReferenceEquals(this.OptionsField, value) != true)) {
                    this.OptionsField = value;
                    this.RaisePropertyChanged("Options");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cost {
            get {
                return this.costField;
            }
            set {
                if ((object.ReferenceEquals(this.costField, value) != true)) {
                    this.costField = value;
                    this.RaisePropertyChanged("cost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string sku {
            get {
                return this.skuField;
            }
            set {
                if ((object.ReferenceEquals(this.skuField, value) != true)) {
                    this.skuField = value;
                    this.RaisePropertyChanged("sku");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerOptions", Namespace="http://schemas.datacontract.org/2004/07/wcfNEIT")]
    [System.SerializableAttribute()]
    public partial class CustomerOptions : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string colorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string sizeField;
        
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
        public string color {
            get {
                return this.colorField;
            }
            set {
                if ((object.ReferenceEquals(this.colorField, value) != true)) {
                    this.colorField = value;
                    this.RaisePropertyChanged("color");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string size {
            get {
                return this.sizeField;
            }
            set {
                if ((object.ReferenceEquals(this.sizeField, value) != true)) {
                    this.sizeField = value;
                    this.RaisePropertyChanged("size");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NEITServiceReference.INEITStoreOrdersService")]
    public interface INEITStoreOrdersService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INEITStoreOrdersService/ReturnDoubleOrderID", ReplyAction="http://tempuri.org/INEITStoreOrdersService/ReturnDoubleOrderIDResponse")]
        int ReturnDoubleOrderID(int orderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INEITStoreOrdersService/ReturnDoubleOrderID", ReplyAction="http://tempuri.org/INEITStoreOrdersService/ReturnDoubleOrderIDResponse")]
        System.Threading.Tasks.Task<int> ReturnDoubleOrderIDAsync(int orderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INEITStoreOrdersService/GetOrder", ReplyAction="http://tempuri.org/INEITStoreOrdersService/GetOrderResponse")]
        ConsoleApp1.NEITServiceReference.Order GetOrder(int orderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INEITStoreOrdersService/GetOrder", ReplyAction="http://tempuri.org/INEITStoreOrdersService/GetOrderResponse")]
        System.Threading.Tasks.Task<ConsoleApp1.NEITServiceReference.Order> GetOrderAsync(int orderID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INEITStoreOrdersServiceChannel : ConsoleApp1.NEITServiceReference.INEITStoreOrdersService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NEITStoreOrdersServiceClient : System.ServiceModel.ClientBase<ConsoleApp1.NEITServiceReference.INEITStoreOrdersService>, ConsoleApp1.NEITServiceReference.INEITStoreOrdersService {
        
        public NEITStoreOrdersServiceClient() {
        }
        
        public NEITStoreOrdersServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NEITStoreOrdersServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NEITStoreOrdersServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NEITStoreOrdersServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int ReturnDoubleOrderID(int orderID) {
            return base.Channel.ReturnDoubleOrderID(orderID);
        }
        
        public System.Threading.Tasks.Task<int> ReturnDoubleOrderIDAsync(int orderID) {
            return base.Channel.ReturnDoubleOrderIDAsync(orderID);
        }
        
        public ConsoleApp1.NEITServiceReference.Order GetOrder(int orderID) {
            return base.Channel.GetOrder(orderID);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp1.NEITServiceReference.Order> GetOrderAsync(int orderID) {
            return base.Channel.GetOrderAsync(orderID);
        }
    }
}
