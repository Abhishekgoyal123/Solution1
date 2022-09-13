using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice
{
     interface Iadd
    {
       public int add(int x, int y)
        {
            return x + y;
        }
    }

   
    public interface Isub
    {
        public int sub(int x, int y);
    }


}
