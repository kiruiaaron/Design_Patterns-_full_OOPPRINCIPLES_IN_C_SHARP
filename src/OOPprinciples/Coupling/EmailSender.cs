using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.OOPprinciples.Coupling
{
    public class EmailSender
    {
        public void SendEmail(string message)
        {
            //Email sending logic
            Console.WriteLine("Sending email " + message);
        }
    }
}