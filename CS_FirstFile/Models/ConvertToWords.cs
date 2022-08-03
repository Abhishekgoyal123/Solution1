using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_FirstFile.Entities;
using CS_FirstFile.Models;
using CS_FirstFile.Logic;
namespace CS_FirstFile.Models
{
    public class ConvertToWords
    {
        //public class dqwwdq
        //{
            public string[] one = { "", "one ", "two ", "three ", "four ", "five ", "six ", "seven ", "eight ", "nine ", "ten ", "eleven ", "twelve ", "thirteen ", "fourteen ", "fifteen ", "sixteen ", "seventeen ", "eighteen", "nineteen" };

            // strings at index 0 and 1 are not used,
            // they is to make array indexing simple
            public string[] ten = { "", "", "twenty ", "thirty ", "forty ", "fifty ", "sixty ", "seventy ", "eighty ", "ninety " };

            // n is 1- or 2-digit number
            public string numToWords(int n, string s)
            {
                string str = String.Empty;

                // if n is more than 19, divide it
                if (n > 19)
                {
                    str = str + ten[n / 10] + one[n % 10];
                }
                else
                {
                    str = str + one[n];
                }

                // if n is non-zero
                if (n != 0)
                {
                    str = str + s;
                }

                return str;
            }

            // Function to print a given number in words
            public string convertToWords(decimal n)
            {

                // stores word representation of
                // given number n
                string out1 = "";

                // handles digits at ten millions and
                // hundred millions places (if any)
                //out1 = out1 + numToWords((int)(n / 10000000),
                //                   "crore ");

                // handles digits at hundred thousands
                // and one millions places (if any)
                out1 = out1 + numToWords((int)((n / 100000) % 100),
                                   "lakh ");

                // handles digits at thousands and tens
                // thousands places (if any)
                out1 = out1 + numToWords((int)((n / 1000) % 100),
                                   "thousand ");

                // handles digit at hundreds places (if any)
                out1 = out1 + numToWords((int)((n / 100) % 10),
                                   "hundred ");

                if (n > 100 && n % 100 > 0)
                {
                    out1 = out1 + "and ";
                }

                // handles digits at ones and tens
                // places (if any)
                out1 = out1 + numToWords((int)(n % 100), "");

                return out1;
            }

            // Driver code

            // long handles upto 9 digit no
            // change to unsigned long long int to
            // handle more digit number
            //long n = 2571643;

            //// convert given number in words
            //return (convertToWords(n));


        }
    }
//}
