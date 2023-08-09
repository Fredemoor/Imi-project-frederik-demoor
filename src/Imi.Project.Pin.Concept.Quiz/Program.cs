
using Imi.Project.Pin.Concept.Quiz.Infrastructure.Services;
using Imi.Project.Pin.Concept.Quiz.Interfaces;
using Imi.Project.Pin.Concept.Quiz.Quiz.Infrastructure.Api;

namespace Imi.Project.Pin.Concept.Quiz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.


            builder.Services.AddSingleton<IAppHttpCLient, AppHttpClient>();
            builder.Services.AddSingleton<IQuizService, ApiQuizService>();
            builder.Services.AddSingleton<IPlayerTrackingService, PlayerTrackingService>();
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}