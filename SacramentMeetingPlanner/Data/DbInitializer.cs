using SacramentMeetingPlanner.Models;
using System;
using System.Linq;


namespace SacramentMeetingPlanner.Data
{
    public class DbInitializer
    {
        public static void Initialize(SacramentContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Members.Any())
            {
                return;   // DB has been seeded
            }

            var members = new Member[]
            {
            new Member{FirstName="Johnny",LastName="Stephens"},
            new Member{FirstName="Sarah",LastName="Evans"},
            new Member{FirstName="Hank",LastName="Burkowski"},
            new Member{FirstName="Lilly",LastName="Windsor"},
            new Member{FirstName="Michael",LastName="West"},
            new Member{FirstName="Andrea",LastName="Hunstsman"},
            new Member{FirstName="Samuel",LastName="Bickers"},
            new Member{FirstName="Janie",LastName="Smythe"}
            };
            foreach (Member m in members)
            {
                context.Members.Add(m);
            }
            context.SaveChanges();

        }
    }
}
