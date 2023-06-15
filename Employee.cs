using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    public class Employee
    {

        public Employee()
        {
            Console.WriteLine("I am a Employee");
        }

        public int Empid { get; set; }

        public string EmpName { get; set; }
        public string EmpCity { get; set; }

        public int BasicSal { get; set; }
        public  virtual double CalculateSalary()
        {
            return BasicSal;
        
        }

        public void AddNewEmployee(string name,string city)
        {
            Console.WriteLine("Employee added using name and city");
        }

        public void AddNewEmployee(string name, int exp)
        {
            Console.WriteLine("Employee added using name and experience");

        }

        public void AddNewEmployee(int exp,string name)
        {
            Console.WriteLine("Employee added using name and experience");

        }
        public void AddNewEmployee(string name)
        {
            Console.WriteLine("Employee added using name");
        }
        public float AddNewEmployee(int exp)
        {
            float sal = 10000;
            Console.WriteLine("Employee added using experience and returning his current salary");
            return sal;

        }






    }

    public class Developer:Employee
        {
        public Developer()
        {
            Console.WriteLine("I am a Developer");
        }
        public string StackName { get; set; }
        public int ExperienceInYears { get; set; }

        public sealed override double CalculateSalary()
        {
            return base.CalculateSalary() + 1000;
        }

    }
    public class Admin : Developer
    {
        public Admin()
        {
            Console.WriteLine("I am a Admin");
        }

        public new double CalculateSalary()
        {
            return 0;
        
        }

        public string AdminName { get; set; }
        public string  Password { get; set; }

    }



}
