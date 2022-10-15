// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



await m1();
await m2();





static async Task m1()
{

    Console.WriteLine("method 1");

    await Task.Delay(500000);

    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
}

static async Task m2()
{

    Console.WriteLine("method 2");

    await Task.Delay(500);

    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
}

//static async Task<int> m3()
//{

//    Console.WriteLine("method 3");

//    await Task.Delay(1000);
//    return 10;
//}

//static async Task<int> m4()
//{
//    Console.WriteLine("method 4");

//    await Task.Delay(500);
//    return 10;
//}



Console.WriteLine("main thread");