using Microsoft.EntityFrameworkCore;
using TravelsPortal.Core.Entities.TravelsPortal.Core.Entities;

namespace TravelsPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Travel> Travels { get; set; }
    }
}