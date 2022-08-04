using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Extension
{
    
    public static class String_Ext
    {
        public static int WordCount(this string str)
        {

            int Wrd_count = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == ' ')
                    Wrd_count++;
            }
            return Wrd_count;
        }

        public static int StCount( this string str)
        {
            int St_count = 0;


            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == '.' && str[i + 1] == ' ')
                {
                    St_count++;
                }
            }
             
            return St_count;
        }

        public static int SpchCount( this string str)
        {
            int Spch_count = 0;
            for (int j = 0; j < str.Length; j++)
            {
                int ascii = Convert.ToInt32(str[j]);
                if ((ascii >= 33 && ascii <= 47) || (ascii >= 58 && ascii <= 64)
                                || (ascii >= 91 && ascii <= 96) || (ascii >= 123 && ascii <= 126))
                {
                    Spch_count++;
                }
            }
            return Spch_count;

        }

        public static string ConvertF ( this string str)
        {
            char[] ch = str.ToCharArray();
            ch[0] = char.ToUpper(ch[0]);
            for (int p = 0; p < ch.Length; p++)
            {
                if (ch[p] == ' ')
                {
                    ch[p + 1] = char.ToUpper(ch[p + 1]);
                }
            }

            str = new string(ch);
            return str;
        }
    }
    
}
