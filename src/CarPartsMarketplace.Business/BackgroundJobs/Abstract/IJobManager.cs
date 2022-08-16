using CarPartsMarketplace.Entities.Dtos;
using Microsoft.AspNetCore.Http;

namespace CarPartsMarketplace.Business.BackgroundJobs.Abstract
{
    public interface IJobManager
    {
        Task RegisterUserActivationMailJobAsync(RegisterUserWelcomeMailJobDto jobDto,string host);
        Task AccountLocoutInformaitonMailJob(string email);
        Task AccountLocoutActivationMailJob(string email);

    }
}
