

static  void m1()
{
    Console.WriteLine("async Task 1");
     
    Console.WriteLine("method 1");
}

static  void m2()
{
    Console.WriteLine("async Task 2");
    

    Console.WriteLine("method 2");
}

//var a=m3();
//var b=m4();

//Console.WriteLine(a.Result);
//Console.WriteLine(b.Result);

Parallel.Invoke(() => {
    m1();
    m2();


});


//class MyClass
//{


//    //static async Task<string> m3()
//    //{
//    //    Console.WriteLine("method 3");
//    //    return await Task.FromResult<string>("async method 3");
//    //}

//    //static async Task<string> m4()
//    //{
//    //    Console.WriteLine("method 4");
//    //    return await Task.FromResult<string>("async method 4");
//    //}
//    static async void m1()
//    {
//        Console.WriteLine("async Task 1");
//        await Task.Delay(500);

//        Console.WriteLine("method 1");
//    }

//    static async void m2()
//    {
//        Console.WriteLine("async Task 2");
//        await Task.Delay(1000);

//        Console.WriteLine("method 2");
//    } 
//}

