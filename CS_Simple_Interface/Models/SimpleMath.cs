using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Simple_Interface.Models
{
    
        public class SimpleMath : ISimpleMath
        {
            public int add(int x, int y)
            {
                return x + y;
            }
            public int sub(int x, int y)
            {
                return x - y;
            }

        int add1(int a, int b)
        {
            int c = a + b;
            return c;
        }
    }
    }

