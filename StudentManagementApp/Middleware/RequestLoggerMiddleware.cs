namespace StudentManagementApp.Middleware
{
    public class RequestLoggerMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine($"REQUEST: {context.Request.Method} {context.Request.Path}");

            await _next(context);

            Console.WriteLine($"RESPONSE Status: {context.Response.StatusCode}");
        }
    }
}