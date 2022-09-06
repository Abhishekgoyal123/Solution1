// See https://aka.ms/new-console-template for more information
using CS_New1;
using CS_New1.Database;
using CS_New1.Entities;
using CS_New1.Models;



Console.WriteLine("Hello, World!");

FileStreamOperation operation = new FileStreamOperation();


StaffLogic logic = new DoctorLogic();


//Doctor doc = new Doctor();

////string[] abc = new string[] { $"{doc.StaffId}" };
//Console.WriteLine("Enter ID of staff");
//doc.StaffId = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Name of staff");
//doc.StaffName = Console.ReadLine();
//Console.WriteLine("Enter Email of staff");
//doc.Email = Console.ReadLine();
//Console.WriteLine("Enter Department of staff");
//doc.DeptName = Console.ReadLine();
//Console.WriteLine("Enter Gender of staff");
//doc.Gender = Console.ReadLine();
//Console.WriteLine("Enter Category of staff");
//doc.StaffCategory = Console.ReadLine();
//Console.WriteLine("Enter Education of staff");
//doc.Education = Console.ReadLine();
//Console.WriteLine("Enter contact number of staff");
//doc.ContactNo = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Specialization of staff");
//doc.Specilization = Console.ReadLine();

//logic.RegisterStaff(doc);
//staffId++;
//Console.WriteLine("New Doctor Registered successfully");

List<Doctor> staffs = new List<Doctor>
{
new Doctor { StaffId = 1, StaffName = "Divyansh", Email = "divyansh@Movie.com", ContactNo = 998899, Education = "M.B.B.S", DeptName = "Cancer", StaffCategory = "doctor", Location = "pune", Specilization = "cancer" },
new Doctor { StaffId = 2, StaffName = "omkar", Email = "omkar@Movie.com", ContactNo = 997799, Education = "B.A.M.S", DeptName = "Heart", StaffCategory = "doctor", Location = "mumbai", Specilization = "cancer" },
new Doctor { StaffId = 3, StaffName = "rahul", Email = "rahul@Movie.com", ContactNo = 996699, Education = "B.A.M.S", DeptName = "Heart", StaffCategory = "doctor", Location = "pune", Specilization = "cancer" },
new Doctor { StaffId = 4, StaffName = "vivek", Email = "vivek@Movie.com", ContactNo = 995599, Education = "B.H.M.S", DeptName = "Cancer", StaffCategory = "doctor", Location = "chennai", Specilization = "cancer" },
new Doctor { StaffId = 5, StaffName = "omkar", Email = "omkar@Movie.com", ContactNo = 994499, Education = "M.B.B.S", DeptName = "eye", StaffCategory = "doctor", Location = "pune", Specilization = "cancer" },
new Doctor { StaffId = 6, StaffName = "anurag", Email = "anurag@Movie.com", ContactNo = 993399, Education = "M.B.B.S", DeptName = "Cancer", StaffCategory = "doctor", Location = "mumbai", Specilization = "cancer" },
new Doctor { StaffId = 7, StaffName = "rohan", Email = "rohan@Movie.com", ContactNo = 992299, Education = "B.H.M.S", DeptName = "eye", StaffCategory = "doctor", Location = "chennai", Specilization = "cancer" },
new Doctor { StaffId = 8, StaffName = "sachin", Email = "sachin@Movie.com", ContactNo = 991199, Education = "ssc", DeptName = "dental", StaffCategory = "doctor", Location = "pune", Specilization = "cancer" }
};

