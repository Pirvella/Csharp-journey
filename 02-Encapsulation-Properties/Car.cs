using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02_Encapsulation_Properties
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        private int  year;



        public int Year
        {
             get
             {
                return year;
             }

            set
            {
                if (value>=2000)
                {
                    year = value;
                }
                else
                {
                    Console.WriteLine("Year must be greater than or equal to 2000.");
                }
            }
             


        }

        private int speed;

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value >= 0&& value <= 300)
                {
                    speed = value;
                }
                else
                {
                    Console.WriteLine("Speed cannot be negative or more 300.");
                }
            }
        }

        public void Start()
        
        {
            Console.WriteLine ("The car is starting.");
        }

        public void Drive()

        {
            Console.WriteLine("The car is driving");

        }

        public void ShowInfo()
        
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Speed: {Speed}");

        }


        // Encapsulation can also be implemented by restricting direct access to the property
        // and controlling its value through a public method with validation.
        //public void SetYear(int year)
        //{
        //    if (year >= 2000)
        //    {
        //        Year = year;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Year must be greater than or equal to 2000.");
        //    }
        //}


    }
}
