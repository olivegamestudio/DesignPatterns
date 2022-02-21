namespace PrototypePattern;

public class PetrolCar : Car
{
    PetrolCar(CarEngineType engine, int numSeats) : base(engine, numSeats)
    {
    }

    public PetrolCar(int numSeats) : base(CarEngineType.Petrol, numSeats)
    {
    }

    public Car Clone()
    {
        return new PetrolCar(Engine, NumSeats);
    }
}
