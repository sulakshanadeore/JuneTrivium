using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class Student:IComparable<Student>
    {

        public int Age { get; set; }
        public string   Name { get; set; }
        public int Rollno { get; set; }

        public int CompareTo(Student other)
        {
            if (this.Rollno > other.Rollno) 
            {
                return 1;
                    }
            else if(this.Rollno < other.Rollno) { return -1; }
            else { return 0; }
        }
    }
}
