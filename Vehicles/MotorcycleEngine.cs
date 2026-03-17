using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class MotorcycleEngine : Engine
    {
       public MotorcycleEngine()
            :base(90, FuelType.Diesel)
        {

        }
    }
}
