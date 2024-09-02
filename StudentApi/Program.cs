
using Microsoft.EntityFrameworkCore;
using StudentApi.Models;
using FluentValidation;
using FluentValidation.AspNetCore;
using StudentApi.Services;

namespace StudentApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            var configuration = builder.Configuration;
            var connectionString = configuration.GetConnectionString("DatabaseContext");

            builder.Services.AddTransient<StudentService>();

            builder.Services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlite(connectionString));
            builder.Services.AddControllers();

            // Add FluentValidation with the updated methods
            builder.Services.AddValidatorsFromAssemblyContaining<StudentValidator>();
            builder.Services.AddFluentValidationAutoValidation()
                            .AddFluentValidationClientsideAdapters();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseSwagger();
            app.UseSwaggerUI();


            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
