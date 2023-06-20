using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeaturesDemo
{
    internal class LocalFunctionsDemo
    {
        static void Main(string[] args)
        {
            //Local functions are inner functions
            int a=100, b=200;
            int addNos = SumNos(a, b);
            Console.WriteLine(addNos);
            int MultNos = Multiply(a, b);
            Console.WriteLine(MultNos);



            int SumNos(int i,int j ) {
                return i + j;
            }

            int Multiply(int i, int j) { return i * j; }
        }
    }
}
