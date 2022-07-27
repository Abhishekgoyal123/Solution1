using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QNA
{
    public sealed class Abs8

    {
        int a;
        int b;
        public virtual int Add(int a,int b)
        {

            int c = a + b;
            return c;
        }

        public abstract void Add1();
    }

    public class abcd : Abs8
    {
        public override Add1(int a, int b)
        {
            int d = a * b;
            return d;

        }
    }

}

