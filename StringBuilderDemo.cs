using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeaturesDemo
{
    internal class StringBuilderDemo
    {
        static void Main(string[] args)
        {
            //string is immutable, if u create a string object and modify it, it always creates a new object.
            string s = "Hello World";
            s += "Good morning";



            //StringBuilder is mutable, if u create stringbuilder object and perform any operations like append etc
            //it works with the same instance of the stringbuilder object created.

            StringBuilder sb=new StringBuilder();
            sb.Append("Hello World");
            sb.Append("Good day");

        }
    }
}
