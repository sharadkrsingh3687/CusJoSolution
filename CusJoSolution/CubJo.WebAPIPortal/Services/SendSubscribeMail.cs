using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cronos;
using System.Threading;

using CubJo.WebAPIPortal.Repositories;


namespace CubJo.WebAPIPortal.Services
{
    public class SendSubscribeMail : JobHostService
    {
        private readonly ILogger<SendSubscribeMail> _logger;

        public SendSubscribeMail(IScheduleConfig<SendSubscribeMail> config, ILogger<SendSubscribeMail> logger)
            : base(config.CronExpression, config.TimeZoneInfo)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("SendSubscribeMail schduler starts.");
            return base.StartAsync(cancellationToken);
        }

        public override Task DoWork(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{DateTime.Now:hh:mm:ss} SendSubscribeMail is working.");
            return Task.CompletedTask;
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("SendSubScribeMail is stopping.");
            return base.StopAsync(cancellationToken);
        }
    }
}
