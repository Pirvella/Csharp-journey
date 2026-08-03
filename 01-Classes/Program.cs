namespace _01_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Brand = "Toyota";
            car1.Model = "Camry";
            car1.Year = 2020;
            car1.Start();
            car1.Drive();
            car1.ShowInfo();

            Car car2 = new Car();
            car2.Brand = "Honda";
            car2.Model = "Civic";
            car2.Year = 2021;
            car2.Start();
            car2.Drive();
            car2.ShowInfo();

        }
    }
}
