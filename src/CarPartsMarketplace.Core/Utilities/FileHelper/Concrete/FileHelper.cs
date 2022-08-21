using CarPartsMarketplace.Core.Constants;
using CarPartsMarketplace.Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using CarPartsMarketplace.Core.Utilities.FileHelper.Abstract;
using Serilog.Sinks.File;

namespace CarPartsMarketplace.Core.Utilities.FileHelper.Concrete
{
    public class FileHelper : IFileHelper
    {
        private IHttpContextAccessor _httpContextAccessor;
        public FileHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public FileHelper()
        {

        }

        public async Task<IDataResult<string>> UploadImageUpdate(IFormFile file)
        {
            try
            {
                if (file.Length == 0)
                {
                    return new ErrorDataResult<string>(Messages.FILE_NOT_FOUND);
                }

                if ((file.Length / 1024f) > 400)
                {
                    return new ErrorDataResult<string>(Messages.FILE_SIZE_ERROR);

                }


                var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
                if (extension != ".jpeg" && extension != ".jpg" && extension != ".png")
                {
                    return new ErrorDataResult<string>(Messages.IMAGE_FORMAT_ERROR);

                }

                var result = await WriteFile(file);

                return new SuccessDataResult<string>(result, Messages.SUCCESS_FILE_UPLOAD);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<string>(Messages.FILE_NOT_FOUND);

            }

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
                fileName = _httpContextAccessor.HttpContext.Request.Host.Value + "/images/" + fileName;
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
        public string SetProductImage(string currentImageUrl)
        {
            string fileName;
            var split = currentImageUrl.Split('/');
            fileName = _httpContextAccessor.HttpContext.Request.Host.Value + "/images/placeholder.png";
            if (split[2] != "placeholder.png")
            {
                FileInfo file = new FileInfo("wwwroot\\images\\" + split[2]);
                if (file.Exists)
                {
                    file.Delete();
                    return fileName;

                }
            }
            return fileName;
        }
    }
}
