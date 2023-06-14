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
           
            Subjects subject = new Subjects();
            Console.WriteLine("------------------------");
            subject.AddNewSubject("Maths", "SRN", "Beginners Maths");
            subject.DisplaySubjectDetails();

            Console.WriteLine("Subject 1 obejct");
            Subjects s1 = new Subjects("physics", 1, "Lets learn physics", "Pune");
            s1.DisplaySubjectDetails();


            Console.WriteLine("Subject 2 obejct");
            Subjects s2 = new Subjects(s1);
            s2.DisplaySubjectDetails();

            Console.ReadLine();
        }
    }
}
