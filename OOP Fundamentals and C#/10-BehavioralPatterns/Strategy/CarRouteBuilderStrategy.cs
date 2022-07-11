namespace Strategy;

public class CarRouteBuilderStrategy : IRouteBuilderStrategy
{
    public void BuildRoute()
    {
        var route = "Distance: 5km; Time: 24 min; Transport: Car";
        Console.WriteLine(route);
    }
}