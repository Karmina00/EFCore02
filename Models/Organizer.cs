
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EFCore02.Models
{
    [Table("EventOrganizers")]
    public class Organizer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(150)]

        public string? CompanyName { get; set; }

        public bool IsVerified { get; set; }


        // one -to-one relationship with OrganizerProfile
        public OrganizerProfile? Profile { get; set; }

        // one-to-many relationship with Event
        public ICollection<Event> Events { get; set; } = new List<Event>();

    }
}
