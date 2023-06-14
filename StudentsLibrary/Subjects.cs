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
        int _specializationType;
        string _UnivName;

        static Subjects()
        {
            Console.WriteLine("Initialize");

        }
        //Default Constructor
        public Subjects() { }


      

        public Subjects(int spType,string UnivName):this(UnivName)
        {
           _specializationType = spType;   
        }
        public Subjects(string UnivName)
        {
            _UnivName   = UnivName;
        }


        public Subjects(string subname, int spType, string bname, string UnivName) : this(spType, UnivName)
        {
            _SubjectName = subname;
            _BookName = bname;
        }

        public Subjects(Subjects copy)
        {
            this._SubjectName = copy._SubjectName;
            this._BookName = copy._BookName;
            this._specializationType = copy._specializationType;
            this._UnivName = copy._UnivName;
        }





        public Subjects(string subname,string tname,string bname,int spType):this(subname,tname,bname)
        {
            
            _specializationType = spType;
        }
        public Subjects(string subname, string tname, string bname)
        {
            _SubjectName = subname;
            _TeacherName = tname;
            _BookName = bname;

        }










        public void DisplaySubjectDetails()
        {
            Console.WriteLine(_SubjectName);
           // Console.WriteLine(_TeacherName);
            Console.WriteLine(_specializationType);
            Console.WriteLine(_BookName);
            Console.WriteLine( _UnivName);

        }

        public void AddNewSubject(string subName, string staffName, string book)
        {
            _SubjectName = subName;
            _TeacherName = staffName;
            _BookName= book;
        
        }

    }
}
