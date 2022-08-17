using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities.Dtos.ApplicationUser
{
    public class RegisterUserWelcomeMailJobDto : IDto
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
