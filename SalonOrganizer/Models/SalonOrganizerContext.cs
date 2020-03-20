using Microsoft.EntityFrameworkCore;

namespace SalonOrganizer.Models
{
  public class SalonOrganizerContext : DbContext
  {
    // public virtual DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }

    public SalonOrganizerContext(DbContextOptions options) : base(options) { }
  }
}


