namespace _04_Inheritance_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Brand = "Toyota";
            car1.Model = "Camry";
            car1.NumberOfDoors = 4;
            car1.Drive();
            car1.start();
            car1.ShowInfo();
            Console.WriteLine($"Number of doors: {car1.NumberOfDoors}");



        }
    }
}
