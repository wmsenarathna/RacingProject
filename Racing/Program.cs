using Racing.BusinessLogic.Services;
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Racing.DataAccess.Services;
using Racing.DataAccess.Interfaces;
using Racing.BusinessLogic.Interfaces;
using Serilog;

namespace Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //// create hosting object and DI layer
                //using IHost host = CreateHostBuilder(args).Build();
                //// create a service scope
                //using var scope = host.Services.CreateScope();
                //var services = scope.ServiceProvider;
                //// and return the results
                //var horseRacesService = services.GetService<IHorseRaces>();

                HorseRacesService horseRacesService = new HorseRacesService();
                var racesData = horseRacesService.GetRaceInformation();

                Console.WriteLine("-----------Horse Races Info-----------");
                Console.WriteLine(racesData);
                Console.WriteLine();
                Console.WriteLine("Press enter to load GreyHounds Races Info.");
                Console.ReadLine();

                GreyHoundsRacesService greyHoundsRacesService = new GreyHoundsRacesService();
                var racesData1 = greyHoundsRacesService.GetRaceInformation();

                Console.WriteLine("-----------GreyHounds Races Info-----------");
                Console.WriteLine(racesData1);
                Console.WriteLine();
                Console.WriteLine("Press enter to load Harness Races Info.");
                Console.ReadLine();

                HarnessRacesService harnessRacesService = new HarnessRacesService();
                var racesData2 = harnessRacesService.GetRaceInformation();

                Console.WriteLine("-----------Harness Races Info-----------");
                Console.WriteLine(racesData2);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        // implementatinon of 'CreateHostBuilder' static method and create host object
        static IHostBuilder CreateHostBuilder(string[] strings)
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((_, services) =>
                {
                    // Set up our console output class
                    services.AddScoped<IGreyHoundsRaces, GreyHoundsRacesService>();
                    services.AddScoped<IHarnessRaces, HarnessRacesService>();
                    services.AddScoped<IHorseRaces, HorseRacesService>();

                    services.AddSingleton<IGreyHoundsRacesDal, GreyHoundsRacesDal>();
                    services.AddSingleton<IHarnessRacesDal, HarnessRacesDal>();
                    services.AddSingleton<IHorseRacesDal, HorseRacesDal>();
                });
        }
    }
}
