using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Inheritance_Basics
{
    internal class Car : Vehicle
    {
      
        public int NumberOfDoors { get; set; }
        public Car()
        {

        }

        public void Drive()
        {
            Console.WriteLine("The car is driving...");
        }


    }
}
