using System;
using System.Collections.Generic;

namespace EFCore02.Models
{
    public class OrganizerProfile
    {
        public int Id { get; set; }

        public string Biography { get; set; } = string.Empty;

        public string? Website { get; set; }

        public string? LogoUrl { get; set; }

        public int OrganizerId { get; set; }

        public Organizer Organizer { get; set; } = null!;
    }   
}
