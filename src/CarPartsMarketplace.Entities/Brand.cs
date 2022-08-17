using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities
{
    public class Brand : BaseEntity, IEntity
    {
        public string Name { get; set; }

        public virtual  ICollection<Product> Products { get; set; }

    }
}