//Nurse n1 = new Nurse() { StaffId = 9, StaffName = "riya", Email = "riya@Movie.com", DeptName = "Cancer", ContactNo = 9988919, StaffCategory = "nurse", Location = "pune", Experience = 10, };
//logic.RegisterStaff(n1);
//Nurse n2 = new Nurse() { StaffId = 10, StaffName = "diya", Email = "diya@Movie.com", DeptName = "Heart", ContactNo = 9988929, StaffCategory = "nurse", Location = "mumbai", Experience = 10, };
//logic.RegisterStaff(n2);
//Nurse n3 = new Nurse() { StaffId = 11, StaffName = "deppika", Email = "deepika@Movie.com", DeptName = "Heart", ContactNo = 9988939, StaffCategory = "nurse", Location = "chennai", Experience = 10, };
//logic.RegisterStaff(n3);
//Nurse n4 = new Nurse() { StaffId = 12, StaffName = "shreya", Email = "shreya@Movie.com", DeptName = "Cancer", ContactNo = 9988949, StaffCategory = "nurse", Location = "pune", Experience = 10, };
//logic.RegisterStaff(n4);
//Nurse n5 = new Nurse() { StaffId = 13, StaffName = "deepa", Email = "deppa@Movie.com", DeptName = "eye", ContactNo = 9988959, StaffCategory = "nurse", Location = "kanpur", Experience = 10, };
//logic.RegisterStaff(n5);
//Nurse n6 = new Nurse() { StaffId = 14, StaffName = "shradha", Email = "shradha@Movie.com", DeptName = "dental", ContactNo = 9988969, StaffCategory = "nurse", Location = "pune", Experience = 10, };
//logic.RegisterStaff(n6);
//Nurse n7 = new Nurse() { StaffId = 15, StaffName = "khushi", Email = "khushi@Movie.com", DeptName = "dental", ContactNo = 9988799, StaffCategory = "nurse", Location = "delhi", Experience = 10, };
//logic.RegisterStaff(n7);
//Nurse n8 = new Nurse() { StaffId = 16, StaffName = "sonal", Email = "sonal@Movie.com", DeptName = "dental", ContactNo = 9988989, StaffCategory = "nurse", Location = "pune", Experience = 10, };
////logic.RegisterStaff(n8);

////string[] abc = new string[] { $"{doc.StaffId}, { doc.StaffName }, {doc.Email}, {doc.DeptName}, {doc.Gender}, {doc.StaffCategory}, {doc.Education}, {doc.ContactNo}, {doc.Specilization}" };
//string[] abc = new string[] { $"{doc1.StaffId}, {doc1.StaffName}, {doc1.Email}, {doc1.DeptName}, {doc1.Gender}, {doc1.StaffCategory}, {doc1.Education}, {doc1.ContactNo}, {doc1.Specilization} ," +"\n"+
//    $" { doc2.StaffId }, {doc2.StaffName}, {doc2.Email}, {doc2.DeptName}, {doc2.Gender}, {doc2.StaffCategory}, {doc2.Education}, {doc2.ContactNo}, {doc2.Specilization} ," +"\n"+
//    $" { doc3.StaffId }, {doc3.StaffName}, {doc3.Email}, {doc3.DeptName}, {doc3.Gender}, {doc3.StaffCategory}, {doc3.Education}, {doc3.ContactNo}, {doc3.Specilization} ," +"\n" +
//    $" { doc4.StaffId }, {doc4.StaffName}, {doc4.Email}, {doc4.DeptName}, {doc4.Gender}, {doc4.StaffCategory}, {doc4.Education}, {doc4.ContactNo}, {doc4.Specilization} ," +"\n" +
//    $" { doc5.StaffId }, {doc5.StaffName}, {doc5.Email}, {doc5.DeptName}, {doc5.Gender}, {doc5.StaffCategory}, {doc5.Education}, {doc5.ContactNo}, {doc5.Specilization} ," +"\n"+
//    $" { doc6.StaffId }, {doc6.StaffName}, {doc6.Email}, {doc6.DeptName}, {doc6.Gender}, {doc6.StaffCategory}, {doc6.Education}, {doc6.ContactNo}, {doc6.Specilization} ," +"\n"+
//    $" { doc7.StaffId }, {doc7.StaffName}, {doc7.Email}, {doc7.DeptName}, {doc7.Gender}, {doc7.StaffCategory}, {doc7.Education}, {doc7.ContactNo}, {doc7.Specilization} ," +"\n"+
//    $" { doc8.StaffId }, {doc8.StaffName}, {doc8.Email}, {doc8.DeptName}, {doc8.Gender}, {doc8.StaffCategory}, {doc8.Education}, {doc8.ContactNo}, {doc8.Specilization} ," +"\n" +
//    $"{n1.StaffId}, {n1.StaffName}, {n1.Email}, {n1.DeptName}, {n1.Gender}, {n1.StaffCategory}, {n1.Education}, {n1.ContactNo}, {n1.Experience} ," +"\n"+
//    $" { n2.StaffId }, {n2.StaffName}, {n2.Email}, {n2.DeptName},  {n2.StaffCategory} {n2.ContactNo}, {n2.Experience} ," +"\n"+
//    $" { n3.StaffId }, {n3.StaffName}, {n3.Email}, {n3.DeptName}, {n3.StaffCategory}, {n3.ContactNo}, {n3.Experience} ," +"\n" +
//    $" { n4.StaffId }, {n4.StaffName}, {n4.Email}, {n4.DeptName}, {n4.StaffCategory}, {n4.ContactNo}, {n4.Experience} ," +"\n" +
//    $" { n5.StaffId }, {n5.StaffName}, {n5.Email}, {n5.DeptName}, {n5.StaffCategory}, {n5.ContactNo}, {n5.Experience} ," +"\n"+
//    $" { n6.StaffId }, {n6.StaffName}, {n6.Email}, {n6.DeptName},  {n6.StaffCategory}, {n6.ContactNo}, {n6.Experience} ," +"\n"+
//    $" { n7.StaffId }, {n7.StaffName}, {n7.Email}, {n7.DeptName},  {n7.StaffCategory}, {n7.ContactNo}, {n7.Experience} ," +"\n"+
//    $" { n8.StaffId }, {n8.StaffName}, {n8.Email}, {n8.DeptName}, {n8.StaffCategory}, {n8.ContactNo}, {n8.Experience} ," +"\n"};



