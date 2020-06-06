using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using CubJo.WebAPIPortal.Models;

namespace CubJo.WebAPIPortal.DataAccess
{
    public class SubscriptionDbContext : DbContext
    {
        public SubscriptionDbContext(DbContextOptions<SubscriptionDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<EmailTemplate> EmailTemplates { get; set; }
        public DbSet<SubscriptionMail> SubscriptionMails { get; set; }



    }
}
