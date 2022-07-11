namespace Strategy;

public class CyclingRouteBuilderStrategy : IRouteBuilderStrategy
{
    public void BuildRoute()
    {
        var route = "Distance: 4 km; Time: 10 min; Transport: Bike";
        Console.WriteLine(route);
    }
}