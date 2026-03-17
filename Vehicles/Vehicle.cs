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
        //public int Speed { get; set; }

        //This is a composite property
        public Engine EngineType{ get; set; }

        //Create Constructor
        public Vehicle(string make, string model, Engine engine)
        {
            Make = make;
            Model = model;
            //Speed = speed;
            EngineType = engine; //Assign the Engine object here 
        }

        //Method to start the engine
        public void StartEngine()
        {
            EngineType.Start(); // This should delegate to the Engine class start()
        }
    }
        
}
