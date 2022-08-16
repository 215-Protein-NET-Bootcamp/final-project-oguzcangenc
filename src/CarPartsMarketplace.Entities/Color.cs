using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities
{
    public class Color : BaseEntity, IEntity
    {
        public string? Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
