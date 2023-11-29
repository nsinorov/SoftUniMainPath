namespace Trucks.Data
{
    using Microsoft.EntityFrameworkCore;
    using Trucks.Data.Models;

    public class TrucksContext : DbContext
    {
        //Constructors
        public TrucksContext() { }
        public TrucksContext(DbContextOptions options) : base(options) { }

        //Properties (Tables)
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Truck> Trucks { get; set; } = null!;
        public DbSet<Despatcher> Despatchers { get; set; } = null!;
        public DbSet<ClientTruck> ClientsTrucks { get; set; } = null!;

        //Configuration
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }
        }

        //Models Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientTruck>(ct =>
            {
                ct.HasKey(ct => new {ct.ClientId, ct.TruckId});
            });
        }
    }
}
