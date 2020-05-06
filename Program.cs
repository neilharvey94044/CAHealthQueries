using CAHealthQueries.NPPES;
using System;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

/*
 * Explore and create boilerplate code for data access to SQL Server.
 * This is a .Net Core Console application that leverages Dependency Injection.
 * These routines rely upon data loaded by two GitHub projects; NPPES-Data-Load
 * and CAHealthFacilityDBLoad.

 * 
 */
namespace CAHealthQueries
{
    class Program
    {

        static private IHostEnvironment _env { get; set; }
            static void Main(string[] args)
            {
                try
                {

                // Configure the host container
                var hbldr = CreateHostBuilder(args).Build();

                    // Configure services
                    var config = hbldr.Services.GetService<IConfiguration>();
                    var serviceProvider = ConfigureServices(config);

                    // Execute the application
                    serviceProvider.GetService<ConsoleApplication>().run(args);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    NLog.LogManager.Shutdown();
                }
            }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingcontex, config) =>
                {
                    _env = hostingcontex.HostingEnvironment;
                    config.AddEnvironmentVariables()
                    .AddCommandLine(args);
                    if (_env.IsDevelopment())
                    {
                        config.AddUserSecrets<ConsoleApplication>();
                    }
                });
                
        public static ServiceProvider ConfigureServices(IConfiguration config)
            {
            return new ServiceCollection()
                .AddLogging(builder =>
                {
                    builder.ClearProviders();
                    builder.SetMinimumLevel(LogLevel.Trace);
                    builder.AddNLog("nlog.config");
                })
                .AddTransient<ConsoleApplication>()
                .AddSingleton<IConfiguration>(config)
                .AddSingleton<IHostEnvironment>(_env)
                .BuildServiceProvider();
            }
    }
 }
