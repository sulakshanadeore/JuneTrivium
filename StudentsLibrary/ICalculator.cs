using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary
{
     interface ICalculator
    {
        int Add(int x, int y);  
        int Add(int x,int y,int z);
        int subtract(int x,int y,int z);
        int subtact(int x, int y);
        int divide(int x, int y);
        int multiply(int x, int y);


    }


    interface IComplexCalculator
    {

        float CalculatePower(int b, int p);
        int CalculateRemainder(int b, int p);
    }

    //add
  public  class GoldCustomer : Maths,ICalculator,IComplexCalculator
    {
        public int Add(int x, int y)
        {
            
            //throw new NotImplementedException();
            return x + y;
        }

        public int Add(int x, int y, int z)
        {
            //throw new NotImplementedException();
            return x + y +z;
        }

        public float CalculatePower(int b, int p)
        {
            //throw new NotImplementedException();
            return (float)Math.Pow(b, p);
        }

        public int CalculateRemainder(int b, int p)
        {
            // throw new NotImplementedException();
            int res=0;
            int a1=Math.DivRem(b, p, out res);
            return res; 
        }

        public int divide(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int multiply(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int subtact(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int subtract(int x, int y, int z)
        {
            throw new NotImplementedException();
        }
    }

    //add and subtract
  public  class SilverCustomer : ICalculator
    {
        public int Add(int x, int y)
        {
            // throw new NotImplementedException();
            return x - y;
        }

        public int Add(int x, int y, int z)
        {
            throw new NotImplementedException();
        }

        public int divide(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int multiply(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int subtact(int x, int y)
        {
            // throw new NotImplementedException();
            return x - y;
        }

        public int subtract(int x, int y, int z)
        {
            throw new NotImplementedException();
        }
    }
    

}
