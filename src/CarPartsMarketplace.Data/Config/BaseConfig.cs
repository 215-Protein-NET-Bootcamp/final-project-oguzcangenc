using CarPartsMarketplace.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarPartsMarketplace.Data.Config
{
    public class BaseConfig<TEntity>: IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity, IEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.CreatedDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(p => p.ModifiedDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(p => p.LastActivity).HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}
