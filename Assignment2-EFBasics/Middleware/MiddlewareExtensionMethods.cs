namespace Assignment2_EFBasics.Middleware
{
    public static class MiddlewareExtensionMethods
    {
        public static IApplicationBuilder UseCurrentPathMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<CurrentPathMiddleware>();
        }
    }
}
