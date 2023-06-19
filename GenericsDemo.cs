using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{

    internal class GenericsDemo
    {
        static void Main(string[] args)
        {
            //WorkingWithListofIntegers();
            //Console.WriteLine("----------------------------------");

            List<Student> students = new List<Student>() {
            new Student() {Rollno=6,Name="Jack",Age=20},
            new Student(){Rollno=7,Name="Jim",Age=20}

            };
            Student s = new Student();
            s.Rollno = 1;
            s.Name = "Vidya";
            s.Age = 20;


            students.Add(s);
            students.Add(new Student() { Rollno=2,Name="Nikita",Age=21 });
            students.Add(new Student() { Rollno = 4, Name = "Nikita", Age = 22 });
            students.Add(new Student() { Rollno = 3, Name = "Kamal", Age = 19 });
            students.Add(new Student() { Rollno = 5, Name = "Sima", Age = 20 });



            foreach (var item in students)
            {
                Console.WriteLine(item.Rollno + " " + item.Name  + "   "+ item.Age);
            }

           //Student studfound =students.Find(s1 => s1.Name == "Sima");
           // if (studfound!=null)
           // {
           //     Console.WriteLine(studfound.Rollno);
           //     Console.WriteLine(studfound.Name);
           //     Console.WriteLine( studfound.Age);

           // }

           // Console.WriteLine("-------Age Output-----");


           // studfound =students.Find(a => a.Age == 20);
           // if (studfound != null)
           // {

           //     Console.WriteLine(studfound.Rollno);
           //     Console.WriteLine(studfound.Name);
           //     Console.WriteLine(studfound.Age);
           // }

           // List<Student> studlist=students.FindAll(a=>a.Age==20);
           // studlist.ForEach(s1 => 
           // { 
           //     Console.WriteLine("Student details are : ");
           //     Console.WriteLine(s1.Rollno + " " + s1.Name + " " + s1.Age);


           // }
           // );

            students.Sort();
            Console.WriteLine("After sorting on Rollno using IComparer ");
            foreach (var item in students)
            {
                Console.WriteLine(item.Rollno + " " + item.Name + "   " + item.Age);
            }


















            Console.ReadLine();
        }

        private static void WorkingWithListofIntegers()
        {
            int[] a1 = new int[5] { 10, 20, 30, 40, 50 };

            List<int> list_ints = new List<int>();
            list_ints.Add(1);
            list_ints.Add(100);
            list_ints.Add(3);
            list_ints.Add(3234);
            list_ints.Add(3332);
            list_ints.Add(5000);
            list_ints.AddRange(a1);
            list_ints.Insert(0, 5001);
            list_ints.InsertRange(1, a1);
            //1,10,20,30,40,50,100,3,3234,3332,124,10,20,30,40,50
            foreach (var item in list_ints)
            {
                Console.WriteLine(item);
            }
            //it takes one parameter only and returns bool--Predicate

            Console.WriteLine("Using find method");
            int j = 3332;
            int ans = list_ints.Find(i => i > j);
            Console.WriteLine(ans);
            Console.WriteLine("------------------------------");
            List<int> foundgreaterthan3332 = list_ints.FindAll(i => i > j);
            foreach (var item in foundgreaterthan3332)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------");
            //return type void--->upto 16 parameters
            list_ints.ForEach(i => Console.WriteLine(i));

            Console.WriteLine("------ nos from 10 to 124-------------------------");
            if (list_ints.Any(e => (e >= 5500 && e <= 6000)))
            {
                Console.WriteLine("yes there");

            }
            else
            {
                Console.WriteLine("not there");
            }


            Console.WriteLine(  "Sorted List");
            list_ints.Sort();
            foreach (var item in list_ints)
            {
                Console.WriteLine(item);
            }
        }
    }
}
