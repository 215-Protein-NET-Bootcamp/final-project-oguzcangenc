using CarPartsMarketplace.Business.Adapters.EmailService.Utilities;
using Hangfire;

namespace CarPartsMarketplace.Business.BackgroundJobs.Abstract
{
    public interface ISendMailJob
    {
        [AutomaticRetry(Attempts = 5)]
        Task SendMail(MailRequest mailRequest);

    }
}
