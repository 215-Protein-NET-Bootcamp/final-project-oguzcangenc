using CarPartsMarketplace.Core.Utilities.Results;
using Microsoft.AspNetCore.Http;

namespace CarPartsMarketplace.Core.Utilities.FileHelper.Abstract
{
    public interface IFileHelper
    {
        Task<IDataResult<string>> UploadImageUpdate(IFormFile file);
        string SetProductImage(string currentImageUrl);

    }
}
