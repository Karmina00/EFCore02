using Microsoft.EntityFrameworkCore;
using EFCore02.Configurations;


namespace EFCore02.Contexts
{
    internal class EventHubDbContext : DbContext

    {
        public DbSet<Models.Organizer> Organizers { get; set; } = null!;
        public DbSet<Models.OrganizerProfile> OrganizerProfiles { get; set; } = null!;
        public DbSet<Models.Event> Events { get; set; } = null!;
        public DbSet<Models.Attendee> Attendees { get; set; } = null!;
        public DbSet<Models.Badge> Badges { get; set; } = null!;

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=EventHubDb;Trusted_Connection=True; trustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.OrganizerProfile>()
              .HasOne(op => op.Organizer)
              .WithOne(o => o.Profile)
              .HasForeignKey<Models.OrganizerProfile>(op => op.OrganizerId);

            modelBuilder.Entity<Models.Event>()
                .HasOne(e => e.Organizer)
                .WithMany(o => o.Events)
                .HasForeignKey(e => e.OrganizerId);


            

            modelBuilder.ApplyConfiguration(new BadgeConfiguration());
        }





    }
}
