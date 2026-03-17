using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        //Create Constructor
        public Vehicle(string MAKE, string model, int speed)
        {
            Make = make;
            Model = model;
            Speed = speed;
        }
    }
}
