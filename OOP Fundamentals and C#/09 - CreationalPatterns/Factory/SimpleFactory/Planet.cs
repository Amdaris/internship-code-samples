
namespace Factory.SimpleFactory
{
    internal interface IPlanet
    {
        string Name { get; set; }
        double Radius { get; set; }
        double Mass { get; set; }

        double GetDistanceToEarth(); 
    }
}
