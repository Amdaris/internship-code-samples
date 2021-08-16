using Application;
using Application.Queries.GetProductsQuery;
using Domain;
using Infrastructure;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ConsolePresentation
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var diContainer = new ServiceCollection()
                .AddMediatR(typeof(IProductRepository))
                .AddTransient<IProductRepository, InMemoryProductRepository>()
                .BuildServiceProvider();

            var mediator = diContainer.GetService<IMediator>();

            var products = await mediator.Send(new GetProductsQuery());

            foreach(var p in products)
            {
                Console.WriteLine($"{p.Id} - {p.Name}");
            }

            //IProductRepository productRepository = new InMemoryProductRepository();
            //var products = productRepository.GetProducts();

            //foreach (var p in products)
            //{
            //    Console.WriteLine($"I'm seeing a '{p.Name}'");
            //}

            //var productToOrder = products.FirstOrDefault(p => p.Name == "Laptop");

            //var order = new Order { Id = 10 };

            //IOrderRepository orderRepository = new InMemoryOrderRepository();
            //orderRepository.CreateOrder(order);

            //Console.WriteLine("Looking at order:");
            //Console.WriteLine(order);

            //var orderItem = new OrderItem { Id = 1, Product = productToOrder, Quantity = 5 };

            //orderRepository.AddItemToOrder(10, orderItem);
            //order = orderRepository.GetOrder(10);
            //Console.WriteLine(order);

            //orderItem.Quantity = 3;

            //orderRepository.Update(10, orderItem);
            //order = orderRepository.GetOrder(10);
            //Console.WriteLine(order);

            //orderRepository.DeleteOrderItem(10, 1);
            //order = orderRepository.GetOrder(10);

            //Console.WriteLine("Final status:");
            //Console.WriteLine(order);
        }
    }
}
