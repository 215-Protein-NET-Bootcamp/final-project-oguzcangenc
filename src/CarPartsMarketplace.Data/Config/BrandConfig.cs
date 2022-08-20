using CarPartsMarketplace.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarPartsMarketplace.Data.Config
{
    public class BrandConfig : BaseConfig<Brand>
    {
        public override void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);

            builder.HasData(new List<Brand>()
            {
                new Brand()
                {
                    Id = 1,
                    Name = "Dayco",
                    CreatedAt = 1,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    LastActivity = DateTime.UtcNow,
                    IsDeleted = false
                },
                new Brand()
                {
                    Id = 2,
                    Name = "Ngk",
                    CreatedAt = 1,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    LastActivity = DateTime.UtcNow,
                    IsDeleted = false
                },
                new Brand()
                {
                    Id = 3,
                    Name = "Bosch",
                    CreatedAt = 1,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    LastActivity = DateTime.UtcNow,
                    IsDeleted = false
                }
            });
            base.Configure(builder);
        }
    }
}
