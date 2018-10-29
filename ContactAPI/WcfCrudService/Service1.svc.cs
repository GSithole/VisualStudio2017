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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void createContact(ContactClassLibrary.Contact contact)
        {
            ContactLayer db = new ContactLayer();
            db.saveContact(contact);
        }

        public void delete(int id)
        {
            ContactLayer db = new ContactLayer();
            db.DeleteContact(id);
        }

        public ContactClassLibrary.Contact Details(int id)
        {
            ContactLayer db = new ContactLayer();
            return db.GetContacts.Single(x => x.ID == id);
           
        }

        public void edit(int id, ContactClassLibrary.Contact contact)
        {
            ContactLayer entities = new ContactLayer();
            var ent = entities.GetContacts.FirstOrDefault(m => m.ID == id);
            ent.firstName = contact.firstName;
            ent.lastName = contact.lastName;
            ent.gender = contact.gender;
            ent.phoneNumber = contact.phoneNumber;
            ent.emailAddress = contact.emailAddress;
            ent.city = contact.city;
            entities.EditContact(id, contact);
        }

        public IEnumerable<ContactClassLibrary.Contact> getContacts()
        {
            ContactLayer db = new ContactLayer();
            return db.GetContacts.ToList();
        }
    }


}
