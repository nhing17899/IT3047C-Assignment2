using Microsoft.AspNetCore.Http.Extensions;

namespace Assignment2_EFBasics.Middleware
{
    public class CurrentPathMiddleware
    {
        RequestDelegate next;
        public CurrentPathMiddleware(RequestDelegate Next) 
        {
            next = Next;
        }

        public async Task InvokeAsync(HttpContext context) 
        {
            var path = context.Request.Path.Value;

            Console.WriteLine(path);

            await next(context);
        }
    }
}
