using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore02.Configurations
{
    public class BadgeConfiguration : IEntityTypeConfiguration<Models.Badge>
    {
        public void Configure(EntityTypeBuilder<Models.Badge> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.BadgeNumber)
                .IsRequired();
            builder.HasIndex(b => b.BadgeNumber)
                .IsUnique();

            builder.HasOne(b => b.Attendee)
              .WithOne(a => a.Badge)
              .HasForeignKey<Models.Badge>(b => b.AttendeeId);

        }
    }
}
