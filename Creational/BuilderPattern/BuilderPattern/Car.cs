namespace BuilderPattern;

public class Car : ICar
{
    public int NumSeats { get; set; }

    public CarEngineType Engine { get; set; }
}
