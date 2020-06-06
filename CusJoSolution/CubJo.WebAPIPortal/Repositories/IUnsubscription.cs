using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CubJo.WebAPIPortal.Models;

namespace CubJo.WebAPIPortal.Repositories
{
    interface IUnsubscription
    {
        bool SendMailToSubscribeUser(Constants.EmailType emailType);
    }
}
