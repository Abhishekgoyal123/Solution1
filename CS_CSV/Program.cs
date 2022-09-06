// See https://aka.ms/new-console-template for more information
using CS_CSV;
using CS_CSV.Database;
using CS_CSV.Entities;
using CS_CSV.Models;



Console.WriteLine("Hello, World!");

FileStreamOperation operation = new FileStreamOperation();


StaffLogic logic = new DoctorLogic();


Doctor doc1 = new Doctor() { StaffId = 1, StaffName = "Divyansh", Email = "divyansh@Movie.com", ContactNo = 998899, Education = "M.B.B.S", DeptName = "Cancer", StaffCategory = "doctor", Location = "pune", Specilization = "cancer" };
logic.RegisterStaff(doc1);
Doctor doc2 = new Doctor() { StaffId = 2, StaffName = "omkar", Email = "omkar@Movie.com", ContactNo = 997799, Education = "B.A.M.S", DeptName = "Heart", StaffCategory = "doctor", Location = "mumbai", Specilization = "cancer" };
logic.RegisterStaff(doc2);
Doctor doc3 = new Doctor() { StaffId = 3, StaffName = "rahul", Email = "rahul@Movie.com", ContactNo = 996699, Education = "B.A.M.S", DeptName = "Heart", StaffCategory = "doctor", Location = "pune", Specilization = "cancer" };
logic.RegisterStaff(doc3);
Doctor doc4 = new Doctor() { StaffId = 4, StaffName = "vivek", Email = "vivek@Movie.com", ContactNo = 995599, Education = "B.H.M.S", DeptName = "Cancer", StaffCategory = "doctor", Location = "chennai", Specilization = "cancer" };
logic.RegisterStaff(doc4);
Doctor doc5 = new Doctor() { StaffId = 5, StaffName = "omkar", Email = "omkar@Movie.com", ContactNo = 994499, Education = "M.B.B.S", DeptName = "eye", StaffCategory = "doctor", Location = "pune", Specilization = "cancer" };
logic.RegisterStaff(doc5);
Doctor doc6 = new Doctor() { StaffId = 6, StaffName = "anurag", Email = "anurag@Movie.com", ContactNo = 993399, Education = "M.B.B.S", DeptName = "Cancer", StaffCategory = "doctor", Location = "mumbai", Specilization = "cancer" };
logic.RegisterStaff(doc6);
Doctor doc7 = new Doctor() { StaffId = 7, StaffName = "rohan", Email = "rohan@Movie.com", ContactNo = 992299, Education = "B.H.M.S", DeptName = "eye", StaffCategory = "doctor", Location = "chennai", Specilization = "cancer" };
logic.RegisterStaff(doc7);
Doctor doc8 = new Doctor() { StaffId = 8, StaffName = "sachin", Email = "sachin@Movie.com", ContactNo = 991199, Education = "ssc", DeptName = "dental", StaffCategory = "doctor", Location = "pune", Specilization = "cancer" };
logic.RegisterStaff(doc8);
Nurse n1 = new Nurse() { StaffId = 9, StaffName = "riya", Email = "riya@Movie.com", ContactNo = 9988919, DeptName = "Cancer", StaffCategory = "nurse", Location = "pune", Experience = 10, };
logic.RegisterStaff(n1);
Nurse n2 = new Nurse() { StaffId = 10, StaffName = "diya", Email = "diya@Movie.com", ContactNo = 9988929, DeptName = "Heart", StaffCategory = "nurse", Location = "mumbai", Experience = 10, };
logic.RegisterStaff(n2);
Nurse n3 = new Nurse() { StaffId = 11, StaffName = "deppika", Email = "deepika@Movie.com", ContactNo = 9988939, DeptName = "Heart", StaffCategory = "nurse", Location = "chennai", Experience = 10, };
logic.RegisterStaff(n3);
Nurse n4 = new Nurse() { StaffId = 12, StaffName = "shreya", Email = "shreya@Movie.com", ContactNo = 9988949, DeptName = "Cancer", StaffCategory = "nurse", Location = "pune", Experience = 10, };
logic.RegisterStaff(n4);
Nurse n5 = new Nurse() { StaffId = 13, StaffName = "deepa", Email = "deppa@Movie.com", ContactNo = 9988959,  DeptName = "eye", StaffCategory = "nurse", Location = "kanpur", Experience = 10, };
logic.RegisterStaff(n5);
Nurse n6 = new Nurse() { StaffId = 14, StaffName = "shradha", Email = "shradha@Movie.com", ContactNo = 9988969,DeptName = "dental", StaffCategory = "nurse", Location = "pune", Experience = 10, };
logic.RegisterStaff(n6);
Nurse n7 = new Nurse() { StaffId = 15, StaffName = "khushi", Email = "khushi@Movie.com", ContactNo = 9988799, DeptName = "dental", StaffCategory = "nurse", Location = "delhi", Experience = 10, };
logic.RegisterStaff(n7);
Nurse n8 = new Nurse() { StaffId = 16, StaffName = "sonal", Email = "sonal@Movie.com", ContactNo = 9988989, DeptName = "dental", StaffCategory = "nurse", Location = "pune", Experience = 10, };
logic.RegisterStaff(n8);

