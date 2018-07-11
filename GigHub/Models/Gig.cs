using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Gig
    {
        public Guid Id { get; set; }

        public DateTime Timestamp { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        [Required]
        public Artist Artist { get; set; }

        [Required]
        public Genra Genra { get; set; }
    }
}