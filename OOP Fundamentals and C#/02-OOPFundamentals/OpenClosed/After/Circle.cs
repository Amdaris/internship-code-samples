namespace After;

public class Circle : Shape
{
    public int Radius { get; internal set; }

    public override double Area()
    {
        return Radius * Radius * Math.PI;
    }
}