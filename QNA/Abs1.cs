using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QNA
{
    public abstract class Abs1
    {
        public int a;
        public int b;
        protected virtual int Add(int a, int b)
        {

            int c = a + b;
            return c;
        }

        protected abstract void Add1();
    }

    public class xyz : Abs1
    {
        protected override void Add1()
        {
            int x=a/b;
            return ;
        }
        protected override int Add(int a, int b)
        {

            int c = a + b;
            return c;
        }
    }
}
