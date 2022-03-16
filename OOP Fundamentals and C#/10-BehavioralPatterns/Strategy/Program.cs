// See https://aka.ms/new-console-template for more information

using Strategy;

Console.WriteLine("Please select route preference! 1 -> Car; 2 -> Bike; 3 -> Walk");
var selection = int.Parse(Console.ReadLine());

var context = new RouteBuilderContext();

if (selection == 1)
{
    context.SeStrategy(new CarRouteBuilderStrategy());
    context.BuildRoute();
}

if (selection == 2)
{
    context.SeStrategy(new CyclingRouteBuilderStrategy());
    context.BuildRoute();
}

if (selection == 3)
{
    context.SeStrategy(new WalkRouteBuilderStrategy());
    context.BuildRoute();
}

if (selection > 3 || selection < 1)
{
    context.SeStrategy(new CarRouteBuilderStrategy());
    context.BuildRoute();
}