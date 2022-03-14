using System;

namespace Vehicle_Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Mercedes","GLA",2,50);
            car.CurrentFuel = 9;
            car.Drive(15);
            Console.WriteLine(car.ShowInfo());

            Vehicle vehicle = new Vehicle("2000");
            vehicle.Color = "qara";
            Console.WriteLine( vehicle.Year);
        }
    }
}
