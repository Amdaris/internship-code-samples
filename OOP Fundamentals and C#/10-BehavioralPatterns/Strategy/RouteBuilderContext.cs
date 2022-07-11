namespace Strategy;

public class RouteBuilderContext
{
    private IRouteBuilderStrategy _strategy;

    public void SeStrategy(IRouteBuilderStrategy strategy)
    {
        _strategy = strategy;
    }

    public void BuildRoute()
    {
        if (_strategy == null) Console.WriteLine("No strategy selected");
        else _strategy.BuildRoute();
    }
}