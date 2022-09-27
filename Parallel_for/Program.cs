// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] array = new int[5];
//Console.WriteLine(array.Length);

Parallel.For(0, array.Length+1, (i) =>
{
    try
    {
        array[i] = i;
      
        Console.WriteLine($"Array element  at position {i}= {array[i]}");
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
});

