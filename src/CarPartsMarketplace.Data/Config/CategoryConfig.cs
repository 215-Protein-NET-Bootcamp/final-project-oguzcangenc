using CarPartsMarketplace.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarPartsMarketplace.Data.Config
{
    public class CategoryConfig : BaseConfig<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);

            builder.HasData(new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Triger Kayışları",
                    CreatedAt = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    LastActivity = DateTime.UtcNow,
                },
                new Category()
                {
                    Id = 2,
                    Name = "Ateşleme",
                    CreatedAt = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    LastActivity = DateTime.UtcNow,
                },
                new Category()
                {
                    Id = 3,
                    Name = "Fren Sistemi",
                    CreatedAt = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    LastActivity = DateTime.UtcNow,
                }
            });
            base.Configure(builder);
        }
    }
}
