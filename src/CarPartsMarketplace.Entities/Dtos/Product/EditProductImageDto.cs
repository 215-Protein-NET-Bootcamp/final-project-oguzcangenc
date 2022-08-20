using CarPartsMarketplace.Core.Entities;
using Microsoft.AspNetCore.Http;

namespace CarPartsMarketplace.Entities.Dtos.Product
{
    public class EditProductImageDto:IDto
    {
        public IFormFile? EditFormFile { get; set; }
    }
}
