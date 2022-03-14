using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Car
{
    class Vehicle
    {
        public string Color { get; set; }
        public string Year { get; set; }

        public Vehicle(string Year)
        {
            this.Year = Year;
            
        }
       

    }
}
