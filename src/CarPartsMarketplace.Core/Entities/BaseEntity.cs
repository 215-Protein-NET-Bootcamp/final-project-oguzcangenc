namespace CarPartsMarketplace.Core.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public int CreatedAt { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? LastActivity { get; set; }
        public bool IsDeleted { get; set; }
    }
}
