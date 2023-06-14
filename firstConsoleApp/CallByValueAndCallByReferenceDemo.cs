using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstConsoleApp
{
    internal class CallByValueAndCallByReferenceDemo
    {
        //svm +tab twice
        static void Main(string[] args)
        {
            int i = 100,j=40;

            CallByValueMethod(i, j);//Values of the varibles
            Console.WriteLine("---------------------------");
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine("*****************************************************");
            CallByReferenceMethod(ref i,ref j);//Address of the varible is passed
            Console.WriteLine(i);
            Console.WriteLine(j);

            Console.ReadLine();
        }


        static void CallByValueMethod(int i, int j)
        {
            int swapvar;
            swapvar = i;
            i = j;
            j = swapvar;
            Console.WriteLine(i);
            Console.WriteLine(j);


        }



        static void CallByReferenceMethod(ref int i, ref int j)
        {
            int swapvar;
            swapvar = i;
            i = j;
            j = swapvar;
            Console.WriteLine(i);
            Console.WriteLine(j);


        }
    }
}
