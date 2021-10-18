namespace ExtensionMethodsDemo.Extensions
{
    public static class ProductExtensions
    {
        public static float GetDiscountedPrice(this Product product, float percentage = .2f)
        {
            return product.Price - percentage * product.Price;
        }
    }
}
