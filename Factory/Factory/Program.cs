using Factory.Entities.Classes;
using Factory.Entities.Interfaces;
using Factory.Factory.Classes;
using Factory.Factory.Interfaces;

ITransportFactory factory = new SedanFactory();

var sedan = factory.CreateTransport() as ISedan;

Console.WriteLine($"Name: {sedan.Name}");


factory = new TruckFactory();

var truck =  factory.CreateTransport() as ITruck;

Console.WriteLine($"Name: {truck.Name}");

factory =  new SUVFactory();

var suv = factory.CreateTransport() as ISUV;

Console.WriteLine($"Name: {suv.Name}");