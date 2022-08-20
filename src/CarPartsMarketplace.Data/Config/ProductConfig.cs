using CarPartsMarketplace.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarPartsMarketplace.Data.Config
{
    public class ProductConfig : BaseConfig<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(500);
            builder.Property(x => x.CategoryId).IsRequired();
            builder.Property(x => x.UsageId).IsRequired();
            builder.Property(x => x.ImageUrl).IsRequired();
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(x => x.IsOfferable).HasDefaultValue(false);
            builder.Property(p => p.PurchasingUserId).HasDefaultValue(0);
            builder.Property(x => x.IsSold).HasDefaultValue(false);

            builder.HasData(new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Dayco Triger Seti 1.2 16V",
                    Description = "Dayco Triger Seti 1.2 16V Dacıa Logan Sandero Clio Kango Modus Symbol Twıngo",
                    ColorId = 1,
                    BrandId = 1,
                    CategoryId = 1,
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow,
                    IsSold = false,
                    IsOfferable = true,
                    LastActivity = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    Price = 1500,
                    CreatedAt = 1,
                    UserId = 1,
                    ImageUrl = "placeholder.jpg",
                    UsageId = 1
                },
                new Product()
                {
                    Id = 2,
                    Name = "Ngk Ateşleme Lpg Buji Takımı",
                    Description = "Kutu İçeriği: 4 adet NGK Spark Plugs CNG/LPG BKR-GAS 7987 İnce Paso Kalem Buji",
                    ColorId = 2,
                    BrandId = 2,
                    CategoryId = 2,
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow,
                    IsSold = false,
                    IsOfferable = true,
                    LastActivity = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    Price = 358,
                    CreatedAt = 1,
                    UserId = 1,
                    ImageUrl = "placeholder.jpg",
                    UsageId = 1
                },
                new Product()
                {
                    Id = 3,
                    Name = "Bosch On Fren Dısk+Balata Set Ferrari",
                    Description = "On Fren Dısk Havalandırmalı Bmw 1 Serısı E81 E82 E87 E88 03-12 3 Serısı E90 E91 318d 318ı 320sı 320d 320ı 325sı 325xı 05-11 Bosch 0986479216",
                    ColorId = 1,
                    BrandId = 3,
                    CategoryId = 3,
                    IsDeleted = false,
                    CreatedDate = DateTime.UtcNow,
                    IsSold = false,
                    IsOfferable = false,
                    LastActivity = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    Price = 657,
                    CreatedAt = 1,
                    UserId = 1,
                    ImageUrl = "placeholder.jpg",
                    UsageId = 1
                }
            });
        }
    }
}
