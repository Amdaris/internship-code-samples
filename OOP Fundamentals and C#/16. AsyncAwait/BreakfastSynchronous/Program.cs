using System.Diagnostics;


Console.WriteLine("Let's cook breakfast!");

var sw = new Stopwatch();
sw.Start();

AddCoffeeIngredients();
var coffee = MakeCoffee();
HeatPan();
var eggs = FryEggs();
var bacon = FryBacon();
var toast = MakeToast();
AddButterToToast(toast);
AddJamToToast(toast);

sw.Stop();
double seconds = sw.ElapsedMilliseconds / 1000;

Console.WriteLine("Breakfast is ready!");
Console.WriteLine($"it took you {seconds} seconds to cook breakfast");

static void AddCoffeeIngredients()
{
    Console.WriteLine("Adding ingredients to the coffee machine");
    Console.WriteLine("All ingredients added.");
}

static Coffee MakeCoffee()
{
    Console.WriteLine("Starting coffee making machine....");
    Task.Delay(1000).Wait();
    Console.WriteLine("Coffee is ready");
    return new Coffee();
}

static void HeatPan()
{
    Console.WriteLine("Heating the pan");
    Task.Delay(1000).Wait();
    Console.WriteLine("The pan is hot");
}

static Eggs FryEggs()
{
    Console.WriteLine("Frying two eggs...");
    Task.Delay(5000).Wait();
    Console.WriteLine("Eggs are ready");
    return new Eggs();
}

static Bacon FryBacon()
{
    Console.WriteLine("Frying two slices of bacon");
    Task.Delay(8000).Wait();
    Console.WriteLine("Bacon is ready");
    return new Bacon();
}

static Toast MakeToast()
{
    Console.WriteLine("Toasting the bread...");
    Task.Delay(2000).Wait();
    Console.WriteLine("Toast is ready");
    return new Toast();
}

static void AddButterToToast(Toast toast)
{
    Console.WriteLine("Adding butter to the toast...");
    Console.WriteLine("Butter added to the toast");
}

static void AddJamToToast(Toast toast)
{
    Console.WriteLine("Adding jam over the butter");
    Console.WriteLine("Jam added on the toast");
}

internal class Coffee {}
internal class Eggs {}
internal class Bacon {}
internal class Toast {}