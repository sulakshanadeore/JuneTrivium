using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeaturesDemo
{
    internal class CancellationDemo
    {
        static void Main(string[] args)
        {
            var source=new CancellationTokenSource();
            var token=source.Token;

            var task = Task.Run(() => CancelMethod(token), token);
            Thread.Sleep(500);
            Console.WriteLine("Main: cancel");
            source.Cancel();
            Thread.Sleep(500);
            Console.Read();

        }

        static void CancelMethod(CancellationToken token) { 
        for (int i = 0; i < 10; i++) {

                Thread.Sleep(100);
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("M1 cancelled...");
                    return;
                }
                Console.WriteLine("M1 is running...");
            }
        
        }
    }
}
