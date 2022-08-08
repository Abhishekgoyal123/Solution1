// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] arr = {1,2,3,4,5,6,7,8,9};

var abc = from a in arr
          where a %2 ==0
          select a;

foreach(var a in abc)
{
    Console.WriteLine(a);
}