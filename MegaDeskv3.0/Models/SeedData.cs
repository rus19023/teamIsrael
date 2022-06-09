using System;
using MegaDeskv3._0.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace MegaDeskv3._0.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskv3_0Context(
                       serviceProvider.GetRequiredService<
                           DbContextOptions<MegaDeskv3_0Context>>()))
            {
                // Look for any movies.
                if (context.DeskQuote.Any())
                {
                    return;   // DB has been seeded
                }

                context.DeskQuote.AddRange(
                    new DeskQuote
                    {
                        customerFirstName = "Felicia",
                        customerLastName = "Warner",
                        width = 36,
                        depth = 36,
                        drawers = 3,
                        surfaceMaterial = "Pine",
                        rushDays = 3,
                        quoteDate = new DateTime(2021, 8, 17, 0, 0, 0),
                        quoteTotal = 766
                    },

                    new DeskQuote
                    {
                        customerFirstName = "James",
                        customerLastName = "Hannegan",
                        width = 24,
                        depth = 48,
                        drawers = 7,
                        surfaceMaterial = "Veneer",
                        rushDays = 7,
                        quoteDate = new DateTime(2021, 10, 25, 0, 0, 0),
                        quoteTotal = 862
                    },

                    new DeskQuote
                    {
                        customerFirstName = "Will",
                        customerLastName = "Smith",
                        width = 93,
                        depth = 45,
                        drawers = 3,
                        surfaceMaterial = "Rosewood",
                        rushDays = 7,
                        quoteDate = new DateTime(2022, 3, 5, 0, 0, 0),
                        quoteTotal = 3875
                    },

                    new DeskQuote
                    {
                        customerFirstName = "Ethan",
                        customerLastName = "Walker",
                        width = 72,
                        depth = 30,
                        drawers = 5,
                        surfaceMaterial = "Laminate",
                        rushDays = 7,
                        quoteDate = new DateTime(2022, 8, 21, 0, 0, 0),
                        quoteTotal = 766
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
