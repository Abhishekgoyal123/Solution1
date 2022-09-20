// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using CS_New;
byte[] temp;
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
JsonSerializerMethod(doc1);
JsonSerializerMethod(doc2);
JsonSerializerMethod(doc3);
JsonSerializerMethod(doc4);
JsonSerializerMethod(doc5);
JsonSerializerMethod(doc6);
JsonSerializerMethod(doc7);
JsonSerializerMethod(doc8);

string out11 = @"C:\Assignment\MyFile1.txt";


JsonSerializerMethod(n1);
JsonSerializerMethod(n2);
JsonSerializerMethod(n3);
JsonSerializerMethod(n4);
JsonSerializerMethod(n5);
JsonSerializerMethod(n6);
JsonSerializerMethod(n7);
JsonSerializerMethod(n8);

//ReadByID();
//ReadByCategory();
//ReadByCount();
//Delete();
//Update();
//Image();
DirectoryInfo();

static void JsonSerializerMethod(Staff doc)
{
    
    string out1= @"C:\Assignment\MyFile1.txt";
   
     //JsonSerializer.Serialize<Staff>(doc);
    using (StreamWriter sw = File.AppendText(out1))
    {
        sw.WriteLine(JsonSerializer.Serialize<Staff>(doc));
        
    }
}
static void ReadByID()
{
    Console.WriteLine("Enter id to search");
    int id = Convert.ToInt32(Console.ReadLine());
    string ln = string.Empty;
    //FileStream fs;
    string out_my = @"C:\Assignment\MyFile1.txt";
    
    StreamReader sr = File.OpenText(out_my);
    while ((ln = sr.ReadLine()) != null)
    {
        //var a = JsonConvert.DeserializeObject<Staff>(ln);
        var a = JsonSerializer.Deserialize<Staff>(ln);
        {
            if(a.StaffId==id)
            {
                Console.WriteLine(a.StaffName);
            }
        }
        
    }
    sr.Close();
    sr.Dispose();


}

static void ReadByCategory()
{
    Console.WriteLine("Enter category to search");
    string category = Console.ReadLine();
    string ln = string.Empty;
    FileStream fs;
    string out_my = @"C:\Assignment\MyFile1.txt";

    StreamReader sr = File.OpenText(out_my);
    while ((ln = sr.ReadLine()) != null)
    {
        //var a = JsonConvert.DeserializeObject<Staff>(ln);
        var a = JsonSerializer.Deserialize<Staff>(ln);
        {
            if (a.StaffCategory == category)
            {
                Console.WriteLine(a.StaffName);
            }
        }

    }
    sr.Close();
    sr.Dispose();
    
}

   static void ReadByCount()
    {

        Console.WriteLine("Enter count to search");
        int count = Convert.ToInt32(Console.ReadLine());
        int cnt= 0;
        string ln = string.Empty;
        FileStream fs;
        string out_my = @"C:\Assignment\MyFile1.txt";

        StreamReader sr = File.OpenText(out_my);
        while ((ln = sr.ReadLine()) != null && cnt != count)
        {
            //var a = JsonConvert.DeserializeObject<Staff>(ln);
            var a = JsonSerializer.Deserialize<Staff>(ln);
            {
                
                
                    Console.WriteLine(a.StaffId);
                    Console.WriteLine(a.StaffName);
                    Console.WriteLine(a.StaffCategory);
                    Console.WriteLine(a.Email);
                    Console.WriteLine(a.ContactNo);
                    Console.WriteLine(a.DeptName);

            Staff abc = new Doctor();

            Doctor z = (Doctor)abc;
            Console.WriteLine(z.Specilization);
            Console.WriteLine(z.Education);
            Console.WriteLine("======================================");
            cnt++;
 
            }

        }
    sr.Close();
    sr.Dispose();
}

static void Delete()
{
    Console.WriteLine("Enter id to delete");
    int id1 = Convert.ToInt32(Console.ReadLine());
    

    string out_my = @"C:\Assignment\MyFile1.txt";

    string out1 = @"C:\Assignment\MyFile2.txt";

    string store = String.Empty;
    string str = String.Empty;
    FileStream fs = new FileStream(out_my, FileMode.Open,FileAccess.Read);
   
    StreamReader streamReader = new StreamReader(fs);
     
    while (( store=streamReader.ReadLine()) != null)
    {
        
        var v=JsonSerializer.Deserialize<Staff>(store);
        if (v.StaffId != id1)
        {
            FileStream fs1 = new FileStream(out1, FileMode.Append);

            StreamWriter streamWriter = new StreamWriter(fs1);
            streamWriter.WriteLine(store);
            streamWriter.Close();
            fs1.Close();
            fs1.Dispose();
        }

    }
    
    streamReader.Close();
    streamReader.Dispose();
    fs.Close();
    fs.Dispose();
   
    File.Delete(out_my);

    fs = new FileStream(out_my, FileMode.CreateNew);
    fs.Close();
    File.Copy(out1, out_my,true);
    File.Delete(out1);
    


    //using (StreamReader sr = File.OpenText(out_my))
    //{
    //    string ln = string.Empty;
    //    while ((ln = sr.ReadLine()) != null)
    //    {
    //        var a = JsonSerializer.Deserialize<Staff>(ln);


    //        if (a.StaffId != id1)
    //        {

    //            //string out1 = @"C:\Assignment\MyFile2.txt";

    //            //string out_1 = JsonSerializer.Serialize<Staff>(a);
    //            using (StreamWriter sw = File.AppendText(out1))
    //            {
    //                sw.WriteLine(ln);

    //            }

    //        }
    //    }
    //    sr.Close();
    //    sr.Dispose();
    //}

    //File.Delete(out_my);

    //    File.Move(out1, out_my);

}


