using CarPartsMarketplace.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarPartsMarketplace.Data.Config
{
    public class OfferConfig:BaseConfig<Offer>
    {
        public override void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.Status).IsRequired().HasDefaultValue(true);
            builder.Property(p => p.ProductId).IsRequired();
            builder.Property(p => p.Date).HasDefaultValueSql("CURRENT_TIMESTAMP");
            base.Configure(builder);
        }
    }
}
