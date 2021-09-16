using System;

namespace SMSTextMessenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var messenger = new Messenger();

            messenger.SendMessage();

            Console.ReadLine();


        }
    }
}
