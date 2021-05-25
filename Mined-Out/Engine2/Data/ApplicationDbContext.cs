using System.Data.Entity;

namespace Engine.Data
{
	public class ApplicationDbContext : DbContext
	{
        public DbSet<BestScore> BestScore { get; set; }
        public DbSet<Save> Saves { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Bomb> Bombs { get; set; }
        public DbSet<Barrier> Barriers { get; set; }
        public DbSet<PlayerFootprint> PlayerFootprints { get; set; }

        public ApplicationDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=Mined-OutDb;Integrated Security=true");
        }
    }
}
