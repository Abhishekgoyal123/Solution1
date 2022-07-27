// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Console.WriteLine("USing Static Modifiers");

StaffLogic logic = new DoctorLogic();

Doctor d1 = new Doctor()

{
    StaffId = 101,
    StaffName = "Dr. No",
    Education = "M.B.B.S",
    Specilization = "General Physician"
};
logic.RegisterStaff(d1);

Doctor d2 = new Doctor()
{
    StaffId = 102,
    StaffName = "Dr. Deng",
    Education = "B.H.M.S.",
    Specilization = "Heart"
};
logic.RegisterStaff(d2);


//logic = new NurseLogic();
Nurse n1 = new Nurse()
{
    StaffId = 103,
    StaffName = "Mr. Bee",
    Experience = 10,
};

logic.RegisterStaff(n1);

string continueExecution = "y";
do
{
    Console.WriteLine("1. New Doctor Registration");
    Console.WriteLine("2. Update Doctor Information");
    Console.WriteLine("3. Delete Doctor Information");
    Console.WriteLine("4. Display record of all Doctors");
    Console.WriteLine("5. Search record of a particular doctor");
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("6. New Nurse Registration");
    Console.WriteLine("7. Update Nurse Information");
    Console.WriteLine("8. Delete Nurse Information");
    Console.WriteLine("9. Display record of all Nurse");
    Console.WriteLine("10. Search record of a particular Nurse");

    Console.WriteLine("--------------------------------------------------------");

    Console.WriteLine("11. Income of Staff");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:

            Doctor doc = new Doctor();
            Console.WriteLine("Enter ID of staff");
            doc.StaffId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name of staff");
            doc.StaffName = Console.ReadLine();
            Console.WriteLine("Enter Email of staff");
            doc.Email = Console.ReadLine();
            Console.WriteLine("Enter Department of staff");
            doc.DeptName = Console.ReadLine();
            Console.WriteLine("Enter Gender of staff");
            doc.Gender = Console.ReadLine();
            Console.WriteLine("Enter Category of staff");
            doc.StaffCategory = Console.ReadLine();
            Console.WriteLine("Enter Education of staff");
            doc.Education = Console.ReadLine();
            Console.WriteLine("Enter contact number of staff");
            doc.ContactNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Specialization of staff");
            doc.Specilization = Console.ReadLine();
            Console.WriteLine("Enter Education of staff");
            doc.Education = Console.ReadLine();
           // Console.WriteLine("Enter total patients diagnosed  for doctor");
            //doc.patientsDiagonsed = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter operations per day for doctor");
            //doc.operationsPerDay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter contact number of staff");
            doc.ContactNo = Convert.ToInt32(Console.ReadLine());

            logic.RegisterStaff(doc);
            //staffId++;
            Console.WriteLine("New Doctor Registered successfully");
            break;
        //Console.WriteLine(Staff.StaffName);


        case 2:
            Console.WriteLine("Enter Staff Id for which you want to update the record");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name and Specialization of staff to be updated");

            doc = new Doctor()
            {
                StaffId = id,
                StaffName = Console.ReadLine(),
                Specilization = Console.ReadLine(),
                Email = "Abcd@gmail.com",
                DeptName = "Cancer",
                Gender = "male",
                StaffCategory = "Doctor",
                ContactNo=123,

                Education = "Bsc. Path",
                //Specilization = Console.ReadLine(),
            };

            var v = logic.UpdateStaffInfo(id, doc);
            Console.WriteLine("Record updated successfully");


            break;
        case 3:
            int id5;
            Console.WriteLine("Enter the id to delete ");
            id5 = Convert.ToInt32(Console.ReadLine());
            //logic.DeleteDoctor(id5);
            Console.WriteLine("Successfully deleted");

            break;
        case 4:
            break;
        case 5:
            Console.WriteLine("Enter Staff Id for which you want to search the record");
            int id2 = Convert.ToInt32(Console.ReadLine());
            //var st = logic.GetStaffById(id2)
            foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
            {
                if (s.Value.StaffId == id2)
                {
                    var a = (Doctor)s.Value;
                    Console.WriteLine(s.Value.StaffId + "    " + s.Value.StaffName + "    " + s.Value.Email + "      " + s.Value.DeptName + "     " + s.Value.Gender +"     " + s.Value.StaffCategory + "       " + s.Value.ContactNo + "       " + a.Education + "    " + a.Specilization);
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                }

            }
            break;
        case 6:
            Nurse Nur = new Nurse();
            Console.WriteLine("Enter ID of staff");
            Nur.StaffId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name of staff");
            Nur.StaffName = Console.ReadLine();
            Nur.Email = Console.ReadLine();
            Console.WriteLine("Enter Department of staff");
            Nur.DeptName = Console.ReadLine();
            Console.WriteLine("Enter Gender of staff");
            Nur.Gender = Console.ReadLine();
            Console.WriteLine("Enter Category of staff");
            Nur.StaffCategory = Console.ReadLine();
            Nur.Experience = Convert.ToInt32(Console.ReadLine());


            logic.RegisterStaff(Nur);
            Console.WriteLine("New Nurse Registered successfully");
            break;

        case 7:
            Console.WriteLine("Enter Staff Id for which you want to update the record");
            int id1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name and experience of nurse to be updated");

            Nur = new Nurse()
            {
                StaffId = id1,
                StaffName = Console.ReadLine(),
                Experience = Convert.ToInt32(Console.ReadLine())   
            };

            logic.UpdateStaffInfo(id1, Nur);

            Console.WriteLine("Record updated successfully");


            break;

        case 8:
            break;
        case 9:
            
            break;
        case 10:
            Console.WriteLine("Enter Staff Id for which you want to search the record");
            int id3 = Convert.ToInt32(Console.ReadLine());
            //var st = logic.GetStaffById(id2)
            foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
            {
                if (s.Value.StaffId == id3)
                {
                    var a = (Nurse)s.Value;
                    Console.WriteLine(s.Value.StaffId + "    " + s.Value.StaffName + "    " + s.Value.Email + "      " + s.Value.DeptName + "     " + s.Value.Gender + "     " + s.Value.StaffCategory + "       " + s.Value.ContactNo + "      " + a.Experience);
                }

            }
            break;

        case 11:



            Console.WriteLine("Using An Accountant GAteway to Get an INome");
            Console.WriteLine("Enter staff id to Get an INome");
            int id11 = Convert.ToInt32(Console.ReadLine());

            Doctor doc1 = new Doctor();
            Console.WriteLine("Enter total patients diagnosed  for doctor");
            doc1.patientsDiagonsed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operations per day for doctor");
            doc1.operationsPerDay = Convert.ToInt32(Console.ReadLine());

            foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
                if (id11 >= 1 && id11 <= 100)
             {
                 StaffLogicAbstract staffabcd = new DoctorLogicEx(id11, doc1.patientsDiagonsed, doc1.operationsPerDay);

                 Accounts accounts = new Accounts();

                 Console.WriteLine($"Net Income for Doctor with staff id {id11} = {accounts.GetStaffIncome(staffabcd)}");
                 Console.WriteLine();
                 //break;
             }
             if (id11 >= 101 && id11 <= 200)
             {
                StaffLogicAbstract staffabcde = new NurseLogicEx(id11,1000, 60);
                Accounts accounts = new Accounts();

                Console.WriteLine($"Net Income for Nurse with Staff is {id11} = {accounts.GetStaffIncome(staffabcde)}");
             }

             else
                 Console.WriteLine($"Staff id {id11} is not registered, please register it first");
            
            break;

    } //while (continueExecution == "y" || continueExecution == "Y") ;




    // Console.ReadLine();

} while (continueExecution == "y" || continueExecution == "Y");





//Console.WriteLine(JsonSerializer.Serialize(Staffs));

//Console.WriteLine("Statff are as below");
//Console.WriteLine("Enter Staff Id for which you want to search the record");
//int id = Convert.ToInt32(Console.ReadLine());


// var Staffs = logic.GetStatffs();


/*foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
{
    if(s.Value.StaffId==101)
    {
        var a = (Doctor)s.Value;
        Console.WriteLine(s.Value.StaffId + "    " + s.Value.StaffName + "    " + "      " + "     " + a.Education + "    " + a.Specilization);
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
    }
   
}*/






