using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities.Dtos.ApplicationUser
{
    public class UserDto : IDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatedAt { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
