using System;
using System.Threading.Tasks;
using Hangfire.Common;
using Microsoft.Owin;
using Owin;


namespace Hangfire.Service
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseHangfireDashboard();

            QueueRecurringJobs();
        }

        private void QueueRecurringJobs()
        {
            var allJobs = ScheduleJob.GetJobs();

            foreach (var jobToSchedule in allJobs)
            {
                var jobManager = new RecurringJobManager();
                var type = Type.GetType(jobToSchedule.Type);
                if (type != null)
                {
                    Job job = new Job(type, type.GetMethod(jobToSchedule.Method));
                    jobManager.AddOrUpdate(jobToSchedule.JobId, job, jobToSchedule.Cron, TimeZoneInfo.Local, jobToSchedule.Queue);
                }
            }
        }
    }
}
