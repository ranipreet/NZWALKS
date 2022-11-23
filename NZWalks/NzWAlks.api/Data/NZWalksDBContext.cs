using Microsoft.EntityFrameworkCore;
using NzWAlks.api.Models.Domains;

namespace NzWAlks.api.Data
{
    public class NZWalksDBContext : DbContext
    {
        public NZWalksDBContext(DbContextOptions<NZWalksDBContext> options):base(options)
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walks> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
