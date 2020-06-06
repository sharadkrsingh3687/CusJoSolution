using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CubJo.WebAPIPortal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UnsubscribeController : ControllerBase
    {
        
        private readonly ILogger<UnsubscribeController> _logger;

        public UnsubscribeController(ILogger<UnsubscribeController> logger)
        {
            _logger = logger;
        }

    }
}
