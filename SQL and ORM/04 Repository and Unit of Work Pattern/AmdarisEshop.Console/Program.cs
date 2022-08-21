// See https://aka.ms/new-console-template for more information
using AmdarisEshop.Application;
using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Application.Commands;
using AmdarisEshop.Application.Queries;
using AmdarisEshop.Domain.Models;
using AmdarisEshop.Infrastructure;
using AmdarisEshop.Infrastructure.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace ConsolePresentation
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var mediator = Init();
            
            Console.WriteLine("Hello!");

            while (true)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1 Add product");
                Console.WriteLine("2 Get product by id");
                Console.WriteLine("3 Add category");
                Console.WriteLine("4 Get category");
                Console.WriteLine("5 Delete category");

                var action = Convert.ToInt32(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        var addedProduct = await AddProduct(mediator);
                        DisplayItem<Product>(addedProduct);
                        break;
                    case 2:
                        var product = await GetProductById(mediator);
                        DisplayItem<Product>(product);
                        break;
                    case 3:
                        var addedCategory = await AddCategory(mediator);
                        DisplayItem<Category>(addedCategory);
                        break;
                    case 4:
                        var category = await GetCategoryById(mediator);
                        DisplayItem<Category>(category);
                        break;
                    case 5:
                        var deletedCategory = await DeleteCategory(mediator);
                        DisplayItem<Category>(deletedCategory);
                        break;
                    default:
                        Console.WriteLine($"Invalid action: {action}");
                        break;
                }
            }
        }

        private static void DisplayItem<T>(T item)
        {
            var serializedProduct = JsonConvert.SerializeObject(item, new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented,
            });

            Console.WriteLine(serializedProduct);
            Console.WriteLine();

        }

        private static IMediator Init()
        {
            var diContainer = new ServiceCollection()
                .AddDbContext<DataContext>(options =>
                        options.UseSqlServer(@"Server=localhost;Database=AmdarisEshop;Trusted_Connection=True;"))
                .AddMediatR(typeof(AssemblyMarker))
                .AddScoped<IUnitOfWork, UnitOfWork>()
                .AddScoped<IProductRepository, ProductRepository>()
                .AddScoped<ICategoryRepository, CategoryRepository>()
                .BuildServiceProvider();

            return diContainer.GetRequiredService<IMediator>();
        }

        static async Task<Category> DeleteCategory(IMediator mediator)
        {
            var command = new DeleteCategory(); 
            Console.WriteLine($"Insert {nameof(command.CategoryId)}");
            command.CategoryId = Convert.ToInt32(Console.ReadLine());    

            return await mediator.Send(command);
        }

        static async Task<Category> GetCategoryById(IMediator mediator)
        {
            var getCategoryQuery = new GetCategoryById();
            Console.WriteLine($"Insert {nameof(getCategoryQuery.CategoryId)}");
            getCategoryQuery.CategoryId = Convert.ToInt32(Console.ReadLine());

            return await mediator.Send(getCategoryQuery);
        }

        static async Task<Category> AddCategory(IMediator mediator)
        {
            var addCategoryCommand = new CreateCategory();

            Console.WriteLine($"Insert {nameof(addCategoryCommand.CategoryName)}:");
            addCategoryCommand.CategoryName = Console.ReadLine();

            Console.WriteLine($"Insert {nameof(addCategoryCommand.CategoryDescription)}:");
            addCategoryCommand.CategoryDescription = Console.ReadLine();
           
            return await mediator.Send(addCategoryCommand);
        }

        static async Task<Product> GetProductById(IMediator mediator)
        {
            var getProductCommand = new GetProductById();

            Console.WriteLine($"Insert {nameof(getProductCommand.ProductId)}");
            getProductCommand.ProductId = Convert.ToInt32(Console.ReadLine());

            return await mediator.Send(getProductCommand);
        }

        static async Task<Product> AddProduct(IMediator mediator)
        {
            var addProductCommand = new CreateProduct();

            Console.WriteLine($"Insert {nameof(addProductCommand.ProductName)}:");
            addProductCommand.ProductName = Console.ReadLine();

            Console.WriteLine($"Insert {nameof(addProductCommand.Price)}:");
            addProductCommand.Price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Insert {nameof(addProductCommand.ProdcutDescription)}:");
            addProductCommand.ProdcutDescription = Console.ReadLine();

            Console.WriteLine($"Insert {nameof(addProductCommand.AvailableQuantity)}:");
            addProductCommand.AvailableQuantity = Convert.ToInt32(Console.ReadLine());

            return await mediator.Send(addProductCommand);
        }
    }
}