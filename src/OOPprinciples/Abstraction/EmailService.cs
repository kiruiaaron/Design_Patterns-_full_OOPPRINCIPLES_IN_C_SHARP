using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.OOPprinciples.Abstraction
{
    public class EmailService
    {
        public void SendEmail(){
            Connect();
            Authenticate();
            System.Console.WriteLine("Sending email ..");
            Disconnect();

        }

        public void Connect(){
            System.Console.WriteLine("Connecting to email server...");

        }

        public void Authenticate(){
            System.Console.WriteLine("Authenticating...");
        }

        public void Disconnect(){
            System.Console.WriteLine("Disconnecting from email server...");
        }
    }
}