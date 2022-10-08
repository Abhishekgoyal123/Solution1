using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Assignment_29_09
{
    public class Banking
    {

         public ConcurrentBag<Account> bag1 = new ConcurrentBag<Account>();
        public void CreateAccount(Account acc)
        {
            Console.WriteLine("enter account name");
            string account_name = Console.ReadLine();
            account_name = acc.AccountName;

            Console.WriteLine("enter opening balance");
            int opening_balance = Convert.ToInt32(Console.ReadLine());
            opening_balance = acc.Openingbalance;
        }

        public void data()
        {
            Account a1 = new Account() { AccountNo = 1, AccountName = "Acc_1", Openingbalance = 0, NetBalance = 0 };
            bag1.Add(a1);
        }
        
        
    }
        public class AccountBag : ConcurrentBag<Account>
        {
                public AccountBag()
            {
                    Add(new Account { AccountNo = 1, AccountName = "Acc_1" , Openingbalance = 0, NetBalance=0});
                    Add(new Account { AccountNo = 2, AccountName = "Acc_2", Openingbalance = 0, NetBalance = 0 });
                    Add(new Account { AccountNo = 3, AccountName = "Acc_3", Openingbalance = 0, NetBalance = 0 });
                    Add(new Account { AccountNo = 4, AccountName = "Acc_4", Openingbalance = 0, NetBalance = 0 });
                    Add(new Account { AccountNo = 5, AccountName = "Acc_5", Openingbalance = 0, NetBalance = 0 });
                    Add(new Account { AccountNo = 6, AccountName = "Acc_6", Openingbalance = 0, NetBalance = 0 });
                    Add(new Account { AccountNo = 7, AccountName = "Acc_7", Openingbalance = 0, NetBalance = 0 });
                    Add(new Account { AccountNo = 8, AccountName = "Acc_8", Openingbalance = 0, NetBalance = 0 });
                    Add(new Account { AccountNo = 9, AccountName = "Acc_9", Openingbalance = 0, NetBalance = 0 });
                    Add(new Account { AccountNo = 10, AccountName = "Acc_10", Openingbalance = 0, NetBalance = 0 });

        }
        }
    
}
