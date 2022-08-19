using CarPartsMarketplace.Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartsMarketplace.Core.Utilities.FileHelper.Abstract
{
    public interface IFileHelper
    {
        Task<IDataResult<string>> UploadFileUpdate(IFormFile file);
    }
}
