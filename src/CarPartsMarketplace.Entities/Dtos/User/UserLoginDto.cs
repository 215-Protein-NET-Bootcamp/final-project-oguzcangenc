using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities.Dtos.ApplicationUser;

public class UserLoginDto : IDto
{
    public string Email { get; set; }
    public string Password { get; set; }
}