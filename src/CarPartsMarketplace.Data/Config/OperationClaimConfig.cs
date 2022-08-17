using CarPartsMarketplace.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarPartsMarketplace.Data.Config
{
    public class OperationClaimConfig : BaseConfig<OperationClaim>
    {
        public override void Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(20);
            builder.HasData(new List<OperationClaim>()
            {
                new OperationClaim()
                {
                    Id = 1,
                    Name = "admin",
                    CreatedAt = 1,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    LastActivity = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow
                },
                new OperationClaim()
                {
                    Id = 2,
                    Name = "customer",
                    CreatedAt = 1,
                    CreatedDate = DateTime.UtcNow,
                    IsDeleted = false,
                    LastActivity = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow
                }
            });
            base.Configure(builder);
        }

    }
}
