using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSTextMessenger.SMSTextMessenger.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public Group Group { get; set; }
    }
}