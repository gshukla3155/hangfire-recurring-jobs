using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangfire.Service.Services
{
    public class DailyFeedback
    {
        [Queue("feedback")]
        public void Send()
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("DailyFeedback.Send method called");
            Console.WriteLine("Feedback sent");
            Console.WriteLine("**********************************************");
        }
    }
}
