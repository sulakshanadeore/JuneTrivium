using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            

            Array a=Array.CreateInstance(typeof(int), 10);
            int[] valuesArray = (int[])a;
            valuesArray[0] = 1;
            valuesArray[1] = 2;
            valuesArray[2] = 3;
            valuesArray[3] = 4;
            valuesArray[4] = 5;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }


           foreach (var item in valuesArray)
            {
                Console.WriteLine(item);
            }


            int[] arr2 = new int[10] { 100, 3452, 12, 35, 67, 81, 1, 23, 4, 89 };

            Array.Sort(arr2);
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
            //Array.Reverse(arr2);
            //Console.WriteLine("Printing reverse sorted Array");
            //foreach (var item in arr2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-------------");
            //Array.Clear(arr2,0,arr2.Length);
            //Console.WriteLine("Printing cleared  Array");
            //foreach (var item in arr2)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("--------------------------");
            int ind=Array.BinarySearch(arr2,100);
            Console.WriteLine( ind);
            Array.Copy(arr2, valuesArray, 10);
            Console.WriteLine("After copy");
            foreach (var item in valuesArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
