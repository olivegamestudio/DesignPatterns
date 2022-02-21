using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public abstract class Car : ICar
    {
        public CarEngineType Engine { get; set; }

        public int NumSeats { get; set; }

        protected Car(CarEngineType engine, int numSeats)
        {
            Engine = engine;
            NumSeats = numSeats;
        }
    }
}
