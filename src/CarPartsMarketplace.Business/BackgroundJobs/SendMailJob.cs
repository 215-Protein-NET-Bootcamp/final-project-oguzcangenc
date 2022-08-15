using CarPartsMarketplace.Business.Adapters.EmailService.Abstract;
using CarPartsMarketplace.Business.Adapters.EmailService.Utilities;

namespace CarPartsMarketplace.Business.BackgroundJobs
{
    public class SendMailJob : ISendMailJob
    {
        private readonly IMailService _mailService;

        public SendMailJob(IMailService mailService)
        {
            _mailService = mailService;
        }
        public async Task SendMail(MailRequest mailRequest)
        {
            await _mailService.SendEmailAsync(mailRequest);
        }
    }
}
