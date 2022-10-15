// See https://aka.ms/new-console-template for more information
using Thread_2;
//Console.WriteLine("Hello, World!");

//Class1 c1 = new Class1();

//Thread t1 = new Thread(new ThreadStart(() => { c1.abc(); }));
////t1.Start(2);
//string temp=string.Empty;
//Thread t2 = new Thread(new ParameterizedThreadStart(() => { c1.randomm(); }));


//t2.Start(65);



using System;
using System.Threading;

public class ExThread
{

    // Non-Static method
    public void mythread()
    {
        for (int x = 0; x < 4; x++)
        {
            Console.WriteLine(x);
            Thread.Sleep(100);
        }
    }

    // Non-Static method
    public void mythread1()
    {
        // Console.WriteLine("2nd thread is Working..");
        for (int y = 0; y < 4; y++)
        {

            Console.WriteLine("2nd thread is Working..");

        }
    }
}
// Driver Class
public class ThreadExample
{
    // Main method
    public static void Main()
    {
        // Creating instance for
        // mythread() method
        ExThread obj = new ExThread();

        // Creating and initializing threads 
        Thread thr1 = new Thread(new ThreadStart(obj.mythread));
        Thread thr2 = new Thread(new ThreadStart(obj.mythread1));
        thr1.Start();

        // Join thread
        
        thr2.Start();
        thr1.Join();

    }
}
