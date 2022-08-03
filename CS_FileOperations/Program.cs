// See https://aka.ms/new-console-template for more information
using System.IO;
using CS_FileOperations.Operations;

Console.WriteLine("Hello, World!");
try
{


    Console.WriteLine("enter file name ");
    string filename = Console.ReadLine();

    string path = $@"C:\StaffIncome";



    FileOperation operation = new FileOperation();

    operation.CreateFile(path, filename);

    //string[] data = new string[] { "a", "b" };

    //operation.WriteFileIncome(path, filename, data);

    var dataFromFile = operation.ReadFile(path, filename);

    Console.WriteLine($"Initial Data = " +
        $"{dataFromFile}");

    operation.AppendFile(path, filename, "THe Next Data for APpend");

    dataFromFile = operation.ReadFile(path, filename);

    Console.WriteLine($"Data After Append = " +
        $"{dataFromFile}");

    string src = $"{path} {filename}.txt";
    string decpath = $@"C:\CheckMoved\";

    string dec = $"{decpath} {filename}.txt";

    operation.MoveFile(path, filename, src, dec);

    operation.EncryptFile(decpath, filename);
    operation.DecryptFile(decpath, filename);
    operation.DeleteFile(decpath, filename);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}