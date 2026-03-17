using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Engine
    {
       public bool Running { get; set; }
        public int HorsePower { get; set; }
        public FuelType FuelType { get; set; }

        public Engine(int horsePower, FuelType fuelType)
        {
            HorsePower = horsePower;
            FuelType = fuelType;
            Running = false;
        }
    }
}
