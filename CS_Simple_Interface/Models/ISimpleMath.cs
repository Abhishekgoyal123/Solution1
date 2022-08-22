using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Simple_Interface.Models
{
    private interface ISimpleMath
    {
       int add (int x, int y);
        int sub(int x, int y);

        int add1(int a, int b)
        {
            int c = a + b;
            return c;
        }

        //int q = 2;
    }
}
