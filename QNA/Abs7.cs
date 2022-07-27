using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QNA
{
    public class Abs7
    {
        public Abs7()
        {
            Console.WriteLine("public constructor");
        }

        private Abs7()
        {
            Console.WriteLine("priavte constructor");
        }

        private Abs7(int a)
        {
            Console.WriteLine("private constructor");
        }

    }
}
