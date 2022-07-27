using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QNA
{
    public class Abs2
    {
        int a;
        int b;
        int c;
        public virtual int Add(int a, int b)
        {
            c = a + b;
            return c;
        }

        public abstract int Sub();
    }

    public class result : Abs2
    {
        protected override int Add(int a, int b)
        {
           int  c = a + b;
            return c;
        }
    }
}
