// See https://aka.ms/new-console-template for more information

using AbstractFactoryPattern;

Console.WriteLine("Hello, World!");

var dieselCar = new DieselCar();
dieselCar.AddDiesel(5);

var petrolCar = new PetrolCar();
petrolCar.AddPetrol(7);
