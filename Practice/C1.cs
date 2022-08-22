using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class C1 
    {
       public int add(int a, int b)
        {
            return a+b;
        }
    }

    public class C2 : C1
    {

        public new int add (int a, int b)
        {
            return a * b;
        }
        public void sub(int a,int b)
        {
            Console.WriteLine(a-b);
        }
    }

   
}
