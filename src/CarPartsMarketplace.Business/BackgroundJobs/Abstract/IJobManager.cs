using CarPartsMarketplace.Entities.Dtos.ApplicationUser;

namespace CarPartsMarketplace.Business.BackgroundJobs.Abstract
{
    public interface IJobManager
    {
        Task RegisterUserActivationMailJobAsync(RegisterUserWelcomeMailJobDto jobDto,string host);
        Task RegisterUserActivationSuccessfulyMailJobAsync(RegisterUserActivationSuccessfulyDto jobDto);
        Task AccountLocoutInformaitonMailJob(string email);
        Task AccountLocoutActivationMailJob(string email);

    }
}
