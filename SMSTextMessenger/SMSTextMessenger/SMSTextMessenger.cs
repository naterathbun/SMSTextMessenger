using SMSTextMessenger.SMSTextMessenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSTextMessenger.SMSTextMessenger
{
    public class SMSTextMessenger
    {
        public PhoneBook PhoneBook { get; set; }
        public Messages Messages { get; set; }

        public SMSTextMessenger()
        {
            // create new Messages
            // read text file for messages, add to Messages
            // create new PhoneBook
            // read text file for contacts, add to PhoneBook
        }



        // Contact Management
        private void AddContact(Contact contact)
        {
            PhoneBook.AddContact(contact);
        }

        private void DeleteContact(Contact contact)
        {
            PhoneBook.DeleteContact(contact);
        }

        // Message Management
        private void AddMessage()
        {
            // add message to Messages
            SaveMessages();
        }

        private void DeleteMessage()
        {
            // delete message from Messages
            SaveMessages();
        }

        private void SaveMessages()
        {
            // update the text file
        }


        // Twilio
        private void SendMessage(string messageName)
        {
            
        }
    }
}