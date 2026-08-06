namespace _03_Constructors_Destructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Tesla", "Model S", 2022);
            car1.Start();
            car1.Drive();
            car1.ShowInfo();

            Car car2 = new Car("Lamborghini", "Urus", 2021);
            car2.Start();
            car2.Drive();
            car2.ShowInfo();

            //car1 = null;
            

        }

    }
}
