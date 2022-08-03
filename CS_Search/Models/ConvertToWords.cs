using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Search.Models
{
    public class ConvertToWords
    {
        
            public string[] one = { "", "one ", "two ", "three ", "four ", "five ", "six ", "seven ", "eight ", "nine ", "ten ", "eleven ", "twelve ", "thirteen ", "fourteen ", "fifteen ", "sixteen ", "seventeen ", "eighteen", "nineteen" };

            
            public string[] ten = { "", "", "twenty ", "thirty ", "forty ", "fifty ", "sixty ", "seventy ", "eighty ", "ninety " };

           
            public string numToWords(int n, string s)
            {
                string str = String.Empty;

                
                if (n > 19)
                {
                    str = str + ten[n / 10] + one[n % 10];
                }
                else
                {
                    str = str + one[n];
                }

                
                if (n != 0)
                {
                    str = str + s;
                }

                return str;
            }

           
            public string convertToWords(decimal n)
            {

                
                string out1 = "";

               
                out1 = out1 + numToWords((int)((n / 100000) % 100),
                                   "lakh ");

               
                out1 = out1 + numToWords((int)((n / 1000) % 100),
                                   "thousand ");

                
                out1 = out1 + numToWords((int)((n / 100) % 10),
                                   "hundred ");

                if (n > 100 && n % 100 > 0)
                {
                    out1 = out1 + "and ";
                }

                
                out1 = out1 + numToWords((int)(n % 100), "");

                return out1;
            }

            


        }
    }
//}
