using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeaturesDemo
{
    class Names
    {

        string[] listOfNames = new string[10];
        public Names()
        {
            for (int i = 0; i < 10; i++)
            {
                listOfNames[i] = "No Name";

            }
        }

        //Indexer is written with the name "this" to a property


       

        public string this[int index]
        {
            get { return listOfNames[index]; }
            set { listOfNames[index] = value; }
        }


    }
    internal class IndexerDemo
    {
        static void Main(string[] args)
        {
            Names n=new Names();
            n[0] = "Jack";
            n[1] = "Jim";
            n[2] = "Ana";

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(n[i]);
            }
        }
    }
}
