using CarPartsMarketplace.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarPartsMarketplace.Data.Config
{
    public class ColorConfig:BaseConfig<Color>
    {
        public override void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);

            builder.HasData(new List<Color>()
            {
                new Color()
                {
                    Id = 1,
                    Name = "Siyah",
                    CreatedAt = 1,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    LastActivity = DateTime.UtcNow,
                    IsDeleted = false
                },
                new Color()
                {
                    Id = 2,
                    Name = "Beyaz",
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
