namespace Strategy;

public class WalkRouteBuilderStrategy : IRouteBuilderStrategy
{
    public void BuildRoute()
    {
        var route = "Distance: 4km; Time: 35 min; Transport: Walk";
        Console.WriteLine(route);
    }
}