using Hangfire;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangFire
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage(ConfigurationManager.ConnectionStrings["HangFireConnectionString"].ConnectionString);

            using (var server = new BackgroundJobServer())
            {
                Console.WriteLine("Hangfire Server started. Press any key to exit...");

                BackgroundJob.Enqueue(() => Console.WriteLine("Hello, world!"));

                BackgroundJob.Enqueue<JobService>(job => job.SumJob(1, 1));

                Console.ReadKey();
            }
        }
    }
}
