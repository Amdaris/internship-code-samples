namespace OOPFundamentals.OpenClose
{
    public class RectangleRefactored : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
    }
}