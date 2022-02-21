using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// The concrete factory class creates the distinct products.
    /// </summary>
    public class CarFactory : ICarFactory
    {
        public IPetrolCar CreatePetrolCar()
        {
            return new PetrolCar();
        }

        public IDieselCar CreateDieselCar()
        {
            return new DieselCar();
        }
    }
}
