using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Business.Adapters.EmailService.Utilities;

namespace CarPartsMarketplace.Business.Adapters.EmailService.Abstract
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
        void SendEmail(MailRequest mailRequest);

    }
}
