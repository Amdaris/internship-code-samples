namespace Factory.AbstractFactory
{
    public class WildAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string animalType)
        {
            if (animalType.Equals("Lion"))
            {
                return new Lion();
            }
            else
                return null;
        }
    }
}