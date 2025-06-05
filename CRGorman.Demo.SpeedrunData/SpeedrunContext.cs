using CRGorman.Demo.SpeedrunData.Models;
using Microsoft.EntityFrameworkCore;

namespace CRGorman.Demo.SpeedrunData
{
    public class SpeedrunContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Act> Acts { get; set; }
        public DbSet<Mission> Missions { get; set; }
    }
}
