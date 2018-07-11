using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GigHub.Models
{
    public class GigHubContext : DbContext
    {
        public DbSet<Gig> Gigs { get; set; }

    }
}