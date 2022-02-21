// See https://aka.ms/new-console-template for more information

using PrototypePattern;

var car = new DieselCar(5);
var clonedCar = car.Clone();

Console.WriteLine($"Original Car: {car.Engine} engine with {car.NumSeats} seats.");
Console.WriteLine($"Cloned Car: {clonedCar.Engine} engine with {clonedCar.NumSeats} seats.");
