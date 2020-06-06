using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubJo.WebAPIPortal.Models
{
    public class SubscriptionMail
    {
        public Guid Guid { get; set; }
        public string Message { get; set; }
        public bool IsSubscribe { get; set; }
        public string EmailAddress { get; set; }
        public int Attemped { get; set; }
        
    }
}
