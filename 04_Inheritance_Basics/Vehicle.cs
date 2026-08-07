using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Inheritance_Basics
{
    internal class Vehicle
    {

        public string Brand { get; set; }
        public string Model { get; set; }


        public Vehicle()
        {
            
        }


        public void start()
        {
            Console.WriteLine("Vehicle is starting...");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
        }

    }
}
