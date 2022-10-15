// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void m1()
{
    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    Console.WriteLine("method 1");
}

static void m2()
{
    // a = 100;
    //Console.WriteLine(a);
   Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    Console.WriteLine("method 2");
}

//Parallel.Invoke(() =>
//{

//    m1();
//    m2();
//});

Parallel.Invoke(

    () => m1(),
    () => m2()

    ) ;

//Parallel.Invoke(m1, m2);

Console.WriteLine("fr");