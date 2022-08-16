using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities
{
    public class Offer : BaseEntity, IEntity
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public bool Status { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
