using CarPartsMarketplace.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarPartsMarketplace.Data.Config
{
    public class UsageConfig : BaseConfig<Usage>
    {
        public override void Configure(EntityTypeBuilder<Usage> builder)
        {
            builder.Property(p => p.Name).IsRequired();

            builder.HasData(new List<Usage>()
            {
                new Usage()
                {
                    Id = 1,
                    Name = "Sıfır",
                    IsDeleted = false,
                    CreatedAt = 1,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    LastActivity = DateTime.UtcNow,
                },
                new Usage()
                {
                    Id = 2,
                    Name = "İkinci El",
                    IsDeleted = false,
                    CreatedAt = 1,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    LastActivity = DateTime.UtcNow,
                }
            });
            base.Configure(builder);
        }
    }
}
