using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities
{
    public class ApplicationUser : User
    {
        public bool EmailConfirmation { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}