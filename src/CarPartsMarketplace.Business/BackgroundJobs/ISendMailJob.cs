using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Business.Adapters.EmailService.Utilities;
using Hangfire;

namespace CarPartsMarketplace.Business.BackgroundJobs
{
    public interface ISendMailJob
    {
        [AutomaticRetry(Attempts = 5)]
        Task SendMail(MailRequest mailRequest);

    }
}
