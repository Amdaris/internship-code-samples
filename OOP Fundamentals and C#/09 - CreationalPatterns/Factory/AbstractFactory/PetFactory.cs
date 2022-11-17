namespace Factory.AbstractFactory
{
    public class PetFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string animalType)
        {
            if (animalType.Equals("Dog"))
            {
                return new Dog();
            }
            else if (animalType.Equals("Cat"))
            {
                return new Cat();
            }
            else if (animalType.Equals("Lion"))
            {
                return new Lion();
            }
            else
                return null;
        }
    }
}