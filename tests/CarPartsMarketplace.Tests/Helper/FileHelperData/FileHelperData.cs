using Microsoft.AspNetCore.Http;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CarPartsMarketplace.Tests.Helper.FileHelperData
{
    public static class FileHelperData
    {

        public static IFormFile CreateTestPngImage()
        {

            var pngTestFile = File.OpenRead(@"TestPhotos\png-test.png");
            MemoryStream data = new MemoryStream();
            using (var fs = pngTestFile)
            {
                var file = new FormFile(fs, 0, fs.Length, "PngTestFile", pngTestFile.Name);

                return file;
            }

        }
        public static IFormFile CreateTestJpgImage()
        {

            var jpgFile = File.OpenRead(@"TestPhotos\jpg-test.jpg");
            MemoryStream data = new MemoryStream();
            using (var fs = jpgFile)
            {
                var file = new FormFile(fs, 0, fs.Length, "jpgTestFile", jpgFile.Name);

                return file;
            }

        }
        public static IFormFile CreateTestCsvFile()
        {

            var csv = File.OpenRead(@"TestPhotos\test-csv-file.csv");
            System.IO.MemoryStream data = new System.IO.MemoryStream();
            using (var fs = csv)
            {
                var file = new FormFile(fs, 0, fs.Length, "csvTestFile", csv.Name);

                return file;
            }

        }
        public static IFormFile CreateTestJpegImage()
        {

            var jpegFile = File.OpenRead(@"TestPhotos\jpeg-test.jpeg");
            System.IO.MemoryStream data = new MemoryStream();
            using (var fs = jpegFile)
            {
                var file = new FormFile(fs, 0, fs.Length, "jpgTestFile", jpegFile.Name);

                return file;
            }

        }

        public static IFormFile CreateTestImageSize()
        {

            var jpgFile = File.OpenRead(@"TestPhotos\file-size-test.jpg");
            MemoryStream data = new MemoryStream();
            using (var fs = jpgFile)
            {
                var file = new FormFile(fs, 0, fs.Length, "jpgTestSizeFile", jpgFile.Name);

                return file;
            }

        }
    }

}
