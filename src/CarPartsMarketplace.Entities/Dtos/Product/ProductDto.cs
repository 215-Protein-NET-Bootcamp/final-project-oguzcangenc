using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities.Dtos.Product
{
    public class ProductDto : BaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public bool IsOfferable { get; set; }
        public decimal Price { get; set; }
        public bool IsSold { get; set; }

        public virtual Entities.Category Category { get; set; }
        public virtual Entities.Brand Brand { get; set; }
        public virtual Entities.Color Color { get; set; }

    }
}
