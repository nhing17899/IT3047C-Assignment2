using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assignment2_EFBasics.Data;
using Assignment2_EFBasics.Interfaces;
using Assignment2_EFBasics.Utilities;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Assignment2_EFBasics.Middleware;

namespace Assignment2_EFBasics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlite("Data Source=myDatabase.db"));

            builder.Services.AddTransient<IStudentValidator>(validator => new StudentValidator(true));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            #region JWT Validation
            var secret = "MyVerySuperSecureSecretSharedKey";
            var secretKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secret));
            var issuer = "http://www.uc.edu/IT3047C";
            var audience = "WebServerApplicationDevelopment";

            builder.Services.AddAuthentication(OptionsBuilderConfigurationExtensions =>
            {
                OptionsBuilderConfigurationExtensions.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = secretKey,

                    ValidateIssuer = true,
                    ValidIssuer = issuer,

                    ValidateAudience = true,
                    ValidAudience = audience,

                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
            });
            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCurrentPathMiddleware();

            app.Use(async (context, next) =>
            {
                var requestMethod = context.Request.Method;

                Console.WriteLine("Inline Middleware - Request Method: " + requestMethod);

                await next(context);
            });

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}