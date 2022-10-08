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

            foreach (var item in ab)
            {

                //        Task t1 = Task.Factory.StartNew(() =>
                //        {
                //           Console.Write($"account number = {item.AccountNo}");
                //            bt.Deposit(acc);
                //           // Console.WriteLine($"amount after deposit = {net_bal}");



                //        });

                //    Task.WaitAll(t1);
                //    //Task.WaitAny(t1);

                //        Task t2 = Task.Factory.StartNew(() =>
                //        {
                //           Console.Write($"account number = {item.AccountNo}");
                //             bt.WithDraw(acc);
                //            //Console.WriteLine($"amount after withdraw = {net_bal}");
                //        });
                //    Task.WaitAll(t2);
                //Task.WaitAny(t2);
                // Task.WaitAny(t1,t2);
                //Task.WaitAll(t1, t2);







                Parallel.Invoke(() =>
                        {
                            bt.Deposit(acc);


                            bt.WithDraw(acc);





                        });

                //Parallel.Invoke(() =>
                //{
                //    int net_bal1 = bt.WithDraw(acc);
                //    Console.WriteLine($"amount after withdraw = {net_bal1}");

                //});

                //Parallel.For(0, ab.Count, (i) => {
                //    int net_bal = bt.Deposit(acc);
                //    Console.WriteLine($"amount after deposit = {net_bal}");

                //    int net_bal1 = bt.WithDraw(acc);
                //    Console.WriteLine($"amount after withdraw = {net_bal1}");
                //});
            }
        }


    }
}


   
