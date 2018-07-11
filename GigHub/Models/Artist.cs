using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Artist
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}