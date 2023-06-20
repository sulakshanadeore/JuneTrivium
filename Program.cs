using FeaturesDemo;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Employee emp = new Employee() {Empid=1,Empname="Sakshi" };
        //emp.AddEmployeeDetails(name: "Pradnya", empid: 34, Mobile: "24242423423",isIntern:true);

        //int a=20,b=30;
        //Result(a, b, out int _, out int _);
        ////Console.WriteLine(mult);

        //Console.WriteLine(  "---------------");
        //PrintObject( emp );
        //Product p1 = new Product() {Proid=45,Prodname="Laptop",Price=60000 };
        //PrintObject( p1 );
        //Customer c1 = new Customer() {Custid=111,Name="sfsf" };
        //PrintObject ( c1 ); 

        //var bigvalue = 244242421142141;
        //var valueSplit = 244_242421_1421_41;
        //Console.WriteLine($"0:{bigvalue}:,1:{valueSplit}");


        Tuple<int, string, string> personData = new Tuple<int, string, string>(1, "Jack", "Jim");
        var p = Tuple.Create(1, "Harish", "MJ", "Pune", "MH", "India", 111111, "Hello");

        Console.WriteLine(personData.Item1);
        Console.WriteLine(personData.Item2);
        Console.WriteLine(personData.Item3);
        Console.WriteLine("-----------");


        Console.WriteLine(p.Item1);
        Console.WriteLine(p.Item2);
        Console.WriteLine(p.Item3);
        Console.WriteLine(p.Item4);
        Console.WriteLine(p.Item5);
        Console.WriteLine(p.Item6);
        Console.WriteLine(p.Item7);
        Console.WriteLine(p.Rest);
        Console.WriteLine(p.Rest.Item1);


        var d1 = Tuple.Create(1, 2, Tuple.Create(3, 4, 5, 6, 7, 8), 9, 10, 11, 12, 13);
        Console.WriteLine(d1.Item1);//1
        Console.WriteLine(d1.Item2);//2
        Console.WriteLine(d1.Item3); //3, 4, 5, 6, 7, 8
        Console.WriteLine(d1.Item3.Item1); //3
        Console.WriteLine(d1.Item4); //9
        Console.WriteLine(d1.Rest.Item1); //13









    }


    static void PrintObject(dynamic obj)
    {
        //if (obj is Employee)
        //{
        //    var c = obj as Employee;
        //    Console.WriteLine($"Employee Details : {c.Empid} {c.Empname}");
        //}
        //else if (obj is Product)
        //{
        //    var p = obj as Product;
        //    Console.WriteLine($"{p.Proid} {p.Prodname} {p.Price}");
        //}
        //else
        //{
        //    Console.WriteLine("Unknown object");
        //}

        switch (obj)
        {
            case Employee c:
                    Console.WriteLine($"Employee Details : {c.Empid} {c.Empname}");
                break;
            case Product p:
                Console.WriteLine($"{p.Proid} {p.Prodname} {p.Price}");
                break;
            default:
                Console.WriteLine("Unknown object");
                break;
        }



    }
    static void Result(int i, int j, out int add, out int mult)
    {
        add = i + j;
        mult = i * j;
    
    }


}