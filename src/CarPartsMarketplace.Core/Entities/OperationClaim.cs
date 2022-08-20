namespace CarPartsMarketplace.Core.Entities;

public class OperationClaim : BaseEntity
{
    public string Name { get; set; }
    public virtual  ICollection<UserOperationClaim> UserOperationClaims { get; set; }
}