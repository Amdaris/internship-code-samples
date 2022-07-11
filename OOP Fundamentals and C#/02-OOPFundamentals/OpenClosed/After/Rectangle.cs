namespace After;

public class Rectangle : Shape
{
    public int Height { get; internal set; }
    public int Width { get; internal set; }

    public override double Area()
    {
        return Width * Height;
    }
}