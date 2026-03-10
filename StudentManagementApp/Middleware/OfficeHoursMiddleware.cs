namespace StudentManagementApp.Middleware
{
    public class OfficeHoursMiddleware
    {
        private readonly RequestDelegate _next;

        public OfficeHoursMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var currentHour = DateTime.Now.Hour;
            bool isOfficeHours = currentHour >= 8 && currentHour < 16;

            if (!isOfficeHours)
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync(
                    $"Access Denied. Student Management is only available between 8 AM and 4 PM. Current time: {DateTime.Now:hh:mm tt}");
                return;
            }

            await _next(context);
        }
    }
}