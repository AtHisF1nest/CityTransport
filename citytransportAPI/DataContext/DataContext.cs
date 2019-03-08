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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ForNpgsqlUseIdentityColumns();
        }
        
        public DbSet<Player> Players { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

    }
}