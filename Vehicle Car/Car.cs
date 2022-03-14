using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Car
{
    class Car: Vehicle
    {
        //        Brand
        //- Model
        //- FuelCapacity
        //- FuelFor1Km
        //- CurrentFuel
        //- ShowInfo()

        public string Brand { get; set; }
        public string Model { get; set; }
        public double FuelCapacity { get; set; }
        public double FuelFor1Km { get; set; }
        public double CurrentFuel { get; set; }

        public Car(string Model, string Brand,double FuelFor1Km, double FuelCapacity):base("")
        {
            this.Model = Model;
            this.Brand = Brand;
            this.FuelFor1Km = FuelFor1Km;
            this.FuelCapacity = FuelCapacity;
        }

        public Car(string Model, string Brand, double FuelFor1Km, double FuelCapacity,double CurrentFuel) :this(Model,Brand,FuelFor1Km,FuelCapacity)
        {
            this.CurrentFuel = CurrentFuel;
        }

        
        public string ShowInfo()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"Model -> {Model}\n");
            builder.Append($"Brand -> {Brand}\n");
            builder.Append($"FuelFor1Km -> {FuelFor1Km}\n");
            builder.Append($"FuelCapacity -> {FuelCapacity}\n");
            builder.Append($"CurrentFuel -> {CurrentFuel}\n\n");
            return builder.ToString();
        }
        public void Drive(int km)
        {
            if ((FuelCapacity/FuelFor1Km)>=km)
            {
                if ((CurrentFuel/FuelFor1Km)>=km)
                {
                    Console.WriteLine($"{CurrentFuel - km * FuelFor1Km} {"litr yanacaq qalacaq."}");
                }
                else
                {
                    Console.WriteLine($"{km * FuelFor1Km -CurrentFuel} {"litr yanacaq lazimdir"}");
                }
            }
            else
            {
                Console.WriteLine("Avtomobilin yanacaq hecmi yeterli deyil.");
            }
        }

       
    }
}
