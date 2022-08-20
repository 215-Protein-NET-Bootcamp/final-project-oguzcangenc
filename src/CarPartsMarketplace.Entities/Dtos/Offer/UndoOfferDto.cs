using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities.Dtos.Offer
{
    public class UndoOfferDto:BaseDto
    {
        public int OfferId { get; set; }
    }
}
