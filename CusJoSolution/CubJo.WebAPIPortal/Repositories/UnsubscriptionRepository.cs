using CubJo.WebAPIPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CubJo.WebAPIPortal.DataAccess;

namespace CubJo.WebAPIPortal.Repositories
{
    public class UnsubscriptionRepository : IUnsubscription
    {
        private SubscriptionDbContext subscriptionDbContext;
        private IList<EmailTemplate> emailTemplates;
        private IList<SubscriptionMail> subscriptionMails;
        public UnsubscriptionRepository(SubscriptionDbContext subscriptionDbContext)
        {
            this.subscriptionDbContext = subscriptionDbContext;
        }
        public bool SendMailToSubscribeUser(Constants.EmailType emailType)
        {

            return false;
        }

        private void GetSubscriptionMails()
        {
            this.subscriptionMails = (this.subscriptionDbContext.SubscriptionMails.Count() > 0 ) ?
                                                        this.subscriptionDbContext.SubscriptionMails.ToList(): null;
        }

        private void GetEmailTemplates()
        {
            this.emailTemplates = (this.subscriptionDbContext.EmailTemplates.Count() > 0) ? 
                                                   this.subscriptionDbContext.EmailTemplates.ToList(): null;
        }
    }
}
