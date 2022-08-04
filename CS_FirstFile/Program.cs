using System.IO;
using CS_FirstFile.Entities;
using CS_FirstFile.Models;
using CS_FirstFile.Logic;
using CS_FirstFile.Operations;
using CS_FirstFile.Database;
using CS_FirstFile.Operations;

StaffLogic logic = new DoctorLogic();



Doctor d1 = new Doctor()

{
    StaffId = 101,
    StaffName = "Dr. No",
    Location = "Delhi",
    Education = "M.B.B.S",
    Specilization = "General Physician",
    Email = "Abcd@gmail.com",
    DeptName = "Cancer",
    Gender = "male",
    StaffCategory = "Doctor",
    ContactNo = 123,
};
logic.RegisterStaff(d1);

Nurse n1 = new Nurse()
{
    StaffId = 201,
    StaffName = "Mr. Bee",
    Location = "Delhi",
    StaffCategory = "Nurse",
    Education = "xyz",
    Experience = 10,
    Email = "Abcd@gmail.com",
    DeptName = "Cancer",
    Gender = "female",
    ContactNo = 123,
};

logic.RegisterStaff(n1);

Console.WriteLine("Using Files");
try
{
   

    //Console.WriteLine("enter file name ");
    //string filename = Console.ReadLine();

    //string path = $@"C:\StaffIncome";



    //FileOperation operation = new FileOperation();

    //operation.CreateFile(path,filename);

    //string[] data = new string[] { "a", "b" };

    //operation.WriteFileIncome(path, filename, data);

    
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//StaffLogic logic = new DoctorLogic();

Console.WriteLine("Using An Accountant GAteway to Get an INome");
Console.WriteLine("Enter staff id to Get an INome");
int id11 = Convert.ToInt32(Console.ReadLine());

foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
{
    //Console.Clear();
    //if (s.Key == id11 && id11 >= 100 && id11 <= 200)

    if (s.Key == id11 && s.Value.StaffCategory == "Doctor")

    {
        Doctor doc1 = new Doctor();

        Console.WriteLine("Enter total patients diagnosed  for doctor");
        doc1.patientsDiagonsed = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter operations per day for doctor");
        doc1.operationsPerDay = Convert.ToInt32(Console.ReadLine());

        Doctor st = (Doctor)s.Value;
        int a = st.StaffId;
        string b = st.StaffName;
        string c = st.StaffCategory;

        StaffLogicAbstract staffDoc = new DoctorLogicEx(id11, doc1.patientsDiagonsed, doc1.operationsPerDay);

        FileOperation operation = new FileOperation();
        Accounts accounts = new Accounts();

        Console.WriteLine("enter file name ");
        string filename = Console.ReadLine();

        string path = $@"C:\StaffIncome";

        operation.CreateFile(path, filename);

        //operation.CreateFile(path, filename,data);

        // string[] data = new string[] { $"{accounts.GetStaffTotalIncome(staffDoc)}", "b" };

        string[] data = new string[] {  
            "\t\t\t\tPAY SLIP", 
            "===============================================================================================\n" ,
            a + "\t\t\t\t\t" + b + "\t\t\t\t\t" + c +
            "\n==================================================================================" +
            $"\nTotal Income = {accounts.GetStaffTotalIncome(staffDoc)}"  + "\n======================================================================================"+
            $" \nShareToHospital  = {accounts.GetShareToHospital(staffDoc)}" + "\n==============================================================================================="+ 
            $" \nNet Income  = {accounts.GetStaffNetIncome(staffDoc)}" + "\n===============================================================================================" +
            $"\n Net Tax  = {accounts.GetTax(staffDoc)}" + "\n==============================================================================================="+     
            $"\nGross Income  = {accounts.GetGrossIncome(staffDoc)}" + "\n==============================================================================================="} ;
        operation.WriteFileIncome(path, filename, data);



        Console.WriteLine("\t\t\tPAY SLIP");

        Console.WriteLine("\n===============================================================================================");

        Console.WriteLine(a + "\t\t\t\t" + b + "\t\t\t\t" + c);

        Console.WriteLine("\n===============================================================================================");
        //Console.WriteLine(b);
        //Console.WriteLine(c);

      //  Accounts accounts = new Accounts();

        Console.WriteLine($"Total Income = {accounts.GetStaffTotalIncome(staffDoc)}");
        //var abc= convertToWords.(accounts.GetStaffTotalIncome(staffDoc);
       // Console.WriteLine(convertToWords.convertToWords(accounts.GetStaffTotalIncome(staffDoc)));
        Console.WriteLine("===============================================================================================");
        Console.WriteLine($" ShareToHospital  = {accounts.GetShareToHospital(staffDoc)}");
        Console.WriteLine("===============================================================================================");
        Console.WriteLine($" Net Income  = {accounts.GetStaffNetIncome(staffDoc)}");
        Console.WriteLine("===============================================================================================");
        Console.WriteLine($"Net Tax  = {accounts.GetTax(staffDoc)}");
        Console.WriteLine("===============================================================================================");
        Console.WriteLine($"Gross Income  = {accounts.GetGrossIncome(staffDoc)}");
        Console.WriteLine("===============================================================================================");
        Console.WriteLine();
    }

    //if (s.Key == id11 && id11 >= 201 && id11 <= 300)

    if (s.Key == id11 && s.Value.StaffCategory == "Nurse")
    {
        Nurse N1 = new Nurse();
        Console.WriteLine("Enter total Injection Applied for nurse");
        N1.InjectionApplied = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter PatientsMonitored for Nurse");
        N1.PatientsMonitored = Convert.ToInt32(Console.ReadLine());
        Nurse st = (Nurse)s.Value;
        int a = st.StaffId;
        string b = st.StaffName;
        string c = st.StaffCategory;
        StaffLogicAbstract staffNur = new NurseLogicEx(id11, N1.InjectionApplied, N1.PatientsMonitored);
        FileOperation operation = new FileOperation();
        Accounts accounts = new Accounts();

        Console.WriteLine("enter file name ");
        string filename = Console.ReadLine();

        string path = $@"C:\StaffIncome";

        operation.CreateFile(path, filename);

        //operation.CreateFile(path, filename,data);

        // string[] data = new string[] { $"{accounts.GetStaffTotalIncome(staffDoc)}", "b" };

        string[] data = new string[] {
            "\t\t\t\tPAY SLIP",
            "===============================================================================================\n" ,
            a + "\t\t\t\t\t" + b + "\t\t\t\t\t" + c +
            "\n==================================================================================" +
            $"\nTotal Income = {accounts.GetStaffTotalIncome(staffNur)}"  + "\n======================================================================================"+
            $" \nShareToHospital  = {accounts.GetShareToHospital(staffNur)}" + "\n==============================================================================================="+
            $" \nNet Income  = {accounts.GetStaffNetIncome(staffNur)}" + "\n===============================================================================================" +
            $"\n Net Tax  = {accounts.GetTax(staffNur)}" + "\n==============================================================================================="+     
            $"\nGross Income  = {accounts.GetGrossIncome(staffNur)}" + "\n==============================================================================================="};
        operation.WriteFileIncome(path, filename, data);

        //Accounts accounts = new Accounts();


        Console.WriteLine("                     PAY SLIP                 ");

        Console.WriteLine("===============================================================================================");

        Console.WriteLine(a + "                         " + b + "                              " + c);

        Console.WriteLine("===============================================================================================");

        Console.WriteLine($"Total Income  = {accounts.GetStaffTotalIncome(staffNur)}");
        Console.WriteLine("===============================================================================================");

        Console.WriteLine($" ShareToHospital  = {accounts.GetShareToHospital(staffNur)}");
        Console.WriteLine("===============================================================================================");

        Console.WriteLine($" Net Income  = {accounts.GetStaffNetIncome(staffNur)}");
        Console.WriteLine("===============================================================================================");

        Console.WriteLine($"Net Tax  = {accounts.GetTax(staffNur)}");
        Console.WriteLine("===============================================================================================");

        Console.WriteLine($"Gross Income = {accounts.GetGrossIncome(staffNur)}");
        Console.WriteLine();
        //break;
    }
}


    //Console.ReadLine();