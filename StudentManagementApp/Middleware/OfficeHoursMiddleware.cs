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
            bool isOfficeHours = currentHour >= 9 && currentHour < 18;

            if (!isOfficeHours)
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync(
                    $"Access Denied. Student Management is only available between 9 AM and 6 PM. Current time: {DateTime.Now:hh:mm tt}");
                return;
            }

            await _next(context);
        }
    }
}