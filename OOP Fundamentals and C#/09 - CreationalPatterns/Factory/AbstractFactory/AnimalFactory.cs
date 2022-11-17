using System;
namespace Factory.AbstractFactory
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(string animalType);
        public static AnimalFactory GetAnimalFactory(string factoryType)
        {
            if (factoryType.Equals("Wild"))
                return new WildAnimalFactory();
            else
                return new PetFactory();
        }
    }
}
