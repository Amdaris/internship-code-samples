namespace StructuralPatterns.Decorator
{
    public class WithSugar : BaseCoffeeDecorator
    {
        public WithSugar(ICoffee coffee) : base(coffee)
        {
        }

        public override decimal GetCost()
        {
            return _coffee.GetCost() + 1;
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + " with sugar";
        }
    }
}
