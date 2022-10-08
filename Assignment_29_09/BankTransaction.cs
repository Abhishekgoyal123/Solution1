using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_29_09
{
    public  class BankTransaction
    {
        Random random = new Random();
        public void Deposit(Account acc)
        {
            
            
            int deposit_amt = random.Next(100, 200);

            acc.NetBalance = acc.NetBalance + deposit_amt;
            Console.WriteLine($"amount after deposit = {acc.NetBalance}");
        }

        public void WithDraw(Account acc)
        {
        
            int withdraw_amt =  random.Next(100, 200);

            acc.NetBalance = acc.NetBalance - withdraw_amt;
            Console.WriteLine($"amount after withdraw = {acc.NetBalance}");
           // return acc.NetBalance;
        }
    }
}
