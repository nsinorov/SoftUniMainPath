using EventMe.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventMe.Infrastructure.Data.Configurations
{
    public class TownConfiguration : IEntityTypeConfiguration<Town>
    {
        private readonly string[] towns = new string[] { "София", "Пловдив", "Варна", "Бутгас" };

        public void Configure(EntityTypeBuilder<Town> builder)
        {
            List<Town> entities = new List<Town>();
            int id = 1;

            foreach (var item in towns)
            {
                entities.Add(new Town
                {
                    Id = id++,
                    Name = item
                });
            }

            builder.HasData(entities);
        }
    }
}
