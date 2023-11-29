using Invoices.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Invoices.Data
{
    public class InvoicesContext : DbContext
    {
        //Constructors
        public InvoicesContext() { }

        public InvoicesContext(DbContextOptions options) : base(options) { }

        //Properties (Tables)
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Invoice> Invoices { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ProductClient> ProductsClients { get; set; } = null!;

        //Configuration
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        //Models Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductClient>(pc =>
            {
                pc.HasKey(pc => new { pc.ProductId, pc.ClientId });
            });
        }
    }
}

