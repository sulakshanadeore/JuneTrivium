using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  WorkingWithArrayList();
            //WorkingWithStack();//LIFO--->
            //workingWithQueue();//FIFO--->plants nursery

            //WorkingWithHashTable();
            //SortedList sortedList=new SortedList();
            
            //sortedList.Add(2, "Jack");
            //sortedList.Add(3, "Ana");
            //sortedList.Add(1, "One");
            //foreach (DictionaryEntry i in sortedList)
            //{
            //    Console.WriteLine(i.Key +  "  " + i.Value);

            //}
            


            Console.ReadLine();







        }

        private static void WorkingWithHashTable()
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "One");
            ht.Add(1, "One");
            ht.Add(2, 300);
            ht.Add(3, "Hello");

            ht.Remove("1");//remove on the basis of the key


            //foreach (DictionaryEntry item in ht)
            //{

            //    Console.WriteLine(item.Key + " " + item.Value);

            //}

            IDictionaryEnumerator ie = ht.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Key + "  " + ie.Value);
            }
        }

        private static void workingWithQueue()
        {
            Queue q = new Queue();//FIFO
            q.Enqueue(13);
            q.Enqueue("Hello");
            q.Enqueue('P');
            q.Enqueue(345.3f);
            object o1 = q.Dequeue();    //13
            Console.WriteLine($"Dequeued = {o1}");

            o1 = q.Peek();
            Console.WriteLine($"Peek  = {o1}");
        }

        private static void WorkingWithStack()
        {
            Stack s = new Stack();//lifo
            s.Push(23.33f);//object
            s.Push(2);
            s.Push("Jack");
            s.Push("Tina");
            s.Push("Mina");

            object o1 = s.Pop();
            Console.WriteLine("Popped out= " + o1);
            Console.WriteLine("Remaining elements");
            foreach (var i in s)
            {
                Console.WriteLine(i);

            }

            o1 = s.Peek();
            Console.WriteLine("Peek element = " + o1);

            bool isthere = s.Contains("JACK");
            Console.WriteLine(isthere + "Jack");
            int cnt = s.Count;
            Console.WriteLine($"Count={cnt}");
            object[] arr = new object[cnt];
            s.CopyTo(arr, 0);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        private static void WorkingWithArrayList()
        {
            //Any type of data(object)
            //dynamic in size
            int[] a1 = new int[5] { 10, 20, 30, 40, 50 };

            ArrayList a = new ArrayList(3);
            //Add/AddRange/Insert/InsertRange
            a.Add(1);
            a.Add(3.445f);
            a.Add(3234.3333d);
            a.Add("Rajesh");
            a.Add('A');
            a.AddRange(a1);
            a.Insert(0, 100);
            a.InsertRange(1, a1);

           
            //1,3.445,3234.3333,Rajesh,A,10,20,30,40,50
            //100,1,3.445,3234.3333,Rajesh,A,10,20,30,40,50
            //100,10,20,30,40,50,1,3.445,3234.3333,Rajesh,A,10,20,30,40,50


            foreach (var i in a)
            {
                Console.WriteLine(i);

            }
        }
    }
}
