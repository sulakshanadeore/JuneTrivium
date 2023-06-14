using System;
using System.Configuration;

namespace firstConsoleApp//Assembly name
{
    internal class Program
    {
        /// <summary>
        /// Entry point of my program where i,j and k variables are declared and printed
        /// </summary>
        /// <param name="args"></param>
        /// 
        //static int cnt = 1;
             
        static void Main(string[] args)
        {

            //int c = 1;
            
            //char c2;
            //DateTime dt;
            //string s;

            //Console.WriteLine($"VAlue of C={c}");

            //Console.WriteLine($"Value of cnt={cnt}");
            //cnt = cnt + 1;
            //c = c + 1;
            //Console.WriteLine($"VAlue of C={c}");
            //Console.WriteLine($"Value of cnt={cnt}");
            //Program p=new Program();
            //p.M1();

            //Int32 i=10,j=100;
            //int k = 90;
            //Console.WriteLine("Hello world");
            //Console.WriteLine(i);

            ////Ctrl  K +C -----> Comment
            ////Ctrl  K +U------> Uncomment
            //Console.WriteLine(j);
            //Console.WriteLine(k);
            //const Single pi = 3.14f;
            //Console.WriteLine(pi);
            //char c = 'A';
            //Console.WriteLine(c);
            //string name = "Kamini";
            //Console.WriteLine(name);
            //DateTime dt= DateTime.Now;
            //Console.WriteLine(dt);

            AcceptAndDoOperation();
            
            int multans=MultiplyNos();
            Console.WriteLine(multans);

            int a;
            //SubtractNos(out int myans);
            //Console.WriteLine(myans);
            SubtractNos(out a);
            Console.WriteLine(a);


            StringOperations("helloWORLD", out string upStr, out string lowStr, out int len);


            Console.Read();//ReaLine() /ReadKey() 
        }




        public static void StringOperations(string s1,out string UpperStr,out string lowerStr,out int stringLen)
        {
            UpperStr = s1.ToUpper();
            lowerStr= s1.ToLower();
            stringLen= s1.Length;
        
        }



        public static int MultiplyNos()
        {
            int ans;
            Console.WriteLine("Enter the value for  a no2");
            int no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value for  a no2");
            int no2 = Convert.ToInt32(Console.ReadLine());
            ans = no1 * no2;
            return ans;

        }


        //output will be in variable ans(so out keyword, out type of variable)
        public static void SubtractNos(out int ans)
        {
            Console.WriteLine("Enter the value for  a no2");
            int no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value for  a no2");
            int no2 = Convert.ToInt32(Console.ReadLine());
            ans = no1 - no2;
            




        }




        //private void M1()
        //{
        //    cnt = cnt + 1;
        //    Console.WriteLine($"Value of cnt={cnt}");

        //}






        private static void AcceptAndDoOperation()
        {
            
            //cnt = cnt + 1;
            //Console.WriteLine($"Value of cnt={cnt}");

            int no1, no2;
            Console.WriteLine("Enter the value for  a no1");
            string no3 = Console.ReadLine();
            //no1 = Convert.ToInt32(Console.ReadLine());//string
            bool success = int.TryParse(no3, out no1);
            Console.WriteLine(  no1);
            Console.WriteLine(  success);

            //Console.WriteLine("Enter the value for  a no2");
            //no2 = Convert.ToInt32(Console.ReadLine());//string
            //int ans = no1 + no2;
            //Console.WriteLine("Answer =" + ans);//concatenation
            //Console.WriteLine($"Answer of {no1} + {no2}={ans}");//Interpolation
            //Console.WriteLine(ans);
        }
    }
}
