//using System.Threading;
//abcd a = new abcd();
//Thread T1 = new Thread(new ParameterizedThreadStart(abcd.WriteFirst));

//T1.Start(11144444);

//Thread T2 = new Thread(new ParameterizedThreadStart(abcd.WriteSecond));

//T2.Start(111555555555);



//public class abcd{
//    static object locker = new object();
//    public static void WriteFirst(Object filename)
//    {
//        //static object locker = new object();
//        Monitor.Enter(locker);
//        using (StreamWriter sw = new StreamWriter($@"C:\Assignment\Threading\{filename}.txt"))
//        {
//            Console.WriteLine("first time");
//        }
//        Monitor.Exit(locker);
//    }

//   public static void WriteSecond(Object filename)
//    {
//        Monitor.Enter(locker);
//        using (StreamWriter sw = new StreamWriter($@"C:\Assignment\Threading\{filename}.txt"))
//        {
//            Console.WriteLine("second time");
//        }
//        Monitor.Exit(locker);
//    }
//}


Console.WriteLine("main thread");

Parallel.Invoke(() =>
{
    Console.WriteLine("parallel invoke");
});






