using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeaturesDemo
{
    internal class TaskDemo1
    {
        static void Main(string[] args)
        {
            //Task of TPL(Task Parallel Library)---async-----await for result
            Task<string> t1 = Task.Run(() => { return "Hello"; });
            //string is result of the task
            //Task can be cancelled using cancellation token
            //task can have multiple processes happening at the same time, but a thread can have only one task running at a time

            Console.WriteLine(t1.Result);





        }
    }
}
