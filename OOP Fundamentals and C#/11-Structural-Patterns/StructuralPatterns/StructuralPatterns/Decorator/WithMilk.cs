namespace StructuralPatterns.Decorator
{
    public class WithMilk : BaseCoffeeDecorator
    {
        public WithMilk(ICoffee coffee) : base(coffee)
        {
        }

        public override decimal GetCost()
        {
            return _coffee.GetCost() + 1;
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + " with milk";
        }
    }
}
