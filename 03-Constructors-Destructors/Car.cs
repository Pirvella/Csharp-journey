using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Constructors_Destructors
{
    internal class Car
    {
       public string Brand { get; set; }
       public string Model { get; set; }
       public int Year { get; set; }

        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;

            
        }

        ~Car()
        {
            Console.WriteLine("The car object is being destroyed.");
        }

        public void Start()
        {
            Console.WriteLine("The car is starting.");
        }
        public void Drive()
        {
            Console.WriteLine("The car is driving.");

        }

        public void ShowInfo()
        {
            Console.WriteLine($"Brand:{Brand}");
            Console.WriteLine($"Model:{Model}");
            Console.WriteLine($"Year:{Year}");
        }
    }
}
