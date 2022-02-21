namespace FactoryPattern;

public class DieselCarFactory : ICarFactory
{
    public ICar CreateCar()
    {
        return new Car { Engine = CarEngineType.Diesel };
    }
}
