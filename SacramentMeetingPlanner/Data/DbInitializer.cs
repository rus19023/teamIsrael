using SacramentMeetingPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SacramentMeetingPlanner.Data
{
    public class DbInitializer
    {
        public static void Initialize(SacramentContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Members.Any() || context.Meetings.Any() || context.Participants.Any())
            {
                return;   // DB has been seeded
            }

            var members = new Member[]
            {
            new Member{FirstName="Johnny",LastName="Stephens",IsLeader = true},
            new Member{FirstName="Sarah",LastName="Evans"},
            new Member{FirstName="Hank",LastName="Burkowski"},
            new Member{FirstName="Lilly",LastName="Windsor"},
            new Member{FirstName="Michael",LastName="West",IsLeader = true},
            new Member{FirstName="Andrea",LastName="Hunstsman"},
            new Member{FirstName="Samuel",LastName="Bickers",IsLeader = true},
            new Member{FirstName="Janie",LastName="Smythe"},
            new Member{FirstName="Andrew",LastName = "Laslow"},
            new Member{FirstName="Jack",LastName="Bartley"}
            };
            foreach (Member m in members)
            {
                context.Members.Add(m);
            }

            context.SaveChanges();

            var meetings = new Meeting[]
            {
                new Meeting
                {
                    MeetingDate = new DateTime(2022,7,3),
                    MemberID = members.Single(m => m.LastName == "Stephens").ID,
                    OpeningHymn = "11 - What Was Witnessed in the Heavens?",
                    SacramentHymn = "116 - Come, Follow Me",
                    ClosingHymn = "171 - With Humble Heart"
                },
                new Meeting
                {
                    MeetingDate = new DateTime(2022,7,10),
                    MemberID = members.Single(m => m.LastName == "West").ID,
                    OpeningHymn = "120 - Lean on My Ample Arm",
                    SacramentHymn = "129 - Where Can I Turn for Peace?",
                    ClosingHymn = "290 - Rejoice, Ye Saints of Latter Days"
                },
                new Meeting
                {
                    MeetingDate = new DateTime(2022,7,17),
                    MemberID = members.Single(m => m.LastName == "Bickers").ID,
                    OpeningHymn = "302 - I Know My Father Lives",
                    SacramentHymn = "116 - Come, Follow Me",
                    ClosingHymn = "64 - On This Day of Joy and Gladness",
                    IntermediateNumber = "Consider the Lilies"
                },
                new Meeting
                {
                    MeetingDate = new DateTime(2022,7,24),
                    MemberID = members.Single(m => m.LastName == "Stephens").ID,
                    OpeningHymn = "35 - For the Strength of the Hills",
                    SacramentHymn = "71 - With Songs of Praise",
                    ClosingHymn = "108 - The Lord Is My Shepherd",
                    IntermediateNumber = "A Family Is Forever"
                }
            };

            foreach (Meeting meeting in meetings)
            {
                context.Meetings.Add(meeting);
            }

            context.SaveChanges();

            List<List<Participant>> participants = new List<List<Participant>>
            {
                new List<Participant>
                {
                    new Participant
                    {
                        IsPraying = true,
                        MemberID = members.Single(m => m.LastName == "Evans").ID,
                        Order = 0
                    },
                    new Participant
                    {
                        IsPraying = true,
                        MemberID = members.Single(m => m.LastName == "Burkowski").ID,
                        Order = 1
                    }
                },
                new List<Participant>
                {
                    new Participant
                    {
                        IsPraying = true,
                        MemberID = members.Single(m => m.LastName == "Windsor").ID,
                        Order = 0
                    },
                    new Participant
                    {
                        IsPraying = true,
                        MemberID = members.Single(m => m.LastName == "Hunstsman").ID,
                        Order = 1
                    },
                    new Participant
                    {
                        MemberID = members.Single(m => m.LastName == "Smythe").ID,
                        Order = 0,
                        Topic = "The Gospel of Christ"
                    },
                    new Participant
                    {
                        MemberID = members.Single(m => m.LastName == "Laslow").ID,
                        Order = 1,
                        Topic = "Faith"
                    },
                    new Participant
                    {
                        MemberID = members.Single(m => m.LastName == "Bartley").ID,
                        Order = 2,
                        Topic = "Repentance"
                    }
                },
                new List<Participant>
                {
                    new Participant
                    {
                        IsPraying = true,
                        MemberID = members.Single(m => m.LastName == "Laslow").ID,
                        Order = 0
                    },
                    new Participant
                    {
                        IsPraying = true,
                        MemberID = members.Single(m => m.LastName == "Smythe").ID,
                        Order = 1
                    },
                    new Participant
                    {
                        MemberID = members.Single(m => m.LastName == "Hunstsman").ID,
                        Order = 0,
                        Topic = "Baptism"
                    },
                    new Participant
                    {
                        MemberID = members.Single(m => m.LastName == "Windsor").ID,
                        Order = 1,
                        Topic = "Gift of the Holy Ghost"
                    }
                },
                new List<Participant>
                {
                    new Participant
                    {
                        IsPraying = true,
                        MemberID = members.Single(m => m.LastName == "Bartley").ID,
                        Order = 0
                    },
                    new Participant
                    {
                        IsPraying = true,
                        MemberID = members.Single(m => m.LastName == "Hunstsman").ID,
                        Order = 1
                    },
                    new Participant
                    {
                        MemberID = members.Single(m => m.LastName == "Evans").ID,
                        Order = 0,
                        Topic = "The Atonement"
                    },
                    new Participant
                    {
                        MemberID = members.Single(m => m.LastName == "Burkowski").ID,
                        Order = 1,
                        Topic = "Forgiveness"
                    },
                    new Participant
                    {
                        MemberID = members.Single(m => m.LastName == "Windsor").ID,
                        Order = 2,
                        Topic = "Blessings"
                    }
                },
            };

            for (int i = 0; i < participants.Count; i++)
            {
                var participant = participants[i];
                foreach (var p in participant)
                {
                    p.MeetingID = meetings[i].ID;
                    context.Participants.Add(p);
                }
            }

            context.SaveChanges();

        }
    }
}
