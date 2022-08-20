using CarPartsMarketplace.Core.Entities;
using CarPartsMarketplace.Core.Utilities.Security.Hashing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarPartsMarketplace.Data.Config
{
    public class ApplicationUserConfig : BaseConfig<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(p => p.FirstName).IsRequired();
            builder.Property(p => p.LastName).IsRequired();
            builder.Property(p => p.Email).IsRequired();
            builder.Property(p => p.LockoutEnabled).HasDefaultValue(false);
            builder.Property(p => p.AccessFailedCount).HasDefaultValue(0);
            builder.Property(p => p.EmailConfirmation).HasDefaultValue(false);
            builder.Property(p => p.PasswordHash).IsRequired();
            builder.Property(p => p.PasswordSalt).IsRequired();
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);

            HashingHelper.CreatePasswordHash("Etj810c222.*", out byte[] passwordHash, out byte[] passwordSalt);

            builder.HasData(new List<User>()
            {
                new User()
                {
                    Id=1,
                    Email = "admin@admin.com",
                    FirstName = "Admin",
                    LastName = "Admin",
                    EmailConfirmation = true,
                    AccessFailedCount = 0,
                    CreatedAt = 1,
                    CreatedDate = DateTime.UtcNow,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    IsDeleted = false,
                    LastActivity = DateTime.UtcNow,
                    LockoutEnabled = false,
                    ModifiedDate = DateTime.UtcNow,
                }

            });
            base.Configure(builder);
        }
    }
}
