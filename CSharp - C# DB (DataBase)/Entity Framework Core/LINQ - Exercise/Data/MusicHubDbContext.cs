namespace MusicHub.Data;

using Microsoft.EntityFrameworkCore;
using MusicHub.Data.Models;

public class MusicHubDbContext : DbContext
{
    //Constructors
    public MusicHubDbContext() { }

    public MusicHubDbContext(DbContextOptions options) : base(options) { }

    //Properties (Tables)
    public DbSet<Writer> Writers { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Performer> Performers { get; set; }
    public DbSet<Producer> Producers { get; set; }
    public DbSet<Song> Songs { get; set; }
    public DbSet<SongPerformer> SongsPerformers { get; set; }

    //Database Connection
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(Configuration.ConnectionString);
        }
    }

    //Fluent API
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<SongPerformer>()
            .HasKey(sp => new { sp.SongId, sp.PerformerId });
    }
}
