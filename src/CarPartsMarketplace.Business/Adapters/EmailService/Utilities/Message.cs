using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using MimeKit;

namespace CarPartsMarketplace.Business.Adapters.EmailService.Utilities
{
    public class MailRequest
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<IFormFile> Attachments { get; set; }
    }
}
