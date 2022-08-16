using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities.Dtos
{
    public class RegisterUserWelcomeMailJobDto:IDto
    {
        public  string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }
}
