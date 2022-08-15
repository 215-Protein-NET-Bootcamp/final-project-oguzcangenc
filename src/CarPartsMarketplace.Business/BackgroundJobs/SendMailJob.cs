using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Business.Adapters.EmailService.Abstract;
using CarPartsMarketplace.Business.Adapters.EmailService.Utilities;

namespace CarPartsMarketplace.Business.BackgroundJobs
{
    public class SendMailJob:ISendMailJob
    {
        private readonly IMailService _mailService;

        public SendMailJob(IMailService mailService)
        {
            _mailService = mailService;
        }
        public async Task SendMail(MailRequest mailRequest)
        {
            try
            {
                await _mailService.SendEmailAsync(mailRequest);
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("This job will never succeed.");

            }
        }
    }
}