static void Update()
{
    Console.WriteLine("Enter id to update ");
    int id1 = Convert.ToInt32(Console.ReadLine());

    string out_my = @"C:\Assignment\MyFile1.txt";

    string out1 = @"C:\Assignment\MyFile2.txt";

    FileStream fs = new FileStream(out_my, FileMode.Open, FileAccess.Read);

    StreamReader streamReader = new StreamReader(fs);

    string store = string.Empty;

    Staff s1 = new Doctor();

    while ((store = streamReader.ReadLine()) != null)
    {
        var v = JsonSerializer.Deserialize<Staff>(store);

        if (v.StaffId == id1)
        {
            //Staff s1 = new Doctor();
            Console.WriteLine("enter staff id");
            s1.StaffId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter staff name");
            s1.StaffName = Console.ReadLine();


            
            
                var v1 = JsonSerializer.Serialize<Staff>(s1);
                FileStream fs1 = new FileStream(out1, FileMode.Append);
                StreamWriter streamWriter = new StreamWriter(fs1);
                streamWriter.WriteLine(v1);
                streamWriter.Close();
                fs1.Close();
                fs1.Dispose();
            

        }
        else
        {
            if (v.StaffId != id1)
            {
                FileStream fs1 = new FileStream(out1, FileMode.Append);
                StreamWriter streamWriter = new StreamWriter(fs1);
                streamWriter.WriteLine(store);
                streamWriter.Close();
                fs1.Close();
                fs1.Dispose();
            }
            
        
        }

    }

    streamReader.Close();
    streamReader.Dispose();
    fs.Close();
    fs.Dispose();
    File.Delete(out_my);

    fs = new FileStream(out_my, FileMode.CreateNew);
    fs.Close();
    File.Copy(out1, out_my, true);
    File.Delete(out1);
}

 void Image()
{
    string abc = @"C:\Assignment\Screenshot (9).png";

    //FileStream fs = new FileStream(abc, FileMode.Open);
    //StreamReader sr = new StreamReader(fs);
   
    System.Drawing.Image img = System.Drawing.Image.FromFile(abc);
    MemoryStream ms = new MemoryStream();
   
    //img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
    img.Save(ms, img.RawFormat);
    temp=ms.ToArray();
    
    foreach (var t in temp)
    {
        Console.Write(t);
    }
    ms.Close();
    string abc1 = @"C:\Assignment\Image.jpg";
    MemoryStream ms1 = new MemoryStream(temp);
    System.Drawing.Image img1 = System.Drawing.Image.FromStream(ms1);
    img1.Save(abc1, ImageFormat.Jpeg);
  
}

//Console.WriteLine("enter staff category to search");
//string abc = Console.ReadLine();

//FileStream fs1 = new FileStream(out11, FileMode.Open, FileAccess.Read);
//StreamReader sw = new StreamReader(fs1);
//string ln = sw.ReadLine();
//string ln1 = sw.ReadLine();
//var a = JsonSerializer.Deserialize<Staff>(ln);
//var text = from line in ln
//          // join ln1 in 
//               // where line.Contains(abc)
//           where a.StaffId == 1
//           select line;

//foreach(var item in text)
//{
//    Console.Write(item);
//}


// void DirectoryInfo()
//{
//    Console.WriteLine("abhishek");
//    string Dirpath = @"C:\Assignment";
//    /*DirectoryInfo dinfo = new DirectoryInfo(Dirpath)*/;

//    string[] filenames = Directory.GetFiles(Dirpath,"*",SearchOption.AllDirectories);



//    foreach (var i in filenames)
//    {
//        Console.WriteLine(i);

//        Console.WriteLine($"File Name - {i}");

//        Console.WriteLine("=========================================================================");

//    }
//}

static void DirectoryInfo()
{
    string Dirpath = @"C:\Assignment\CheckMoved";
    DirectoryInfo dinfo = new DirectoryInfo(Dirpath);

    FileInfo[] Files = dinfo.GetFiles("*",SearchOption.AllDirectories);
    
   
        foreach (var i in Files)
    {

        Console.WriteLine($"File Name - {i.Name}");
        Console.WriteLine($"File Size - {i.Length} bytes");
        Console.WriteLine($"Creation Time - {i.CreationTime}");
        Console.WriteLine($"date modified - {i.LastWriteTime}");
        Console.WriteLine("=========================================================================");

    }
}