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
            subject.AddNewSubject("Maths", "SRN", "Beginners Maths");
            subject.DisplaySubjectDetails();

            Console.ReadLine();
        }
    }
}
