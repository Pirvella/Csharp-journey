namespace _02_Encapsulation_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Brand = "Toyota";
            car1.Model = "Camry";
            car1.Year = 2020;
            car1.Speed = 20;
            car1.Start();
            car1.Drive();
                 //car1.SetYear(2020);
            car1.ShowInfo();
        }
    }
}
