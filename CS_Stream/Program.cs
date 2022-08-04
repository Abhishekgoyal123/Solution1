using CS_Stream;


Console.WriteLine("USing Stream");
FileStreamOperation operation = new FileStreamOperation();
try
{

    // operation.CreateFile();

    // operation.WriteFile("I am from Stream");
    string str = operation.ReadFile();

   // Console.WriteLine(str);

    string str1 = operation.ReadByLine();

    Console.WriteLine(str1);

    Console.WriteLine("Enter starting index");
    int start = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter end index");
    int count = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    operation.Dispose();
}
Console.ReadLine();