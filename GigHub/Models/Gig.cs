using System;

namespace GigHub.Models
{
    public class Gig
    {
        public Guid Id { get; set; }

        public DateTime Timestamp { get; set; }

        public string Venue { get; set; }
    }
}