namespace FactoryPattern
{
    public class PetrolCarFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new Car { Engine = CarEngineType.Petrol };
        }
    }
}
