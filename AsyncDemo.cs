using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FeaturesDemo
{
    internal class AsyncDemo
    {
        static async Task Main(string[] args)
        {
            Task<int> output1=LongRunning();
            Task<int> output2 = OneMoreLongRunning();
            Console.WriteLine("After both processes");
            int val = await output1;
            DisplayOutput(val);
            val = await output2;
            DisplayOutput(val);




            //   ShortRunning();
            // var val = await output;
            //Console.Write(val);
            Console.ReadLine();
        }

        public static async Task<int> LongRunning()
        {

            Console.WriteLine("Long running method started..");
           // System.Threading.Thread.Sleep(4000);
           await Task.Delay(4000);
            Console.WriteLine("Long running method completed");
            return 100;
        }


        static async Task<int> OneMoreLongRunning()
        {
            Console.WriteLine("Another Long Method started");
            await Task.Delay(4000);
            Console.WriteLine("Another Long Method completed");
            return 200;
        }


        static void DisplayOutput(int res)
        {

            Console.WriteLine(res);
        }

        public static   void ShortRunning()
        {
            Console.WriteLine("Short running started ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Short running completed");
        }

    }
}
