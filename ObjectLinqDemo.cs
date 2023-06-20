using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace LinqDemo
{
    internal class ObjectLinqDemo
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[10] {3,32,12,78,2,90,87,56,44,0 };
            //2 ways
            //Query Syntax
            //Method Syntax

            //var evenNos = from a in arr
            //              where a % 2 == 0
            //              select a;
            //var greaterthan50=from a in arr
            //                  where a>50 || a<=100
            //                  orderby a
            //                  select a;
            //arr[9] = 100;

            //foreach (int i in greaterthan50)
            //{
            //    Console.WriteLine(i);

            //}
            //Console.WriteLine("--------------");
            //List<string> stringList = new List<string>() {
            //"Hello",
            //"World",
            //"Bye",
            //"GoodMorning",
            //"GoodDay"
                      
            //};

            //var result = from s in stringList
            //             where s.Contains("Hello")
            //             select s;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            List<Student> students = new List<Student>() {
            new Student{Studid=11,Name="Asha",Age=12,StudStd=10 },
            new Student {Studid=3,Name="Priya",Age=20,StudStd=9  },
            new Student {Studid=2,Name="Kajal",Age=12,StudStd=9  },
            new Student {Studid=4,Name="Nisha",Age=12 ,StudStd=10 },
            new Student{Studid=1,Name="Usha",Age=12,StudStd=10  }
            
            };
            //var data = from s in students
            //           select s;

            //var data = from s in students
            //           where s.Age == 12
            //           orderby s.Studid ascending, s.Name descending

            //           select new { s.Studid, s.Name };
            // select new {sname=s.Name,rollno=s.Studid };



            //foreach (var item in data)
            //{
            //    //Console.WriteLine($"{item.Studid} \t {item.Name} \t {item.Age}");
            //    // Console.WriteLine($"{item.rollno} \t {item.sname}"  );
            //    Console.WriteLine($"{item.Studid} \t {item.Name}");

            //    Console.WriteLine();
            //}


            var data = from s in students
                       group s by s.StudStd into StdData
                       select StdData;

            foreach (var item in data)
            {
                Console.WriteLine("standard " + item.Key);
                foreach (var studData in item)
                {

                    Console.WriteLine($"{studData.Studid} \t {studData.Name} \t {studData.Age}");
                }
            }      

            



            Console.ReadLine();
                
        }
    }
}
