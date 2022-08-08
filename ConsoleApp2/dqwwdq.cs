using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate int abc(int x, int y);

    public class pqr
    {
        static void Main()
        {
            //void add(int a, int b)
            //{
            //    Console.WriteLine((a+b));
            //}

            abc abcd = delegate (int a, int b) { return (a + b); };
            int a = abcd(100, 50);

            Console.WriteLine(a);
        }
    }
    
}
