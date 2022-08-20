namespace CarPartsMarketplace.Core.Entities
{
    public class UserOperationClaim : BaseEntity, IEntity
    {
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

        public User User { get; set; }
        public OperationClaim OperationClaim { get; set; }
    }
}
