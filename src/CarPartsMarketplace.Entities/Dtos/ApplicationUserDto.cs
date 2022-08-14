using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities.Dtos
{
    public class ApplicationUserDto : IDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
