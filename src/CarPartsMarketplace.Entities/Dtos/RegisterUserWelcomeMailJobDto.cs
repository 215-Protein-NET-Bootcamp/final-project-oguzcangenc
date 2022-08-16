using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities.Dtos
{
    public class RegisterUserWelcomeMailJobDto:IDto
    {
        public  string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }
}
