using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_29_09
{
    public  class BankTransaction
    {
        public int Deposit(Account acc)
        {
            Console.WriteLine("enter amount to deposit");
            int deposit_amt = Convert.ToInt32(Console.ReadLine());

            acc.NetBalance = acc.NetBalance + deposit_amt;
            return acc.NetBalance;
        }

        public int WithDraw(Account acc)
        {
            Console.WriteLine("enter amount to deposit");
            int withdraw_amt = Convert.ToInt32(Console.ReadLine());

            acc.NetBalance = acc.NetBalance - withdraw_amt;
            return acc.NetBalance;
        }
    }
}
