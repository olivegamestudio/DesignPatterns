namespace PrototypePattern;

public class DieselCar : Car
{
    DieselCar(CarEngineType engine, int numSeats) : base(engine, numSeats)
    {
    }

    public DieselCar(int numSeats) : base(CarEngineType.Diesel, numSeats)
    {
    }

    public Car Clone()
    {
        return new DieselCar(Engine, NumSeats);
    }
}
