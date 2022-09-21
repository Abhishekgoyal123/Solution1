using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_Practice;

namespace Interface_Practice
{
     
    public abstract class abcd
    {
       public int add(int a, int b)
        {
            //Console.WriteLine(a+b);
           return a * b;
        }

        public int sub(int a, int b)
        {
            //Console.WriteLine(a+b);
            return a - b;
        }
    }
    
}