try
{
    
    foreach (var s in staffs)
    {
        Console.WriteLine(s.StaffId);
        Console.WriteLine(s.StaffName);
    }
    operation.CreateFile();


    // string str = operation.ReadFile();

    operation.WriteFile(staffs);

    //string str = operation.ReadFile();

    //while (str != null)
    //{
    //    lines.Add(str);
    //}

    //foreach (string value in lines)
    //{
    //    Console.WriteLine(value);
    //}
    Console.WriteLine("enter staff category to search");
    string category = Console.ReadLine();
    operation.ReadFileByCategory(category);

    Console.WriteLine("enter staff id to search");
    int id = Convert.ToInt32(Console.ReadLine());
    operation.ReadFileByID(id);
    //Console.WriteLine(str);

    Console.WriteLine("enter count of staff to search");
    int count = Convert.ToInt32(Console.ReadLine());
    operation.ReadRecordsByCount(count);
    // operation.FileDetails();
    // Console.WriteLine(a1);

    Console.WriteLine("enter staff id to delete");
    int id1 = Convert.ToInt32(Console.ReadLine());
    operation.DeleteStaffById(id1);

    Console.WriteLine("enter staff id to update");
    int id2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("enter staff parameter to update");
    //int id2 = Convert.ToInt32(Console.ReadLine());
    string parameter = Console.ReadLine();

    //string xyz = $"{doc.id2}.{parameter}" +
    //    $"";

    


    //string n= "{" +doc.StaffName;
    //Console.WriteLine(xyz);
    //Console.WriteLine(n);

    Console.WriteLine("enter staff parameter value to update");
    //int id2 = Convert.ToInt32(Console.ReadLine());
    string value = Console.ReadLine();

    //string xyz1 = doc1.StaffName;
    //operation.UpdateStaffById(id1, doc{ id2
    //        }.StaffName, xyz1);

    operation.DirectoryInfo();
    operation.MoveDirectory();

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