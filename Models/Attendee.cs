
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore02.Models
{
    public class Attendee
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string FullName { get; set; } = string.Empty;        

        [MaxLength(200)]
        [Required]

        public string Email { get; set; } = string.Empty;

        [MaxLength(150)]
        [Required]

        public string Street { get; set; } = string.Empty;

        [MaxLength(100)]
        [Required]
        public string City { get; set; } = string.Empty;

        [MaxLength(100)]
        [Required]
        public string Country { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        [Column("ZipCode")]
        public string PostalCode { get; set; } = string.Empty;

        [NotMapped]
        public string FullAddress => $"{Street}, {City}, {Country}, {PostalCode}";

        // one-to-one relationship with badge
        public Badge? Badge { get; set; }
    }
}
