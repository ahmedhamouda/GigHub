using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Genra
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}