namespace AmdarisEshop.Presentation.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Middleware2
    {
        private readonly RequestDelegate _next;
       
        private readonly ILogger<Middleware2> _logger;

        public Middleware2(RequestDelegate next, ILogger<Middleware2> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            //logfic on the request
            _logger.LogInformation("log in 2");

            await _next.Invoke(httpContext);

            ////logic on the response
            _logger.LogInformation("log out 2");

        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareExtensions2
    {
        public static IApplicationBuilder UseMyMiddleware2(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Middleware2>();
        }
    }
}
