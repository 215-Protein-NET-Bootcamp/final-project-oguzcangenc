using CarPartsMarketplace.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarPartsMarketplace.Data.Config
{
    public class UserOperationClaimConfig: BaseConfig<UserOperationClaim>
    {
        public override void Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {
            builder.HasData(new UserOperationClaim()
            {
                Id=1,
                OperationClaimId = 1,
                UserId = 1,
                CreatedAt = 1,
                IsDeleted = false,
                ModifiedDate = DateTime.UtcNow,
                CreatedDate = DateTime.UtcNow,
                LastActivity = DateTime.UtcNow
            });
            base.Configure(builder);
        }
    }
}
