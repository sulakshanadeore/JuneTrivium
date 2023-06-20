using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeaturesDemo
{
    class Person
    {
        public string Name { get; set; }
        public DateOnly Birthdate { get; set; }


        //Deconstruct method can have overloads

        internal void Deconstruct(out string PersonName, out DateOnly PersonBirthDate)
        {
            PersonName = Name;
            PersonBirthDate= Birthdate;
        
        }
    }

    

    internal static class DeconstructionDemo
    {
        public  static void Deconstruct<T1, T2, T3>(this Tuple<T1, T2, T3> tuple, out string pid, out string pname, out int price)
        {
            pid = tuple.Item1.ToString();
            pname = tuple.Item2.ToString();
            price = Convert.ToInt32(tuple.Item3);

        }
        static void Main(string[] args)
        {
            var perObj = new Person() {Name="Paresh",Birthdate=new DateOnly(1988,03,09) };
            //setter block


            //getter 

            var (PersonName,PersonBirthDate) = perObj;
            Console.WriteLine($"Name: {PersonName} BirthDate: {PersonBirthDate}");


            //Working with Tuple Deconstruct

            Console.WriteLine("-------------");
            var tuple = Tuple.Create("1","Cadbury",10);
            var (pid, pname, price) = tuple;
            Console.WriteLine($"Productid: {pid} \n ProductName: {pname} \n ProductPrice:{price}");






            //var perName = perObj.Name;
            //var perBirthdate = perObj.Birthdate;
            //Console.WriteLine($"Name: {perName} BirthDate: {perBirthdate}");
            Console.Read();
                

        }
    }
}
