using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangfire.Service
{
    public class WorkerService
    {
        private IDisposable _host;
        private BackgroundJobServer _server;
        public void Start()
        {
            ConfigureHangfire();
        }

        public void Stop()
        {
            _host.Dispose();
            _server.Dispose();
        }

        private void ConfigureHangfire()
        {
            try
            {
                GlobalConfiguration.Configuration.UseSqlServerStorage(ConfigurationManager.ConnectionStrings["HangfireConnection"].ConnectionString);

                BackgroundJobServerOptions options = new BackgroundJobServerOptions
                {
                    Queues = new string[] { "feedback" }
                };
                _server = new BackgroundJobServer(options);


                var startOptions = new StartOptions { Port = 8999 };
                _host = WebApp.Start<Startup>(startOptions);

                Console.WriteLine($"Hangfire dashboard is available on http://localhost:8999/hangfire");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
