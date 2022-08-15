﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities.Dtos
{
    public class UserEmailConfirmationDto:IDto
    {
        public string EmailHash { get; set; }
        public string Email { get; set; }
    }
}
