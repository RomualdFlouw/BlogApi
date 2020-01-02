using BlogApi;
using BlogModels.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace Cinema.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.GetRequiredService<DBContext>();
                    context.Database.EnsureDeleted();//verwijder (-> niet doen in productie)
                    context.Database.EnsureCreated(); //maakt db aan volgens modellen
                    ////context.Database.Migrate();//voert migraties uit

                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "EnsureCreated: An error occurred creating the DB.");
                }
            }
            host.Run();
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //webBuilder.UseUrls("https://localhost:5010/%22); //indien andere poort dan de API
                    webBuilder.UseStartup<Startup>();
                });
    }
}