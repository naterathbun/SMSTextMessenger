using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSTextMessenger.SMSTextMessenger.Models
{
    public class PhoneBook
    {
        public List<Contact> Contacts { get; set; }


        public List<Contact> GetContacts()
        {
            return Contacts;
        }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        public void DeleteContact(Contact contact)
        {            
            Contacts.Remove(contact);
        }
    }
}