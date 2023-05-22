using Factory.AbstractFactory;
using Factory.FactoryMethod;
using Factory.SimpleFactory;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////
            //Simple Factory
            //Factory is an object used to create other objects
            //hides creation logic
            //not exposing instantiation logic
            /////////////////
            string[] planetNames = new string[3] { "Mars", "Venus", "Mars" };

            IPlanet planet = PlanetFactory.GetPlanet("Mercury");
            Console.WriteLine($"{planet.Name} is {planet.GetDistanceToEarth()} km far away from Earth");

            foreach (string name in planetNames)
            {
                planet = PlanetFactory.GetPlanet(name);
                Console.WriteLine($"{planet.Name} is {planet.GetDistanceToEarth()} km far away from Earth");
            }
            Console.ReadLine();



            /////////////////
            //Factory Method
            //abstracts  creator from caller | adds one more level of abstraction to factory
            //defines many factories that return specific class
            //lets the subclasses decide wich class will instantiate
            /////////////////

            TransportCreator shipFactory = new ShipCreator();
            TransportCreator truckFactory = new TruckCreator();
            TransportCreator transporterFactory = new VehicleCreator();

            truckFactory.DispatchTransport(10);
            shipFactory.DispatchTransport(30);
            transporterFactory.DispatchTransport(100);
            truckFactory.DispatchTransport(100);

            Console.ReadLine();


            /////////////////
            //Abstract Factory
            //Factory of Factories
            //Provide an interface for creating families of related or dependant objects w/o specifieing their concrete class
            /////////////////

            AnimalFactory animalFactory = AnimalFactory.GetAnimalFactory("Pet");
            IAnimal animal = animalFactory.GetAnimal("Dog");

            Console.WriteLine($"{animal.Name} makes sound: {animal.MakeSound()}");
            Console.ReadLine();
        }
    }
}
