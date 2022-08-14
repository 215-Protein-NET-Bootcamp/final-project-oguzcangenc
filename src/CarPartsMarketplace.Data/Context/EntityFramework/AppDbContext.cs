﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarPartsMarketplace.Data.Context.EntityFramework
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        DbSet<ApplicationUser> Users { get; set; }
        
    }
}
