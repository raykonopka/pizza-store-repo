﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaStoreAPI.Service.PizzaStoreDataService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PizzaDAO", Namespace="http://schemas.datacontract.org/2004/07/PizzaStoreData.DataService.Models")]
    [System.SerializableAttribute()]
    public partial class PizzaDAO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CheeseTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CrustTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PizzaSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SauceTypeField;
        
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
        public int CheeseType {
            get {
                return this.CheeseTypeField;
            }
            set {
                if ((this.CheeseTypeField.Equals(value) != true)) {
                    this.CheeseTypeField = value;
                    this.RaisePropertyChanged("CheeseType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CrustType {
            get {
                return this.CrustTypeField;
            }
            set {
                if ((this.CrustTypeField.Equals(value) != true)) {
                    this.CrustTypeField = value;
                    this.RaisePropertyChanged("CrustType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Order {
            get {
                return this.OrderField;
            }
            set {
                if ((this.OrderField.Equals(value) != true)) {
                    this.OrderField = value;
                    this.RaisePropertyChanged("Order");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PizzaSize {
            get {
                return this.PizzaSizeField;
            }
            set {
                if ((this.PizzaSizeField.Equals(value) != true)) {
                    this.PizzaSizeField = value;
                    this.RaisePropertyChanged("PizzaSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SauceType {
            get {
                return this.SauceTypeField;
            }
            set {
                if ((this.SauceTypeField.Equals(value) != true)) {
                    this.SauceTypeField = value;
                    this.RaisePropertyChanged("SauceType");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PizzaStoreDataService.IPizzaStoreDataService")]
    public interface IPizzaStoreDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetPizzas", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetPizzasResponse")]
        PizzaStoreAPI.Service.PizzaStoreDataService.PizzaDAO[] GetPizzas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaStoreDataService/GetPizzas", ReplyAction="http://tempuri.org/IPizzaStoreDataService/GetPizzasResponse")]
        System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.PizzaDAO[]> GetPizzasAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPizzaStoreDataServiceChannel : PizzaStoreAPI.Service.PizzaStoreDataService.IPizzaStoreDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PizzaStoreDataServiceClient : System.ServiceModel.ClientBase<PizzaStoreAPI.Service.PizzaStoreDataService.IPizzaStoreDataService>, PizzaStoreAPI.Service.PizzaStoreDataService.IPizzaStoreDataService {
        
        public PizzaStoreDataServiceClient() {
        }
        
        public PizzaStoreDataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PizzaStoreDataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PizzaStoreDataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PizzaStoreDataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PizzaStoreAPI.Service.PizzaStoreDataService.PizzaDAO[] GetPizzas() {
            return base.Channel.GetPizzas();
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAPI.Service.PizzaStoreDataService.PizzaDAO[]> GetPizzasAsync() {
            return base.Channel.GetPizzasAsync();
        }
    }
}
