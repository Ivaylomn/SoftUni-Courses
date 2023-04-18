using HouseRentingSystem.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentingSystem.Infrastructure.Data.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(SeedCategories());
        }

        private List<Category> SeedCategories()
        {
            var categories = new List<Category>();

            categories.Add(new Category()
            {
                Id = 1,
                Name = "Cottage"
            });

            categories.Add(new Category()
            {
                Id = 2,
                Name = "Single-Family"
            });

            categories.Add(new Category()
            {
                Id = 3,
                Name = "Duplex"
            });

            return categories;
        }
    }
}
