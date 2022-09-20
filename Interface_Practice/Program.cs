// See https://aka.ms/new-console-template for more information
using Interface_Practice;
Console.WriteLine("Hello, World!");

Console.WriteLine("enter x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter y");
int y = Convert.ToInt32(Console.ReadLine());

//Iadd a1 = new abcd();

int c = a1.add(x, y);
Console.WriteLine(c);
int d = a1.sub(x, y);
Console.WriteLine(d);


((Iadd)a1).add(x, y);

((Isub)a1).sub(x, y);