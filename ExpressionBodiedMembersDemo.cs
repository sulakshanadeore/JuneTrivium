using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FeaturesDemo
{

    class Subjects
    {
        int submarks;
        public Subjects(int sid,string sname,int marks)=>this.SubjectID = sid;
        
            
        

        //Read only
        //public int SubjectId => 100;
        //public string SubjectName => "Maths";


        //Read-Write
        int subid;
        public int SubjectID 
        {
            set => subid = value;
            get => subid;
        
        }

        string subname;
        public string SubjectName
        {
            set => subname = value;
            get => subname;

        }



    }

    internal class ExpressionBodiedMembersDemo
    {
        //Expression--Constructor,Properties and Methods. This uses Lambda
        static void Main(string[] args)
        {
            PrintData("Gauri", 23);
            Console.WriteLine("================");
            Subjects s = new Subjects();
            s.SubjectID = 101;
            s.SubjectName = "History";
            Console.WriteLine(s.SubjectID);
            Console.WriteLine(s.SubjectName);


            Console.ReadLine();
        }

        public static void PrintData(string name, int age) => 
            Console.WriteLine(name + " " + age);
    
        
    
    }
}
