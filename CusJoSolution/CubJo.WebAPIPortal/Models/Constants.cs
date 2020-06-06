using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CubJo.WebAPIPortal.Models
{
    public static class Constants
    {
        public enum EmailType
        {
            ReminderMail = 0,
            UnscribeMail = 1,
            ThanksMail = 2
        }
    }
}
