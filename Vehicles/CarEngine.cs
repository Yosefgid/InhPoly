using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class CarEngine: Engine
    {
        public CarEngine()
            :base(200, FuelType.Unleaded)
        {

        }
    }
}
