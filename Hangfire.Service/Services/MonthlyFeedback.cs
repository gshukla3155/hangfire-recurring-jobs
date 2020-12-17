using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangfire.Service.Services
{
    public class MonthlyFeedback
    {
        [Queue("feedback")]
        public void Send()
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("MonthlyFeedback.Send method called");
            Console.WriteLine("MonthlyFeedback sent");
            Console.WriteLine("**********************************************");
        }
    }
}
