namespace StructuralPatterns.Decorator
{
    public class SimpleCoffee : ICoffee
    {
        public decimal GetCost()
        {
            return 10;
        }

        public string GetDescription()
        {
            return "Simple coffee";
        }
    }
}
