using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Hangfire.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(config =>
            {
                config.Service<WorkerService>(service =>
                {
                    service.ConstructUsing(s => new WorkerService());
                    service.WhenStarted(s => s.Start());
                    service.WhenStopped(s => s.Stop());
                });

                config.RunAsLocalSystem();
                config.StartAutomatically();

                config.SetDescription("Hangfire Demo");
                config.SetDisplayName("Hangfire_Service");
                config.SetServiceName("Hangfire_Service");
            });
        }
    }
}
