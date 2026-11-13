
namespace EFCore02.Models
{
    public class Badge
    {
        public int Id { get; set; }

        public string BadgeNumber { get; set; } = string.Empty;

        public DateTime IssuedDate { get; set; }

        public BadgeTier Tier { get; set; }
        // one-to-one relationship with Attendee
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; } = null!;

    }
}
