using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    public class EmployeeArrayDemo
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[5];

            employees[0]=new Employee();
            employees[0].Empid = 1;
            employees[0].EmpName = "Mina";
            employees[0].EmpCity = "Hyderabad";
            employees[0].BasicSal = 10000;



            employees[1]=new Employee();

            employees[2]=new Employee();

            employees[3]=new Employee();

            employees[4]=new Employee();


            foreach (var e in employees) 
            {
                Console.WriteLine(e.Empid);
                Console.WriteLine(e.EmpName);
                Console.WriteLine(e.EmpCity);
                Console.WriteLine(e.BasicSal);
            }

        }
    }
}
