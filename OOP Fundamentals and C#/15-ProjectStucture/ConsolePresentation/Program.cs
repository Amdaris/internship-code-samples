using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application;
using Application.Orders.Commands.CreateOrder;
using Application.Orders.Queries.GetOrdersList;
using Application.Products.Commands.CreateProduct;
using Application.Products.Queries.GetProductsList;
using Infrastructure;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ConsolePresentation
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var diContainer = new ServiceCollection()
                .AddMediatR(typeof(IProductRepository))
                .AddScoped<IOrderRepository, InMemoryOrderRepository>()
                .AddScoped<IProductRepository, InMemoryProductRepository>()
                .BuildServiceProvider();

            var mediator = diContainer.GetRequiredService<IMediator>();

            var orderId = await mediator.Send(new CreateOrderCommand
            {
                BuyerName = "TheBuyer",
                OrderItems = new List<OrderItemDto>
                {
                    new() { Quantity = 1, Price = 5, ProductName = "Telefon" },
                    new() { Quantity = 2, Price = 7, ProductName = "TV" }
                }
            });

            Console.WriteLine($"Order created with {orderId}");


            var orders = await mediator.Send(new GetOrdersListQuery());

            var productId = await mediator.Send(new CreateProductCommand { Name = "test", Price = 10 });
            var products = await mediator.Send(new GetProductsListQuery());

        }
    }
}