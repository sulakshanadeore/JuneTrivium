using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeaturesDemo
{
    internal class Employee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public void AddEmployeeDetails(int empid, string name, bool isIntern, string Mobile, string Deptname="IT")
        {
            Console.WriteLine(empid);
            Console.WriteLine(name);
            Console.WriteLine(isIntern);
            Console.WriteLine(Mobile);
            Console.WriteLine(Deptname);    

        }

    }

    internal class Customer
    {

        public int Custid { get; set; }
        public string Name { get; set; }
    }

    internal class Product
    {
        public int Proid { get; set; }
        public int Price { get; set; }
        public string Prodname { get; set; }
    }
}
