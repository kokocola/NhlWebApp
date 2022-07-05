
using Lib.Classes;
using Microsoft.EntityFrameworkCore;
using NhlLib;
using NhlLib.Classes;
using StatsApi;

namespace NhlDAL
{
    public class NhlContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        public DbSet<PlayerStats> PlayerStats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=NhlDatabase;Trusted_Connection=True;");
        }
    }
}
