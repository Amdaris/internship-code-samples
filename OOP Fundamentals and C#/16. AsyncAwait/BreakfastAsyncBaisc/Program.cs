using System.Diagnostics;


Console.WriteLine("Let's cook breakfast!");

var sw = new Stopwatch();
sw.Start();

AddCoffeeIngredients();
var coffee = MakeCoffeeAsync();
await HeatPanAsync();
var eggs = await FryEggsAsync();
var bacon = await FryBaconAsync();
var toast = await MakeToastAsync();
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

static async Task<Coffee> MakeCoffeeAsync()
{
    Console.WriteLine("Starting coffee making machine....");
    await Task.Delay(1000);
    Console.WriteLine("Coffee is ready");
    return new Coffee();
}

static async Task HeatPanAsync()
{
    Console.WriteLine("Heating the pan");
    await Task.Delay(1000);
    Console.WriteLine("The pan is hot");
}

static async Task<Eggs> FryEggsAsync()
{
    Console.WriteLine("Frying two eggs...");
    await Task.Delay(5000);
    Console.WriteLine("Eggs are ready");
    return new Eggs();
}

static async Task<Bacon> FryBaconAsync()
{
    Console.WriteLine("Frying two slices of bacon");
    await Task.Delay(8000);
    Console.WriteLine("Bacon is ready");
    return new Bacon();
}

static async Task<Toast> MakeToastAsync()
{
    Console.WriteLine("Toasting the bread...");
    await Task.Delay(2000);
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