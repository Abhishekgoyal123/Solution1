// See https://aka.ms/new-console-template for more information

using CS_Serialization;
using System.Runtime.Serialization;
// Binary Formatter for Binary Serialization
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text.Json;
Console.WriteLine("Hello, World!");


JsonSerializerMethod();



static void JsonSerializerMethod()
{
Doctor doc = new Doctor();
    //Console.WriteLine("Enter ID of staff");
    //doc.StaffId = Convert.ToInt32(Console.ReadLine());



    //    Console.WriteLine("Enter Name of staff");
    //    doc.StaffName = Console.ReadLine();


    //    Console.WriteLine("Enter Email of staff");
    //    doc.Email = Console.ReadLine();
    //    Console.WriteLine("Enter Department of staff");
    //    doc.DeptName = Console.ReadLine();
    //    Console.WriteLine("Enter Gender of staff");
    //    doc.Gender = Console.ReadLine();
    //    Console.WriteLine("Enter Category of staff");
    //    doc.StaffCategory = Console.ReadLine();
    //    Console.WriteLine("Enter Education of staff");
    //    doc.Education = Console.ReadLine();
    //    Console.WriteLine("Enter contact number of staff");
    //    doc.ContactNo = Convert.ToInt32(Console.ReadLine());
    //    Console.WriteLine("Enter Specialization of staff");
    //    doc.Specilization = Console.ReadLine();

    Doctor doc1 = new Doctor() { StaffId = 1, StaffName = "Divyansh", Email = "divyansh@Movie.com", ContactNo = 998899, Education = "M.B.B.S", DeptName = "Cancer", StaffCategory = "doctor", Location = "pune", Specilization = "cancer" };
   // logic.RegisterStaff(doc1);
    Doctor doc2 = new Doctor() { StaffId = 2, StaffName = "omkar", Email = "omkar@Movie.com", ContactNo = 997799, Education = "B.A.M.S", DeptName = "Heart", StaffCategory = "doctor", Location = "mumbai", Specilization = "cancer" };
    //logic.RegisterStaff(doc2);




    Stream fs = new FileStream(@$"C:\Assignment\{doc.StaffId}.json", FileMode.CreateNew);
    JsonSerializer.Serialize(fs, doc);
    fs.Close(); // CLose the File
    fs.Dispose(); // Release the Object

}

DeSerializeMethod();
static void DeSerializeMethod()
{
    Console.WriteLine("Enter Staff Id for which you want to search the record");
    int id2 = Convert.ToInt32(Console.ReadLine());
    // JsonSerializer.Deserialize
   // BinaryFormatter binaryFormatter = new BinaryFormatter();
    // OPen a  File for Reading
    Stream fs = new FileStream(@$"C:\Assignment\{id2}.json", FileMode.Open);

    Staff emp = (Staff)JsonSerializer.Deserialize<Staff>(fs);

    

    Console.WriteLine($"EmpNo = {emp.StaffId} and EmpName = {emp.StaffName}");

    Console.WriteLine("The Object is DeSerialized");
    fs.Close(); // CLose the File
    fs.Dispose(); // Release the Object
}