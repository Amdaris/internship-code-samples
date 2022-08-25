using AmdarisEshop.Application;
using AmdarisEshop.Application.Abstract;
using AmdarisEshop.Application.Commands;
using AmdarisEshop.Infrastructure;
using AmdarisEshop.Infrastructure.Repository;
using AmdarisEshop.Presentation;
using AmdarisEshop.Presentation.Middleware;
using AmdarisEshop.Presentation.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ISingletonService, SingletonService>();
builder.Services.AddScoped<IScopedService, ScopedService>();
builder.Services.AddTransient<ITransientService, TransientService>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryReporitory, CategoryRepository>();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddMediatR(typeof(CreateProduct));
builder.Services.AddAutoMapper(typeof(AssemblyMarketPresentatio));

builder.Services.Configure<MySettingsSection>(
    builder.Configuration.GetSection(
        nameof(MySettingsSection)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseMyMiddleware();
app.UseMyMiddleware2();

app.MapControllers();

app.Run();
