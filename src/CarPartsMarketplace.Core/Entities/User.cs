namespace CarPartsMarketplace.Core.Entities;

public class User : BaseEntity
{
    public bool EmailConfirmation { get; set; }
    public bool LockoutEnabled { get; set; }
    public int AccessFailedCount { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public byte[]? PasswordSalt { get; set; }
    public byte[]? PasswordHash { get; set; }

    public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; }
}