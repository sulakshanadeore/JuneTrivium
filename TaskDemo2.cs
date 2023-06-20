using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeaturesDemo
{
    internal class TaskDemo2
    {
        static void Main(string[] args)
        {

            // Task t = new Task(new Action(PrintMessage));
            //Task t = new Task(() => PrintMessage());
            //t.Start();

            //Task t = DoTask();
            //Call task.run, invoke m1 then invoke m2, finally wait for m2 to finish and terminate the program
            Task.Run(()=>M1()).ContinueWith(task=>M2()).Wait();


            
            Console.Read();
        }

        static void M1()
        {
            Console.WriteLine("M1 called");
        }
        static void M2() { Console.WriteLine("M2 called"); }


     static   async Task DoTask()
        { 
        int res=await Task.FromResult<int>(DoAddition(10,20));
            Console.Write(res);
        }

     static   int DoAddition(int i, int j)
        {
           return i + j;
        }

       static void PrintMessage()
        {
            Console.WriteLine("Welcome to TPL");
        }
    }
}
