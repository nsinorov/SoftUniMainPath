namespace Boardgames.Data
{
    using Boardgames.Data.Models;
    using Microsoft.EntityFrameworkCore;
    
    public class BoardgamesContext : DbContext
    {
        //Constructors
        public BoardgamesContext() { }
        public BoardgamesContext(DbContextOptions options) : base(options) { }

        //Properties (Tables)
        public DbSet<Boardgame> Boardgames { get; set; } = null!;
        public DbSet<Creator> Creators { get; set; } = null!;
        public DbSet<Seller> Sellers { get; set; } = null!;
        public DbSet<BoardgameSeller> BoardgamesSellers { get; set; } = null!;

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
            //BoardgamesSellers
            modelBuilder.Entity<BoardgameSeller>(bs => 
                bs.HasKey(bs => new 
                { 
                    bs.BoardgameId, 
                    bs.SellerId 
                }));
        }
    }
}