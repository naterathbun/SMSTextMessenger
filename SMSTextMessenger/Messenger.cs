using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using SMSTextMessenger.SMSTextMessenger.Models;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace SMSTextMessenger
{
    public class Messenger
    {
        public readonly string MYNUMBER;

        public PhoneBook PhoneBook { get; set; }
        public Messages Messages { get; set; }

        public Messenger()
        {
            var config = ConfigurationManager.AppSettings;
            MYNUMBER = config["mynumber"];
            
            TwilioClient.Init(config["accountsid"], config["authtoken"]);

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
        public void SendMessage()
        {            
            var message = MessageResource.Create(
                body: "nate test",
                from: new Twilio.Types.PhoneNumber(MYNUMBER),
                to: new Twilio.Types.PhoneNumber("+1")
            );
        }
    }
}