using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubJo.WebAPIPortal.Models
{
    public class EmailTemplate
    {
        public int Id { get; set; }
        public string Subject { get; set; }

        public StringBuilder Body { get; set; }
        public string SmtpAddress { get; set; }

        public int Port { get; set; }

    }
}
