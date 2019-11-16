using System.Data.Entity;

namespace ScholCL
{
    public class EfContext : DbContext
    {
        public EfContext() : base("connect")
        {
        }
        public DbSet<Students> Students { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Disciplines> Disciplines { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
    }
}