using Cronos;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CubJo.WebAPIPortal.Services
{
    public abstract class JobHostService : IHostedService, IDisposable
    {
        private System.Timers.Timer _timer;
        private readonly CronExpression expression;
        private readonly TimeZoneInfo timeZoneInfo;

        protected JobHostService(string cronExpression, TimeZoneInfo timeZone)
        {
            this.expression = CronExpression.Parse(cronExpression);
            this.timeZoneInfo = timeZone;
           
        }

        public virtual async Task StartAsync(CancellationToken cancellationToken)
        {
            await ScheduleJob(cancellationToken);
        }

        protected virtual async Task ScheduleJob(CancellationToken cancellationToken)
        {
            var next = expression.GetNextOccurrence(DateTimeOffset.Now, timeZoneInfo);

            if(next.HasValue)
            {
                var delay = next.Value - DateTimeOffset.Now;
                _timer = new System.Timers.Timer(delay.TotalMilliseconds);

                _timer.Elapsed += async (sender, args) =>
                {
                    _timer.Dispose();
                    _timer = null;

                    if (!cancellationToken.IsCancellationRequested)
                    {
                        await DoWork(cancellationToken);
                    }

                    if (!cancellationToken.IsCancellationRequested)
                    {
                        await ScheduleJob(cancellationToken); // rescedule next
                    }

                };

                _timer.Start();
            }

            await Task.CompletedTask;
        }

        public virtual async Task DoWork(CancellationToken cancellationToken)
        {
            await Task.Delay(5000, cancellationToken);  // do the work
        }


        public virtual async Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Stop();
            await Task.CompletedTask;
        }

        public virtual void Dispose()
        {
            _timer?.Dispose();
        }

    }
}
