using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Practice
{
    public delegate void abc(int a, int b);

    class abc123
    {
        public static void Main()
        {

            void add(int a, int b)
            {
                Console.WriteLine(a + b);
            }

            abc a1 = new abc(add);
        }

    }
    
}

    

    public delegate void d1(int a, int b);
    public class DelegatePractice
    {
        // public static void Main()
        //{

        public void add(int a, int b)
        {
            Console.WriteLine($"result = {a + b}");
            //return a;
        }
        static void sub(int a, int b)
        {
            Console.WriteLine($" the Substraction is {a - b}");
        }
        // }

    }

}
