// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


using CS_NewAssignment;
using System.Runtime.Serialization;
// Binary Formatter for Binary Serialization
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
//using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
Console.WriteLine("Hello, World!");

FileStreamOperation operation = new FileStreamOperation();




Doctor doc1 = new Doctor() { StaffId = 1, StaffName = "Divyansh", Email = "divyansh@Movie.com", ContactNo = 998899, Education = "M.B.B.S", DeptName = "Cancer", StaffCategory = "doctor", Location = "pune", Specilization = "cancer" };

Doctor doc2 = new Doctor() { StaffId = 2, StaffName = "omkar", Email = "omkar@Movie.com", ContactNo = 997799, Education = "B.A.M.S", DeptName = "Heart", StaffCategory = "doctor", Location = "mumbai", Specilization = "cancer" };
Doctor doc3 = new Doctor() { StaffId = 3, StaffName = "rahul", Email = "rahul@Movie.com", ContactNo = 996699, Education = "B.A.M.S", DeptName = "Heart", StaffCategory = "doctor", Location = "pune", Specilization = "cancer" };
JsonSerializerMethod(doc1);
JsonSerializerMethod(doc2);
JsonSerializerMethod(doc3);

static void JsonSerializerMethod(Staff doc)
{
  
   
 // string str= JsonSerializer.Serialize<Staff>(doc);
    
    //string abc = JsonConvert.DeserializeObject<Doctor>(doc);
   //Stream fs = new FileStream(@"C:\Assignment\NewFile1.txt", FileMode.Append);

    string out1 = @"C:\Assignment\MyFile1.txt";
    string out_1 = JsonConvert.SerializeObject(doc);

    using (StreamWriter sw = File.AppendText(out1))
    {
        sw.WriteLine(out_1);
    }
    // JsonSerializer.Serialize<Staff>(doc);
    
        // Release the Object

}


operation.ReadFileByID(2);

