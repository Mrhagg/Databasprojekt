using DataLagring.Entities;
using Microsoft.EntityFrameworkCore;


namespace DataLagring.Contexts
{
    internal class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<CoachEntity> Coaches { get; set; }
        public DbSet<CountryEntity> Countries { get; set; }
        public DbSet<PlayerEntity> Players { get; set; }
        public DbSet<StadiumEntity> Stadiums { get; set;}
        public DbSet<TeamEntity> Teams { get; set; }
    }
}
