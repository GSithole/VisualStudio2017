﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfWebClient.CrudService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CrudService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getContacts", ReplyAction="http://tempuri.org/IService1/getContactsResponse")]
        ContactClassLibrary.Contact[] getContacts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getContacts", ReplyAction="http://tempuri.org/IService1/getContactsResponse")]
        System.Threading.Tasks.Task<ContactClassLibrary.Contact[]> getContactsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Details", ReplyAction="http://tempuri.org/IService1/DetailsResponse")]
        ContactClassLibrary.Contact Details(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Details", ReplyAction="http://tempuri.org/IService1/DetailsResponse")]
        System.Threading.Tasks.Task<ContactClassLibrary.Contact> DetailsAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/edit", ReplyAction="http://tempuri.org/IService1/editResponse")]
        void edit(int id, ContactClassLibrary.Contact contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/edit", ReplyAction="http://tempuri.org/IService1/editResponse")]
        System.Threading.Tasks.Task editAsync(int id, ContactClassLibrary.Contact contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/delete", ReplyAction="http://tempuri.org/IService1/deleteResponse")]
        void delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/delete", ReplyAction="http://tempuri.org/IService1/deleteResponse")]
        System.Threading.Tasks.Task deleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createContact", ReplyAction="http://tempuri.org/IService1/createContactResponse")]
        void createContact(ContactClassLibrary.Contact contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createContact", ReplyAction="http://tempuri.org/IService1/createContactResponse")]
        System.Threading.Tasks.Task createContactAsync(ContactClassLibrary.Contact contact);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WcfWebClient.CrudService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WcfWebClient.CrudService.IService1>, WcfWebClient.CrudService.IService1 {
        
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
        
        public ContactClassLibrary.Contact[] getContacts() {
            return base.Channel.getContacts();
        }
        
        public System.Threading.Tasks.Task<ContactClassLibrary.Contact[]> getContactsAsync() {
            return base.Channel.getContactsAsync();
        }
        
        public ContactClassLibrary.Contact Details(int id) {
            return base.Channel.Details(id);
        }
        
        public System.Threading.Tasks.Task<ContactClassLibrary.Contact> DetailsAsync(int id) {
            return base.Channel.DetailsAsync(id);
        }
        
        public void edit(int id, ContactClassLibrary.Contact contact) {
            base.Channel.edit(id, contact);
        }
        
        public System.Threading.Tasks.Task editAsync(int id, ContactClassLibrary.Contact contact) {
            return base.Channel.editAsync(id, contact);
        }
        
        public void delete(int id) {
            base.Channel.delete(id);
        }
        
        public System.Threading.Tasks.Task deleteAsync(int id) {
            return base.Channel.deleteAsync(id);
        }
        
        public void createContact(ContactClassLibrary.Contact contact) {
            base.Channel.createContact(contact);
        }
        
        public System.Threading.Tasks.Task createContactAsync(ContactClassLibrary.Contact contact) {
            return base.Channel.createContactAsync(contact);
        }
    }
}
