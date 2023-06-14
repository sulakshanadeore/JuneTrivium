using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary
{
    //Access Specifier used to give full access of the class to the app
    public class Subjects
    {

        string _SubjectName;
        string _TeacherName;
        string _BookName;

        public void DisplaySubjectDetails()
        {
            Console.WriteLine(_SubjectName);
            Console.WriteLine(_TeacherName);
            Console.WriteLine(_BookName);


        }

        public void AddNewSubject(string subName, string staffName, string book)
        {
            _SubjectName = subName;
            _TeacherName = staffName;
            _BookName= book;
        
        }

    }
}
