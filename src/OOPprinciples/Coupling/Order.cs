using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.OOPprinciples.Coupling
{
    public class Order
    {
        public void PlaceOrder(){
            //place order logic

            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail("Order placed successfully");
        }
    }
}