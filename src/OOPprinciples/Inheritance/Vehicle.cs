using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.OOPprinciples.Inheritance
{
    public class Vehicle
    {
        public string Brand {get; set;}
        public string Model {get; set;}

        public int Year {get; set;}

        public void Start(){
            Console.WriteLine("Vehicle is starting.");
        }

        public void Stop(){
            Console.WriteLine("Vehicle is stopping");
        }
    }
}