// See https://aka.ms/new-console-template for more information
using CS_Diff;
Console.WriteLine("Hello, World!");

Difference abc = new Difference();

Console.WriteLine("enter start date");
DateTime startdate = DateTime.Parse(Console.ReadLine());

Console.WriteLine("enter end date");
DateTime enddate = DateTime.Parse(Console.ReadLine());

abc.GetDateDifference(startdate, enddate);

//Console.WriteLine(a);