string[] abc = new string[] { /*$" ID,"Name", "Staff Email", "Dept Name", "Staff Category","Staff Education","Contact No", "Specialization" , "\n"+*/
 $"{doc1.StaffId}, {doc1.StaffName}, {doc1.Email}, {doc1.ContactNo}, {doc1.Education},{doc1.DeptName}, {doc1.StaffCategory},  {doc1.Specilization} ," +"\n"+
    $" { doc2.StaffId }, {doc2.StaffName}, {doc2.Email}, {doc2.ContactNo}, {doc2.Education},{doc2.DeptName},{doc2.StaffCategory},{doc2.Specilization} ," +"\n"+
    //$" { doc2.StaffId }, {doc2.StaffName}, {doc2.Email}, {doc2.ContactNo}, {doc1.Education},{doc3.DeptName},{doc2.StaffCategory},{doc2.Specilization} ," +"\n"+
    $" { doc3.StaffId }, {doc3.StaffName}, {doc3.Email}, {doc3.ContactNo}, {doc3.Education},{doc4.DeptName}, {doc3.StaffCategory}, {doc3.Specilization} ," +"\n" +
    $" { doc4.StaffId }, {doc4.StaffName}, {doc4.Email}, {doc4.ContactNo}, {doc4.Education},{doc5.DeptName},{doc4.StaffCategory}, {doc4.Specilization} ," +"\n" +
    $" { doc5.StaffId }, {doc5.StaffName}, {doc5.Email},{doc5.ContactNo},  {doc5.Education},{doc6.DeptName}, {doc5.StaffCategory}, {doc5.Specilization} ," +"\n"+
    $" { doc6.StaffId }, {doc6.StaffName}, {doc6.Email}, {doc6.ContactNo}, {doc6.Education},{doc7.DeptName},{doc6.StaffCategory},{doc6.Specilization} ," +"\n"+
    $" { doc7.StaffId }, {doc7.StaffName}, {doc7.Email}, {doc7.ContactNo}, {doc7.Education},{doc8.DeptName}, {doc7.StaffCategory},  {doc7.Specilization} ," +"\n"+
    $" { doc8.StaffId }, {doc8.StaffName}, {doc8.Email},{doc8.ContactNo},  {doc8.Education},{doc8.DeptName},{doc8.StaffCategory},{doc8.Specilization} ," +"\n" +
    $"{n1.StaffId}, {n1.StaffName}, {n1.Email}, {n1.ContactNo}, {""},{n1.DeptName}, {n1.StaffCategory}, {n1.Education}, {n1.Experience} ," +"\n"+
    $" { n2.StaffId }, {n2.StaffName}, {n2.Email}, {n2.ContactNo},{""}, {n2.DeptName},  {n2.StaffCategory}, {n2.Experience} ," +"\n"+
    $" { n3.StaffId }, {n3.StaffName}, {n3.Email}, {n3.ContactNo},{""}, {n3.DeptName}, {n3.StaffCategory}, {n3.Experience} ," +"\n" +
    $" { n4.StaffId }, {n4.StaffName}, {n4.Email},  {n4.ContactNo}, {""},{n4.DeptName}, {n4.StaffCategory},{n4.Experience} ," +"\n" +
    $" { n5.StaffId }, {n5.StaffName}, {n5.Email},  {n5.ContactNo},{""},{n5.DeptName}, {n5.StaffCategory}, {n5.Experience} ," +"\n"+
    $" { n6.StaffId }, {n6.StaffName}, {n6.Email},  {n6.ContactNo},{""},{n6.DeptName},  {n6.StaffCategory}, {n6.Experience} ," +"\n"+
    $" { n7.StaffId }, {n7.StaffName}, {n7.Email},  {n7.ContactNo},{""},{n7.DeptName},  {n7.StaffCategory}, {n7.Experience} ," +"\n"+
    $" { n8.StaffId }, {n8.StaffName}, {n8.Email},  {n8.ContactNo},{""},{n8.DeptName}, {n8.StaffCategory}, {n8.Experience} ," +"\n"};


try
{

    operation.CreateFile();

    operation.WriteFile(abc);

    Console.WriteLine("enter staff category to search");
    string category = Console.ReadLine();
    operation.ReadFileByCategory(category);

    Console.WriteLine("enter staff id to search");
    int id = Convert.ToInt32(Console.ReadLine());
    operation.ReadFileByID(id);

    operation.ChangeExt();


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