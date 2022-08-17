using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities.Dtos.Color
{
    public class ColorDto:BaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
