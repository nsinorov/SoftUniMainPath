using EventMe.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EventMe.Infrastructure.Data
{
    /// <summary>
    /// Контекст на базата данни
    /// </summary>
    public class EventMeDbContext : DbContext
    {
        /// <summary>
        /// Конструктор на контекста на базата данни
        /// </summary>
        /// <param name="options">Настройки на връзката</param>
        public EventMeDbContext(DbContextOptions<EventMeDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(EventMeDbContext).Assembly);
        }

        /// <summary>
        /// Събития
        /// </summary>
        public DbSet<Event> Events { get; set; } = null!;

        /// <summary>
        /// Градове
        /// </summary>
        public DbSet<Town> Towns { get; set; } = null!;

        /// <summary>
        /// Места на провеждане на събития
        /// </summary>
        public DbSet<Address> Addresses { get; set; } = null!;
    }
}
