using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ContactClassLibrary;

namespace ContactAPI.Controllers
{
    public class ContactsController : ApiController
    {
        // GET: api/Contacts
        public IEnumerable<Contact> Get()
        {
            ContactLayer entities = new ContactLayer();
            
                return entities.GetContacts.ToList();
            
        }

        // GET: api/Contacts/5
        public Contact Get(int id)
        {
            ContactLayer entities = new ContactLayer();

            return entities.GetContacts.FirstOrDefault(m => m.ID == id);
        }

        // POST: api/Contacts
        public void Post([FromBody]Contact contact)
        {
            ContactLayer entities = new ContactLayer();
            entities.saveContact(contact);
        }

        // PUT: api/Contacts/5
        public void Put(int id, [FromBody] Contact contact)
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

        // DELETE: api/Contacts/5
        public void Delete(int id)
        {
            ContactLayer entities = new ContactLayer();
            entities.DeleteContact(id);
        }
    }
}
