using Imi.Project.Pin.Data;
using Imi.Project.Pin.Models;
using Imi.Project.Pin.Services;
using Imi.Project.Pin.Services.Api;
using Microsoft.EntityFrameworkCore;

namespace Imi.Project.Pin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ImiProjectPinContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ImiProjectPinContext") ?? throw new InvalidOperationException("Connection string 'ImiProjectPinContext' not found.")));

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddSingleton<WeatherForecastService>();
            //builder.Services.AddTransient<ICrudService<Animal>,AnimalApiService>();
            builder.Services.AddTransient<ICrudService<Location>, LocationsApiService>();
            //builder.Services.AddTransient<ICrudService<Breed>, BreedApiService>();
            builder.Services.AddSingleton<HttpClient>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}