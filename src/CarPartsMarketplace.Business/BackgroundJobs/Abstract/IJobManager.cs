using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Entities.Dtos;
using Microsoft.AspNetCore.Http;

namespace CarPartsMarketplace.Business.BackgroundJobs.Abstract
{
    public interface IJobManager
    {
        Task RegisterUserWelcomeMailJobAsync(RegisterUserWelcomeMailJobDto jobDto,HostString host);
        Task AccountLocoutInformaitonMailJob(string email);
        Task AccountActivationMailJob(string email);

    }
}
