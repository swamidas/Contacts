﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contacts.ContactServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contact", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Contact : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Contacts.ContactServiceReference.Address AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DOBField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Contacts.ContactServiceReference.Gender GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<Contacts.ContactServiceReference.Hobby> HobbiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LNameField;
        
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
        public Contacts.ContactServiceReference.Address Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DOB {
            get {
                return this.DOBField;
            }
            set {
                if ((this.DOBField.Equals(value) != true)) {
                    this.DOBField = value;
                    this.RaisePropertyChanged("DOB");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FName {
            get {
                return this.FNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FNameField, value) != true)) {
                    this.FNameField = value;
                    this.RaisePropertyChanged("FName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Contacts.ContactServiceReference.Gender Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((this.GenderField.Equals(value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Contacts.ContactServiceReference.Hobby> Hobbies {
            get {
                return this.HobbiesField;
            }
            set {
                if ((object.ReferenceEquals(this.HobbiesField, value) != true)) {
                    this.HobbiesField = value;
                    this.RaisePropertyChanged("Hobbies");
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
        public string LName {
            get {
                return this.LNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LNameField, value) != true)) {
                    this.LNameField = value;
                    this.RaisePropertyChanged("LName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Address", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Address : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StreetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ZipField;
        
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
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Street {
            get {
                return this.StreetField;
            }
            set {
                if ((object.ReferenceEquals(this.StreetField, value) != true)) {
                    this.StreetField = value;
                    this.RaisePropertyChanged("Street");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Zip {
            get {
                return this.ZipField;
            }
            set {
                if ((this.ZipField.Equals(value) != true)) {
                    this.ZipField = value;
                    this.RaisePropertyChanged("Zip");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Gender", Namespace="http://schemas.datacontract.org/2004/07/")]
    public enum Gender : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Male = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Female = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Hobby", Namespace="http://schemas.datacontract.org/2004/07/")]
    public enum Hobby : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Drawing = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Reading = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Coding = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Cricket = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Carrom = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Tennis = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Cooking = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Movies = 7,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ContactServiceReference.IContactService")]
    public interface IContactService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/List", ReplyAction="http://tempuri.org/IContactService/ListResponse")]
        System.Collections.Generic.List<Contacts.ContactServiceReference.Contact> List();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/List", ReplyAction="http://tempuri.org/IContactService/ListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Contacts.ContactServiceReference.Contact>> ListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/Details", ReplyAction="http://tempuri.org/IContactService/DetailsResponse")]
        Contacts.ContactServiceReference.Contact Details(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/Details", ReplyAction="http://tempuri.org/IContactService/DetailsResponse")]
        System.Threading.Tasks.Task<Contacts.ContactServiceReference.Contact> DetailsAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/Insert", ReplyAction="http://tempuri.org/IContactService/InsertResponse")]
        void Insert(Contacts.ContactServiceReference.Contact item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/Insert", ReplyAction="http://tempuri.org/IContactService/InsertResponse")]
        System.Threading.Tasks.Task InsertAsync(Contacts.ContactServiceReference.Contact item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/Update", ReplyAction="http://tempuri.org/IContactService/UpdateResponse")]
        void Update(int id, Contacts.ContactServiceReference.Contact item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/Update", ReplyAction="http://tempuri.org/IContactService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(int id, Contacts.ContactServiceReference.Contact item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/Delete", ReplyAction="http://tempuri.org/IContactService/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/Delete", ReplyAction="http://tempuri.org/IContactService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IContactServiceChannel : Contacts.ContactServiceReference.IContactService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ContactServiceClient : System.ServiceModel.ClientBase<Contacts.ContactServiceReference.IContactService>, Contacts.ContactServiceReference.IContactService {
        
        public ContactServiceClient() {
        }
        
        public ContactServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ContactServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContactServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContactServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Contacts.ContactServiceReference.Contact> List() {
            return base.Channel.List();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Contacts.ContactServiceReference.Contact>> ListAsync() {
            return base.Channel.ListAsync();
        }
        
        public Contacts.ContactServiceReference.Contact Details(int id) {
            return base.Channel.Details(id);
        }
        
        public System.Threading.Tasks.Task<Contacts.ContactServiceReference.Contact> DetailsAsync(int id) {
            return base.Channel.DetailsAsync(id);
        }
        
        public void Insert(Contacts.ContactServiceReference.Contact item) {
            base.Channel.Insert(item);
        }
        
        public System.Threading.Tasks.Task InsertAsync(Contacts.ContactServiceReference.Contact item) {
            return base.Channel.InsertAsync(item);
        }
        
        public void Update(int id, Contacts.ContactServiceReference.Contact item) {
            base.Channel.Update(id, item);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(int id, Contacts.ContactServiceReference.Contact item) {
            return base.Channel.UpdateAsync(id, item);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}
