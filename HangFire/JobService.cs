using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangFire
{
    public class JobService
    {
        public JobService()
        {

        }

        public void SumJob(int a, int b)
        {
            var result = Sum(a, b);
            Console.WriteLine("The Sum is {0}", result);
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
