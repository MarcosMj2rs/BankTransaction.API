using BankTransaction.API.CategoryDI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace BankTransaction.API
{
	public class Program
    {
        public static void Main(string[] args)
        {
            IServiceCollection collection = new ServiceCollection();
            collection.AddTransient<ICategoryDI, CategoryPublic>();
            collection.AddTransient<ICategoryDI, CategoryPrivate>();
            collection.AddSingleton<ApplyRules>();
            IServiceProvider serviceProvider = collection.BuildServiceProvider();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
