using Microsoft.Extensions.Hosting;
using Quartz.Spi;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Quartz
{
    public class QuartzHostedService : IHostedService
    {
        private readonly ISchedulerFactory SchedulerFactory;
        private readonly IJobFactory JobFactory;
        private readonly IEnumerable<JobSchedule> JobSchedules;

        public QuartzHostedService(ISchedulerFactory schedulerFactory, IJobFactory jobFactory, IEnumerable<JobSchedule> jobSchedules)
        {
            SchedulerFactory = schedulerFactory;
            JobFactory = jobFactory;
            JobSchedules = jobSchedules;
        }
        public IScheduler Scheduler { get; set; }
        public  async Task StartAsync(CancellationToken cancellationToken)
        {
            Scheduler = await SchedulerFactory.GetScheduler(cancellationToken);
            Scheduler.JobFactory = JobFactory;

            foreach (var jobSchedule in JobSchedules)
            {
                var job = CreateJob(jobSchedule);
                var trigger = CreateTrigger(jobSchedule);
                await Scheduler.ScheduleJob(job, trigger, cancellationToken);
            }
            await Scheduler.Start(cancellationToken);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await Scheduler?.Shutdown(cancellationToken);
        }
        private static IJobDetail CreateJob(JobSchedule schedule)
        {
            var jobType = schedule.JobType;
            return JobBuilder
              .Create(jobType)
              .WithIdentity(jobType.FullName)
              .WithDescription(jobType.Name)
              .Build();
        }
        private static ITrigger CreateTrigger(JobSchedule schedule)
        {
            return TriggerBuilder
              .Create().StartNow().WithSimpleSchedule (x=>x.WithIntervalInMinutes(1).RepeatForever())    
                     .Build();
        }
    }
}
