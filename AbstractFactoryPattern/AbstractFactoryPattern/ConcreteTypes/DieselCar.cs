namespace AbstractFactoryPattern;

public class DieselCar : IDieselCar
{
    public void AddDiesel(float litres)
    {
        Console.WriteLine($"You added {litres} of diesel to the car.");
    }
}
