using ClassLibrary1;
using System.Runtime.CompilerServices;



//1) Top class should be a static class and a NonGeneric class
//2) An extension method with same name and signature as an instance will not be called
//3) They cannot be used for overriding existing methods,
//4) It cannot work with properties,events  and fields
//5) Extension methods must be static
internal static class Program
{
    public static void MyExtensionMethod(this Class1 class1)
    {
        //Write a extension to my class functonality---Class1
        Console.WriteLine("This is a extended method");
    }
    public static int IntegerConversionFromString(this string s)
    { 
    return Int32.Parse(s);
    }


    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Class1 ob = new Class1();
        Console.WriteLine(ob.Display());
        Console.WriteLine(ob.Print());
        ob.MyExtensionMethod();


        string str = "1234788";
        int i=str.IntegerConversionFromString();
        Console.WriteLine(i);
        Console.ReadLine();
    }
}