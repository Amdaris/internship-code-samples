namespace StructuralPatterns.Decorator
{
    public class WithCream : BaseCoffeeDecorator
    {
        public WithCream(ICoffee coffee) : base(coffee)
        {
        }

        public override decimal GetCost()
        {
            return _coffee.GetCost() + 2;
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + " with cream";
        }
    }
}
