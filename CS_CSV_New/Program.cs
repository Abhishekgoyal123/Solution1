// See https://aka.ms/new-console-template for more information
//using ServiceStack.Text;
using System.Collections.Generic;
using CS_CSV_New;
//using LINQtoCSV;
using System.Text.Json;
using CsvHelper;

using System.Globalization;
//using CsvHelper.Configuration;
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


//string out1 = @"C:\Assignment\MyCSV.csv";
//StreamWriter writer = new StreamWriter(out1);

string[] arr = new string[7] { "StaffId", "StaffName", "Email", " Location", "DeptName", "StaffCategory", "ContactNo" };

//WriteFile(arr);

//ColumnHeading();
colHeading();
Write1(doc1);
Write1(doc2);
Write1(doc3);
Write1(doc4);
Write1(doc5);
Write1(doc6);
Write1(doc7);
Write1(doc8);
Write1(n1);
Write1(n2);
Write1(n3);
Write1(n4);
Write1(n5);
Write1(n6);
Write1(n7);
Write1(n8);

// Service stack

//static void Write(Staff doc)
//{

//    string out1 = @"C:\Assignment\MyCSV.csv";
//    ////CsvSerializer.SerializeToCsv<Staff>(doc);

//    FileStream fs = new FileStream(out1, FileMode.Append,FileAccess.Write);
//    string a = CsvSerializer.SerializeToCsv((IEnumerable<Staff>)doc);
//    Console.WriteLine(a);
//    StreamWriter sw = new StreamWriter(fs);

//    using (StreamWriter sw1 = File.AppendText(out1))
//    {
//        string a1 = CsvSerializer.SerializeToCsv((IEnumerable<Staff>)doc);
//        Console.WriteLine(a1);

//        sw1.WriteLine(a1);



//    }
//   sw.WriteLine(a);
//    sw.Close();
//    sw.Dispose();
//    fs.Close();
//    fs.Dispose();


//}

static void colHeading()
{
    string out1 = @"C:\Assignment\MyCSV.csv";
    using (StreamWriter sw = File.AppendText(out1))
    {
        using (var csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
        {
            csv.WriteField("Staffid");
            csv.WriteField("Staffname");
           

            //csv.WriteField(doc.StaffName);
        }

    }
}

 static void Write1(Staff doc)
{

    //using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
    //{
    //    csv.WriteRecord(doc);
    //    //csv.WriteField(doc.StaffName);
    //}


    string out1 = @"C:\Assignment\MyCSV.csv";

    //FileStream fs = new FileStream(out1, FileMode.Append);

    //StreamWriter sw = new StreamWriter(fs);

    //var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);

    //    csv.WriteRecord(doc);
    //fs.Close();
    //fs.Dispose();
    //sw.Close();
    //sw.Dispose();

    using (StreamWriter sw = File.AppendText(out1))
    {
        using (var csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
        {
            
            csv.WriteRecord(doc);
            sw.WriteLine();

            //csv.WriteField(doc.StaffName);
        }

    }




}


// csv context
//static void Write(Staff doc)
//{
//    var CsvContext = new CsvContext();
//    string out1 = @"C:\Assignment\MyCSV.csv";
//    CsvContext.Write<Staff>(doc, out1);

//}



static void ColumnHeading()
{
    string out2 = @"C:\Assignment\MyCSV.csv";
    FileStream fs = new FileStream(out2, FileMode.OpenOrCreate, FileAccess.Write);
    StreamWriter sw = new StreamWriter(fs);

    //sw.WriteLine("Staff_Id");

    //fs.Close();
    //fs.Dispose();

    using (var csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
    {
        csv.WriteField("Staffid");
        csv.WriteRecord("fwr");
       // sw.WriteLine();

        //csv.WriteField(doc.StaffName);
    }



}


//string[] arr = new string[5] { "staffid" ,"bnmb" , "b vm"," bbm","vm"};

 void WriteFile(string[] contents)
{
    string out2 = @"C:\Assignment\MyCSV.csv";

    foreach (var item in contents)
    {
        string s = item;
        FileStream fs = new FileStream(out2, FileMode.OpenOrCreate, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);
        //contents = new string[] {"abc" , "wdf" }; 
        sw.Write(s);
        sw.Close();
        sw.Dispose();
    }
       
            
       

}

