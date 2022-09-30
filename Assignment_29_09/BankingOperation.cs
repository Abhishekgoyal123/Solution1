using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_29_09
{
    public class BankingOperation
    {
        Account acc = new Account();
        AccountBag ab = new AccountBag();
        BankTransaction bt = new BankTransaction();

        public void abcd()
        {
            Console.WriteLine("enter account number for which you want to do operaation");
            int acc_no = Convert.ToInt32(Console.ReadLine());
            foreach (var item in ab)
            {
                if(acc_no == item.AccountNo)
                {
                    Task t1 = Task.Factory.StartNew(() =>
                    {

                        int net_bal = bt.Deposit(acc);
                        Console.WriteLine($"amount after deposit = {net_bal}");

                        int net_bal1 = bt.WithDraw(acc);
                        Console.WriteLine($"amount after withdraw = {net_bal1}");

                    });
                    
                    Task t2 = Task.Factory.StartNew(() =>
                    {

                        int net_bal = bt.WithDraw(acc);
                        Console.WriteLine($"amount after withdraw = {net_bal}");
                    });

                    //Task.WaitAny(t2);

                }
              

               
            }

            //Parallel.Invoke(() =>
            //    {
            //        int net_bal = bt.Deposit(acc);
            //         Console.WriteLine($"amount after deposit = {net_bal}");

                    

            //    });

            //Parallel.Invoke(() =>
            //{
            //    int net_bal1 = bt.WithDraw(acc);
            //    Console.WriteLine($"amount after withdraw = {net_bal1}");

            //});

            Parallel.For(0, ab.Count, (i) => {
                int net_bal = bt.Deposit(acc);
                Console.WriteLine($"amount after deposit = {net_bal}");

                int net_bal1 = bt.WithDraw(acc);
                Console.WriteLine($"amount after withdraw = {net_bal1}");
            });
        }
    }


    }


   
