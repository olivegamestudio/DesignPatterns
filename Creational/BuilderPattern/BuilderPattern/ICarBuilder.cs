namespace BuilderPattern;

public interface ICarBuilder
{
    ICarBuilder SetSeats(int numSeats);

    ICarBuilder SetEngineType(CarEngineType engine);

    ICar CreateCar();
}
