using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classes
{
    internal class Car
    {

        public string Brand;
        public string Model;
        public int Year;

        public void Start()
        {
            Console.WriteLine("The car started");
        }
        public void Drive()
        {
            Console.WriteLine("The Car is driving");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} Model: {Model} Year: {Year}");
        }
    }
}

