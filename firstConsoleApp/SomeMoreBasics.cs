using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstConsoleApp
{
    internal class SomeMoreBasics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your joining date");
           DateTime  dt =Convert.ToDateTime(Console.ReadLine());
            var yrsService= YearsOfService(dt);
            Console.WriteLine($"Congrats!! Working in the company for {yrsService} years");
            Console.WriteLine("You joined on " + dt.DayOfWeek);

            //Implictly typed variable
            var p = new DateTime(2023, 01, 12);
           //p = 13;

            dynamic d1= new DateTime(2023, 01, 12);
            d1 = "jack";

            
           d1= Acceptdata(12);
            Console.WriteLine(d1);
            d1 =Acceptdata("Tina");
            Console.WriteLine(d1);
            d1 =Acceptdata(new DateTime(2023, 01, 12));
            Console.WriteLine(d1);



            Console.ReadLine();

        }

        static dynamic Acceptdata(dynamic d2)
        {
            Console.WriteLine(d2);
            return d2;

        }

        static int YearsOfService(DateTime joiningdate)
        {
            int diff=DateTime.Now.Year - joiningdate.Year;
            return diff;

        }
    }
}
