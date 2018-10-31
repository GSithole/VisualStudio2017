using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ContactClassLibrary;

namespace WcfCrudService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1 
    {
        
        [OperationContract]
        IEnumerable<ContactClassLibrary.Contact> getContacts();
        [OperationContract]
        ContactClassLibrary.Contact Details(int id);
        [OperationContract]
        void edit(int id, ContactClassLibrary.Contact contact);
        [OperationContract]
        void delete(int id);
        [OperationContract]
        void createContact(ContactClassLibrary.Contact contact);
    }
    
}
