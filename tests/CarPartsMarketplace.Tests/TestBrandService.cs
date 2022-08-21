using AutoFixture;
using AutoMapper;
using CarPartsMarketplace.Business.Constant;
using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Business.Services.Concrete;
using CarPartsMarketplace.Core.Entities;
using CarPartsMarketplace.Core.Utilities.Results;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract;
using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Entities.Dtos.Brand;
using Castle.Core.Resource;
using Microsoft.AspNetCore.Http;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartsMarketplace.Tests
{
    public class TestBrandService
    {
        [Fact]
        public async Task CreateBrandTest()
        {
            var addBrandModel = new Fixture().Create<CreateBrandDto>();
            var brandMockRepo = new Mock<IBrandRepository>();
            var mapper = new Mock<IMapper>();
            var httpContext = new Mock<IHttpContextAccessor>();
            var unitOfWork = new Mock<IUnitOfWork>();

            var brandService = new BrandService(brandMockRepo.Object, mapper.Object, unitOfWork.Object, httpContext.Object);

            var result = brandService.Create(addBrandModel);

            brandMockRepo.Verify(x => x.AddAsync(It.IsAny<Brand>()));
        }
        [Fact]
        public async Task GetBrandTest()
        {
            var brandModel = new Fixture().Create<BrandDto>();
            brandModel.Id = 1;
            brandModel.Name = "Brand1";


            var brandMockRepo = new Mock<IBrandRepository>();
            var mapper = new Mock<IMapper>();
            var httpContext = new Mock<IHttpContextAccessor>();
            var unitOfWork = new Mock<IUnitOfWork>();

            var brandService = new BrandService(brandMockRepo.Object, mapper.Object, unitOfWork.Object, httpContext.Object);

            var result = brandService.Get(1);

            brandMockRepo.Verify(x => x.GetAsync(x => x.Id == brandModel.Id));
        }
    }
}
