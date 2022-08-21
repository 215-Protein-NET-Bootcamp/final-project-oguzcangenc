using CarPartsMarketplace.Core.Utilities.FileHelper.Abstract;
using CarPartsMarketplace.Core.Utilities.FileHelper.Concrete;
using CarPartsMarketplace.Core.Utilities.Results;
using CarPartsMarketplace.Tests.Helper.FileHelperData;
using Microsoft.AspNetCore.Http;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartsMarketplace.Tests
{

    public class FileHelperTest
    {
        [Fact]
        public async Task Upload_File_Image_Png_Test()
        {
            var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();

            var context = new DefaultHttpContext();
            var fakeHost = "HostFileHelper";
            context.Request.Headers["HostName"] = fakeHost;
            mockHttpContextAccessor.Setup(_ => _.HttpContext).Returns(context);
           
            
            
            var fileHelper = new Mock<FileHelper>(mockHttpContextAccessor.Object);

            var result = await fileHelper.Object.UploadImageUpdate(FileHelperData.CreateTestPngImage());

            Assert.IsType<SuccessDataResult<string>>(result);

        }
        [Fact]
        public async Task Upload_File_Image_Jpg_Test()
        {
            var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();

            var context = new DefaultHttpContext();
            var fakeHost = "HostFileHelper";
            context.Request.Headers["HostName"] = fakeHost;

            mockHttpContextAccessor.Setup(_ => _.HttpContext).Returns(context);



            var fileHelper = new Mock<FileHelper>(mockHttpContextAccessor.Object);

            var result = await fileHelper.Object.UploadImageUpdate(FileHelperData.CreateTestJpgImage());

            Assert.IsType<SuccessDataResult<string>>(result);

        }

        [Fact]
        public async Task Upload_File_Image_Jpeg_Test()
        {
            var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();

            var context = new DefaultHttpContext();
            var fakeHost = "HostFileHelper";
            context.Request.Headers["HostName"] = fakeHost;

            mockHttpContextAccessor.Setup(_ => _.HttpContext).Returns(context);



            var fileHelper = new Mock<FileHelper>(mockHttpContextAccessor.Object);

            var result = await fileHelper.Object.UploadImageUpdate(FileHelperData.CreateTestJpegImage());

            Assert.IsType<SuccessDataResult<string>>(result);

        }
        [Fact]
        public async Task Upload_File_Image_Size_Test()
        {
            var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();

            var context = new DefaultHttpContext();
            var fakeHost = "HostFileHelper";
            context.Request.Headers["HostName"] = fakeHost;

            mockHttpContextAccessor.Setup(_ => _.HttpContext).Returns(context);



            var fileHelper = new Mock<FileHelper>(mockHttpContextAccessor.Object);

            var result = await fileHelper.Object.UploadImageUpdate(FileHelperData.CreateTestImageSize());

            Assert.IsType<ErrorDataResult<string>>(result);

        }
        [Fact]
        public async Task Upload_File_Image_Unsupport_Format_Test()
        {
            var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();

            var context = new DefaultHttpContext();
            var fakeHost = "HostFileHelper";
            context.Request.Headers["HostName"] = fakeHost;
            mockHttpContextAccessor.Setup(_ => _.HttpContext).Returns(context);



            var fileHelper = new Mock<FileHelper>(mockHttpContextAccessor.Object);

            var result = await fileHelper.Object.UploadImageUpdate(FileHelperData.CreateTestCsvFile());

            Assert.IsType<ErrorDataResult<string>>(result);

        }

    }
}
