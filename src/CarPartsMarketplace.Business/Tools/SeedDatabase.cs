using CarPartsMarketplace.Core.Entities;
using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Core.Utilities.Security.Hashing;
using CarPartsMarketplace.Data.Context.EntityFramework;

namespace CarPartsMarketplace.Business.Tools
{
    public static class SeedDatabase
    {
        public static void Seed(AppDbContext context)
        {
            HashingHelper.CreatePasswordHash("Etj810c222.*", out byte[] passwordHash, out byte[] passwordSalt);
            
            context.ApplicationUsers.Add(new ApplicationUser()
            {
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
            });
            context.UserOperationClaims.Add(new UserOperationClaim()
            {
                OperationClaimId = 1,
                UserId = 1,
            });
            context.SaveChanges();
        }

    }
}
