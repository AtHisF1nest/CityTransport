using Core.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace citytransportAPI
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=citytransportdb;Username=citytransportuser;Password=citytransportpw");
        }
        public DbSet<Player> Players { get; set; }

    }
}