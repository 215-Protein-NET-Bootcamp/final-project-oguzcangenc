using CarPartsMarketplace.Business.Adapters.EmailService.Utilities;
using CarPartsMarketplace.Business.BackgroundJobs.Abstract;
using CarPartsMarketplace.Core.Utilities.Security.Hashing;
using CarPartsMarketplace.Core.Utilities.Security.Jwt;
using CarPartsMarketplace.Entities.Dtos.ApplicationUser;
using Hangfire;
using Microsoft.Extensions.Options;

namespace CarPartsMarketplace.Business.BackgroundJobs.Manager
{
    public class JobManager : IJobManager
    {
        private readonly IOptions<TokenOptions> _tokenOptions;
        private readonly IBackgroundJobClient _backgroundJobClient;
        public JobManager(IBackgroundJobClient backgroundJobClient, IOptions<TokenOptions> tokenOptions)
        {
            _backgroundJobClient = backgroundJobClient;
            _tokenOptions = tokenOptions;
        }
        public async Task RegisterUserActivationMailJobAsync(RegisterUserWelcomeMailJobDto jobDto, string host)
        {
            HashingHelper.MD5Hash(jobDto.Email, out string emailMd5, _tokenOptions);
            _backgroundJobClient.Enqueue<ISendMailJob>(job => job.SendMail(new MailRequest()
            {
                Body =
                    $"Sayın {jobDto.FirstName} {jobDto.LastName}  Car Parts Marketplace'e Hoşgeldiniz. Hesabınızı Doğrulamak için linke tıklayınız. \n" +
                    $"<a href='{"https://" + host + "/api/auth/email-confirmation?EmailHash=" + emailMd5 + "&Email=" + jobDto.Email}'>Doğrulama Linki</a>",
                Subject = "Car Parts Marketplace Hoşgeldiniz.",
                ToEmail = jobDto.Email
            }));
        }

        public async Task RegisterUserActivationSuccessfulyMailJobAsync(RegisterUserActivationSuccessfulyDto jobDto)
        {
            _backgroundJobClient.Enqueue<ISendMailJob>(job => job.SendMail(new MailRequest()
            {
                Body ="Hesabınız Başarıyla Doğrulandı. İyi alışverişler dileriz",
                Subject = "Hesabınız Başarıyla Doğrulandı - Car Parts Marketplace",
                ToEmail = jobDto.Email
            }));
        }

        public async Task AccountLocoutInformaitonMailJob(string email)
        {
            _backgroundJobClient.Enqueue<ISendMailJob>(job => job.SendMail(new MailRequest()
            {
                Body = "Hesabınıza bir kaç kez giriş yapıldı ve başarısız oldu. Hesabınız güvenlik açısıyla kilitlendi. Lütfen hesabınızı müşteri hizmetleri ile iletişime geçerek aktive ediniz.",
                Subject = "Hesabınız Kilitlendi - Car Parts Marketplace",
                ToEmail = email
            }));
        }

        public async Task AccountLocoutActivationMailJob(string email)
        {
            _backgroundJobClient.Enqueue<ISendMailJob>(job => job.SendMail(new MailRequest()
            {
                Body = "Hesabınız tekrardan aktifleştirildi. İyi alışverişler dileriz.",
                Subject = "Hesabınız Aktifleştirildi - Car Parts Marketplace",
                ToEmail = email
            }));
        }
    }
}
