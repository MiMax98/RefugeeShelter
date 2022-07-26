using Microsoft.EntityFrameworkCore;
using RefugeeShelter.Models;

namespace RefugeeShelter.Data
{
    public class ShelterDbContext : DbContext
    {
        public ShelterDbContext(DbContextOptions<ShelterDbContext> options) : base(options)
        {

        }

        public ShelterDbContext()
        {

        }

        public DbSet<Shelter> Shelters { get; set; }
    }
}
