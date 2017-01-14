﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CatchApp.CatchReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Catch", Namespace="http://schemas.datacontract.org/2004/07/ExamFishWcfService")]
    [System.SerializableAttribute()]
    public partial class Catch : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SpeciesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int WeekField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double WeightField;
        
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
        public string Species {
            get {
                return this.SpeciesField;
            }
            set {
                if ((object.ReferenceEquals(this.SpeciesField, value) != true)) {
                    this.SpeciesField = value;
                    this.RaisePropertyChanged("Species");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Week {
            get {
                return this.WeekField;
            }
            set {
                if ((this.WeekField.Equals(value) != true)) {
                    this.WeekField = value;
                    this.RaisePropertyChanged("Week");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Weight {
            get {
                return this.WeightField;
            }
            set {
                if ((this.WeightField.Equals(value) != true)) {
                    this.WeightField = value;
                    this.RaisePropertyChanged("Weight");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CatchReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCatches", ReplyAction="http://tempuri.org/IService1/GetCatchesResponse")]
        CatchApp.CatchReference.Catch[] GetCatches();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCatches", ReplyAction="http://tempuri.org/IService1/GetCatchesResponse")]
        System.Threading.Tasks.Task<CatchApp.CatchReference.Catch[]> GetCatchesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneCatch", ReplyAction="http://tempuri.org/IService1/GetOneCatchResponse")]
        CatchApp.CatchReference.Catch GetOneCatch(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneCatch", ReplyAction="http://tempuri.org/IService1/GetOneCatchResponse")]
        System.Threading.Tasks.Task<CatchApp.CatchReference.Catch> GetOneCatchAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCatch", ReplyAction="http://tempuri.org/IService1/AddCatchResponse")]
        bool AddCatch(CatchApp.CatchReference.Catch newCatch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCatch", ReplyAction="http://tempuri.org/IService1/AddCatchResponse")]
        System.Threading.Tasks.Task<bool> AddCatchAsync(CatchApp.CatchReference.Catch newCatch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCatch", ReplyAction="http://tempuri.org/IService1/DeleteCatchResponse")]
        bool DeleteCatch(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCatch", ReplyAction="http://tempuri.org/IService1/DeleteCatchResponse")]
        System.Threading.Tasks.Task<bool> DeleteCatchAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateCatch", ReplyAction="http://tempuri.org/IService1/UpdateCatchResponse")]
        bool UpdateCatch(string id, CatchApp.CatchReference.Catch myCatch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateCatch", ReplyAction="http://tempuri.org/IService1/UpdateCatchResponse")]
        System.Threading.Tasks.Task<bool> UpdateCatchAsync(string id, CatchApp.CatchReference.Catch myCatch);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : CatchApp.CatchReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<CatchApp.CatchReference.IService1>, CatchApp.CatchReference.IService1 {
        
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
        
        public CatchApp.CatchReference.Catch[] GetCatches() {
            return base.Channel.GetCatches();
        }
        
        public System.Threading.Tasks.Task<CatchApp.CatchReference.Catch[]> GetCatchesAsync() {
            return base.Channel.GetCatchesAsync();
        }
        
        public CatchApp.CatchReference.Catch GetOneCatch(string id) {
            return base.Channel.GetOneCatch(id);
        }
        
        public System.Threading.Tasks.Task<CatchApp.CatchReference.Catch> GetOneCatchAsync(string id) {
            return base.Channel.GetOneCatchAsync(id);
        }
        
        public bool AddCatch(CatchApp.CatchReference.Catch newCatch) {
            return base.Channel.AddCatch(newCatch);
        }
        
        public System.Threading.Tasks.Task<bool> AddCatchAsync(CatchApp.CatchReference.Catch newCatch) {
            return base.Channel.AddCatchAsync(newCatch);
        }
        
        public bool DeleteCatch(string id) {
            return base.Channel.DeleteCatch(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteCatchAsync(string id) {
            return base.Channel.DeleteCatchAsync(id);
        }
        
        public bool UpdateCatch(string id, CatchApp.CatchReference.Catch myCatch) {
            return base.Channel.UpdateCatch(id, myCatch);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateCatchAsync(string id, CatchApp.CatchReference.Catch myCatch) {
            return base.Channel.UpdateCatchAsync(id, myCatch);
        }
    }
}