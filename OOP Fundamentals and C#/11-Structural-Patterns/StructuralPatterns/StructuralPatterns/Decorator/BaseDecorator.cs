namespace StructuralPatterns.Decorator
{
    public abstract class BaseCoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;

        public BaseCoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public abstract decimal GetCost();

        public abstract string GetDescription();
    }
}
