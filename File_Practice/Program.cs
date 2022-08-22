// See https://aka.ms/new-console-template for more information
using File_Practice;
Console.WriteLine("Hello, World!");

Console.WriteLine("enter file name");
string str = Console.ReadLine();

FileOperation fo = new FileOperation();

fo.CreateFile(str);


Console.WriteLine("enter content");
string content = Console.ReadLine();


fo.WriteFile(str, content);

 fo.ReadFile(str);
//Console.WriteLine(a);

Console.ReadLine();