// See https://aka.ms/new-console-template for more information

using FactoryPattern;

var dieselFactory = new DieselCarFactory();
var dieselCar = dieselFactory.CreateCar();
Console.WriteLine("Car has " + dieselCar.Engine + " engine.");

var petrolFactory = new PetrolCarFactory();
var petrolCar = petrolFactory.CreateCar();
Console.WriteLine("Car has " + petrolCar.Engine + " engine.");
