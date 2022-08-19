using CarPartsMarketplace.Core.Constants;
using CarPartsMarketplace.Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Core.Utilities.FileHelper.Abstract;
using System.Runtime.Intrinsics.X86;

namespace CarPartsMarketplace.Core.Utilities.FileHelper.Concrete
{
    public class FileHelper : IFileHelper
    {
        private IHttpContextAccessor _httpContextAccessor;
        public FileHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IDataResult<string>> UploadFileUpdate(IFormFile file)
        {
            if (file.Length == 0)
            {
                return new ErrorDataResult<string>(Messages.FILE_NOT_FOUND);
            }

            var result = await WriteFile(file);

            return new SuccessDataResult<string>(result, Messages.SUCCESS_FILE_UPLOAD);
        }

        public async Task<string> WriteFile(IFormFile file)
        {
            string fileName;

            try
            {
                var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
                fileName = Guid.NewGuid().ToString() + extension;
                var imageBasePath = "wwwroot\\images";
                var getCurrentDirectory = Directory.GetCurrentDirectory();
                var path = Path.Combine(getCurrentDirectory, imageBasePath, fileName);
                fileName = _httpContextAccessor.HttpContext.Request.Host.Value + "\\images\\"+ fileName;
                using (var bits = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(bits);
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return fileName;
        }
    }
}
