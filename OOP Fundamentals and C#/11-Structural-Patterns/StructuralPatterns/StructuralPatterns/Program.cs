using StructuralPatterns.Decorator;
using StructuralPatterns.Facade;
using System;

namespace StructuralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ICoffee coffee = new SimpleCoffee();
            coffee = new WithSugar(coffee);
            coffee = new WithMilk(coffee);

            ICoffee coffee2 = new SimpleCoffee();
            coffee2 = new WithSugar(coffee2);
            coffee2 = new WithCream(coffee2);

            Console.WriteLine($"Coffee1: {coffee.GetDescription()} for the price of {coffee.GetCost()}$");
            Console.WriteLine($"Coffee2: {coffee2.GetDescription()} for the price of {coffee2.GetCost()}$");

            Console.ReadKey();


            var paymentHelper = new CardPaymentFacade();
            paymentHelper.PayWithVisaOrMastercard(new Card { Type = "Visa" }, 200);

            Console.ReadKey();

            var youtubeHelper = new YouTubeProviderProxy();
            youtubeHelper.ListVideos();
            youtubeHelper.DownloadVideo();

            Console.ReadKey();


        }
    }
}
