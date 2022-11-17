using Factory.AbstractFactory;
using Factory.FactoryMethod;
using Factory.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

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

            ITransportFactory shipFactory = new ShipFactory();
            ITransportFactory truckFactory = new TruckFactory();
            
            ITransport ship = shipFactory.CreateTransport(1000, "ship name");
            ITransport truck = truckFactory.CreateTransport(10, "truck name");
            
            //ship.Deliver();
            //truck.Deliver();
            
            
            List<ITransport> transports = new List<ITransport> { ship, truck };
            
            foreach (var transport in transports)
            {
                transport.Deliver();
            }
            
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
