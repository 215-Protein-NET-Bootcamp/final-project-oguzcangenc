using CarPartsMarketplace.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarPartsMarketplace.Data.Config
{
    public class ApplicationUserConfig : BaseConfig<ApplicationUser>
    {
        public override void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            base.Configure(builder);
        }
    }
}
