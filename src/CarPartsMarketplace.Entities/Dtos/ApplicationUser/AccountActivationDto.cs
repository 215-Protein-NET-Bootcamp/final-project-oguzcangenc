using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities.Dtos.ApplicationUser
{
    public class AccountActivationDto : IDto
    {
        public string Email { get; set; }
    }
}
