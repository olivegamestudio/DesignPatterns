namespace AbstractFactoryPattern;

public class PetrolCar : IPetrolCar
{
    public void AddPetrol(float litres)
    {
        Console.WriteLine($"You added {litres} of petrol to the car.");
    }
}
