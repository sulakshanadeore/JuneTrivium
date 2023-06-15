using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsLibrary;

namespace SecondApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Subjects subject = new Subjects();
            //Console.WriteLine("------------------------");
            //subject.AddNewSubject("Maths", "SRN", "Beginners Maths");
            //subject.DisplaySubjectDetails();

            //Console.WriteLine("Subject 1 obejct");
            //Subjects s1 = new Subjects("physics", 1, "Lets learn physics", "Pune");
            //s1.DisplaySubjectDetails();


            //Console.WriteLine("Subject 2 obejct");
            //Subjects s2 = new Subjects(s1);
            //s2.DisplaySubjectDetails();

            //Books b = new Books();
            //Console.WriteLine("Enter bookid");
            //b.BookID=Convert.ToInt32(Console.ReadLine());
            
            //Console.WriteLine("Enter bookname");
            //b.BookName = Console.ReadLine();//setter
            
            //Console.WriteLine("Enter Book Price");
            //b.BookPrice = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Display Details: ");
            //Console.WriteLine(b.BookName);//getter
            //Console.WriteLine(b.BookID  );
            //Console.WriteLine( b.BookPrice);


            //User user = new User();
            //Console.WriteLine("Enter userid");
            //user.userid = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Forgot Pasword?");
            //bool ans=Convert.ToBoolean(Console.ReadLine());
            //if (ans)
            //{
            //    Console.WriteLine("your password " + user.ShowPwd);
            //}
            //else
            //{ 
            //Console.WriteLine("Enter pwd");
            //user.Password = Console.ReadLine();
            //}

            //Developer developer = new Developer();
            //developer.BasicSal = 10000;
            //double sal=developer.CalculateSalary();
            //Console.WriteLine(sal);



            GoldCustomer gold=new GoldCustomer();
            int ans=gold.Add(12, 20);
            Console.WriteLine(  ans);
             ans = gold.Add(12, 20,21);
            Console.WriteLine($"Answer= {ans}");
            
            int a=gold.CalculateRemainder(10, 3);
            Console.WriteLine("Remainder =" + a);
            float powerAns=gold.CalculatePower(10, 3);
            Console.WriteLine("Power " + powerAns);



            Console.ReadLine();
        }
    }
}
