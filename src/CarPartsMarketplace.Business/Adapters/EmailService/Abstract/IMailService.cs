using CarPartsMarketplace.Business.Adapters.EmailService.Utilities;

namespace CarPartsMarketplace.Business.Adapters.EmailService.Abstract
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
