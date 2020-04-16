using CAHealthQueries.Models;
using System;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Web;

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
            static void Main(string[] args)
            {
                // configure NLog
                var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
                logger.Info("Main starting.");

                // Configure the host container
                var hbldr = CreateHostBuilder(args).Build();

                // Configure services
                var config = hbldr.Services.GetService<IConfiguration>();
                var serviceProvider = ConfigureServices(config);

                // Execute the application
                serviceProvider.GetService<ConsoleApplication>().run(args);
            }

            public static IHostBuilder CreateHostBuilder(string[] args) =>
                  Host.CreateDefaultBuilder(args)
                       .ConfigureLogging(logging =>
                       {
                           logging.ClearProviders();
                           logging.AddConsole();
                           logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
                       })
                      .UseNLog()
                      .ConfigureAppConfiguration((hostingcontex, config) =>
                      {
                          config.AddEnvironmentVariables()
                          .AddCommandLine(args)
                          .AddUserSecrets<ConsoleApplication>();
                      });


            public static ServiceProvider ConfigureServices(IConfiguration config)
            {
                return new ServiceCollection()
                    .AddLogging()
                    .Configure<LoggerFilterOptions>(c => c.MinLevel = LogLevel.Trace)
                    .AddTransient<ConsoleApplication>()
                    .AddSingleton<IConfiguration>(config)
                    .BuildServiceProvider();
            }
    }
 }
