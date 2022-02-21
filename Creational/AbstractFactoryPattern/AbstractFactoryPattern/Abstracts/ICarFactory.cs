namespace AbstractFactoryPattern;

/// <summary>
/// This abstract factory interface defines the distinct types/products
/// and leaves it to the concrete factory to implement these.
/// </summary>
public interface ICarFactory
{
    IPetrolCar CreatePetrolCar();

    IDieselCar CreateDieselCar();
}
