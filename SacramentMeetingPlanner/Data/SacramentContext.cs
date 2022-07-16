using SacramentMeetingPlanner.Models;
using Microsoft.EntityFrameworkCore;


namespace SacramentMeetingPlanner.Data
{
    public class SacramentContext : DbContext
    {
        public SacramentContext(DbContextOptions<SacramentContext> options) : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Participant> Participants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().ToTable("Member");
            modelBuilder.Entity<Meeting>().ToTable("Meeting");
            modelBuilder.Entity<Participant>().ToTable("Participant");

            modelBuilder.Entity<Participant>()
                .HasKey(p => new { p.MeetingID, p.MemberID });

            modelBuilder.Entity<Participant>()
                .HasOne(p => p.Member)
                .WithMany(p => p.Participants)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Meeting>()
                .HasOne(m => m.Member)
                .WithMany(m => m.Meetings);
        }

    }
}
