namespace AmdarisEshop.Presentation.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Middleware
    {
        private readonly RequestDelegate _next;
       
        private readonly ILogger<Middleware> _logger;

        public Middleware(RequestDelegate next, ILogger<Middleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            //logfic on the request
            _logger.LogInformation("log in 1");

            await _next.Invoke(httpContext);

            ////logic on the response
            _logger.LogInformation("log out 1");

        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Middleware>();
        }
    }
}
