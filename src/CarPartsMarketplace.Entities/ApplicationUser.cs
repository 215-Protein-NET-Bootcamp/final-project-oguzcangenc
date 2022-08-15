using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities
{
    public class ApplicationUser: User,IEntity
    {
        public bool EmailConfirmation { get; set; }
        public string? RefreshToken { get; set; }

    }
}