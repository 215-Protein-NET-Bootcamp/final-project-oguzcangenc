namespace CarPartsMarketplace.Core.Entities;

public class OperationClaim : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual  ICollection<UserOperationClaim> UserOperationClaims { get; set; }
}