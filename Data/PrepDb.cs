using System;
using PlatformService.Models;
namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {
                Console.WriteLine("--> Seeeding data");

                context.Platforms.AddRange(

                    new Platform()
                    {
                        Name = ".net",
                        Publisher = "Microsoft",
                        Cost = "Free"
                    },
                    new Platform()
                    {
                        Name = "SQL Server",
                        Publisher ="Microsoft",
                        Cost = "Freemium"
                    },
                    new Platform()
                    {
                        Name = "React",
                        Publisher= "Facebook",
                        Cost= "Free"
                    }

                  );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
        }
    }
}

