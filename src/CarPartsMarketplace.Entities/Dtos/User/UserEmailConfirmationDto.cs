using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities.Dtos.ApplicationUser
{
    public class UserEmailConfirmationDto : IDto
    {
        public string EmailHash { get; set; }
        public string Email { get; set; }
    }
}
