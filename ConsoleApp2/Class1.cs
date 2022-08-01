using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  public class abc
    {
        public (int, decimal, int ) add(int a, int b)
        {
            int c = a + b;
            int d = a / b;
            //return c = a + b;

            return (c, d,d);
        }

        static void main()
        {
            abc a = new abc();
            a.add(3, 4);
        }

        public int add1(int a, int b)
        {
            int c = a + b;
            int d = a / b;
            //return c = a + b;

            return (c, d);
        }


    }
}
