// See https://aka.ms/new-console-template for more information
using ServiceStack.Text;
using System.Collections.Generic;
using CS_CSV_New;
Console.WriteLine("Hello, World!");



Doctor doc1 = new Doctor() { StaffId = 1, StaffName = "Divyansh", Email = "divyansh@Movie.com", ContactNo = 998899, Education = "M.B.B.S", DeptName = "Cancer", StaffCategory = "doctor", Location = "pune", Specilization = "cancer" };
Doctor doc2 = new Doctor() { StaffId = 2, StaffName = "omkar", Email = "omkar@Movie.com", ContactNo = 997799, Education = "B.A.M.S", DeptName = "Heart", StaffCategory = "doctor", Location = "mumbai", Specilization = "cancer" };
Doctor doc3 = new Doctor() { StaffId = 3, StaffName = "rahul", Email = "rahul@Movie.com", ContactNo = 996699, Education = "B.A.M.S", DeptName = "Heart", StaffCategory = "doctor", Location = "pune", Specilization = "cancer" };
Doctor doc4 = new Doctor() { StaffId = 4, StaffName = "vivek", Email = "vivek@Movie.com", ContactNo = 995599, Education = "B.H.M.S", DeptName = "Cancer", StaffCategory = "doctor", Location = "chennai", Specilization = "cancer" };
Doctor doc5 = new Doctor() { StaffId = 5, StaffName = "omkar", Email = "omkar@Movie.com", ContactNo = 994499, Education = "M.B.B.S", DeptName = "eye", StaffCategory = "doctor", Location = "pune", Specilization = "cancer" };
Doctor doc6 = new Doctor() { StaffId = 6, StaffName = "anurag", Email = "anurag@Movie.com", ContactNo = 993399, Education = "M.B.B.S", DeptName = "Cancer", StaffCategory = "doctor", Location = "mumbai", Specilization = "cancer" };
Doctor doc7 = new Doctor() { StaffId = 7, StaffName = "rohan", Email = "rohan@Movie.com", ContactNo = 992299, Education = "B.H.M.S", DeptName = "eye", StaffCategory = "doctor", Location = "chennai", Specilization = "cancer" };
Doctor doc8 = new Doctor() { StaffId = 8, StaffName = "sachin", Email = "sachin@Movie.com", ContactNo = 991199, Education = "ssc", DeptName = "dental", StaffCategory = "doctor", Location = "pune", Specilization = "cancer" };

Nurse n1 = new Nurse() { StaffId = 9, StaffName = "riya", Email = "riya@Movie.com", DeptName = "Cancer", ContactNo = 9988919, StaffCategory = "nurse", Location = "pune", Experience = 10, };
Nurse n2 = new Nurse() { StaffId = 10, StaffName = "diya", Email = "diya@Movie.com", DeptName = "Heart", ContactNo = 9988929, StaffCategory = "nurse", Location = "mumbai", Experience = 10, };
Nurse n3 = new Nurse() { StaffId = 11, StaffName = "deppika", Email = "deepika@Movie.com", DeptName = "Heart", ContactNo = 9988939, StaffCategory = "nurse", Location = "chennai", Experience = 10, };
Nurse n4 = new Nurse() { StaffId = 12, StaffName = "shreya", Email = "shreya@Movie.com", DeptName = "Cancer", ContactNo = 9988949, StaffCategory = "nurse", Location = "pune", Experience = 10, };
Nurse n5 = new Nurse() { StaffId = 13, StaffName = "deepa", Email = "deppa@Movie.com", DeptName = "eye", ContactNo = 9988959, StaffCategory = "nurse", Location = "kanpur", Experience = 10, };
Nurse n6 = new Nurse() { StaffId = 14, StaffName = "shradha", Email = "shradha@Movie.com", DeptName = "dental", ContactNo = 9988969, StaffCategory = "nurse", Location = "pune", Experience = 10, };
Nurse n7 = new Nurse() { StaffId = 15, StaffName = "khushi", Email = "khushi@Movie.com", DeptName = "dental", ContactNo = 9988799, StaffCategory = "nurse", Location = "delhi", Experience = 10, };
Nurse n8 = new Nurse() { StaffId = 16, StaffName = "sonal", Email = "sonal@Movie.com", DeptName = "dental", ContactNo = 9988989, StaffCategory = "nurse", Location = "pune", Experience = 10, };



Write(doc1);


static void Write(Staff doc)
{

    string out1 = @"C:\Assignment\MyCSV.";
    CsvSerializer.SerializeToCsv<Staff>(doc);


    using (StreamWriter sw = File.AppendText(out1))
    {
        sw.WriteLine(CsvSerializer.SerializeToCsv<Staff>(doc));

    }
}
