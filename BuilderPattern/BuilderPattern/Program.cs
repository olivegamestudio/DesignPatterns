// See https://aka.ms/new-console-template for more information

using BuilderPattern;

var car = new CarBuilder()
    .SetSeats(4)
    .SetEngineType(CarEngineType.Diesel)
    .CreateCar();

Console.WriteLine($"Car with {car.NumSeats} seats and a {car.Engine} engine.");
