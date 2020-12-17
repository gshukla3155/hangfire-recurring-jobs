using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangfire.Service
{
    public class ScheduleJob
    {
        public static List<RecurringJob> GetJobs()
        {
            List<RecurringJob> recurringJobs = new List<RecurringJob>();

            /*https://crontab.guru/examples.html*/

            recurringJobs.Add(new RecurringJob
            {
                JobId = "daily_feedback",
                Enable = true,
                Method = "Send",
                Queue = "feedback",
                Type = "Hangfire.Service.Services.DailyFeedback,Hangfire.Service",
                Cron = "0 0 * * *"
            });

            recurringJobs.Add(new RecurringJob
            {
                JobId = "monthly_feedback",
                Enable = true,
                Method = "Send",
                Queue = "feedback",
                Type = "Hangfire.Service.Services.MonthlyFeedback,Hangfire.Service",
                Cron = "0 0 1 * *"
            });

            return recurringJobs;
        }
    }

    public class RecurringJob
    {
        public string JobId { get; set; }
        public string Type { get; set; }
        public string Method { get; set; }
        public bool Enable { get; set; }
        public string Queue { get; set; }
        public string Cron { get; set; }
    }
}
