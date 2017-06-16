using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
namespace MouseGuardGMTool.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            if (!context.TheGuards.Any())
            {
                context.TheGuards.AddRange(
                    new TheGuard 
                    {
                        Name="Thom", 
	                    Nature = 4, 
	                    Will = 4, 
	                    Health = 4,
	                    Resources = 4, 
	                    Circles = 5
	                },
                     new TheGuard
                     {
                         Name = "David",
                         Nature = 4,
                         Will = 4,
                         Health = 4,
                         Resources = 4,
                         Circles = 5
                     },
                     new TheGuard
                     {
                         Name = "Bran",
                         Nature = 4,
                         Will = 4,
                         Health = 4,
                         Resources = 4,
                         Circles = 5
                     },
                     new TheGuard
                     {
                         Name = "Gwen",
                         Nature = 4,
                         Will = 4,
                         Health = 4,
                         Resources = 4,
                         Circles = 5
                     },
                    new TheGuard
                    {
                        Name = "Kyle",
                        Nature = 5,
                        Will = 4,
                        Health = 3,
                        Resources = 3,
                        Circles = 5
                    });
                context.SaveChanges();
            }
        }
    }
}