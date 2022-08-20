using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
