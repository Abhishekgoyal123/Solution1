// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

ConvertToWords convertToWords = new ConvertToWords();
//var bc = cc.convertToWords(21463);
//Console.WriteLine(bc);

StaffLogic logic = new DoctorLogic();

Doctor d1 = new Doctor()

{
    StaffId = 101,
    StaffName = "Dr. No",
    Location="Delhi",
    Education = "M.B.B.S",
   Specilization = "General Physician",
    Email = "Abcd@gmail.com",
    DeptName = "Cancer",
    Gender = "male",
    StaffCategory = "Doctor",
    ContactNo = 123,
};
logic.RegisterStaff(d1);

Doctor d2 = new Doctor()
{
    StaffId = 102,
    StaffName = "Dr. Deng",
    Location = "Pune",
    Specilization = "Heart",
    Education = "btech",
    Email = "Abcd@gmail.com",
    DeptName = "Cancer",
    Gender = "male",
    StaffCategory = "Doctor",
    ContactNo = 123,

   
};
logic.RegisterStaff(d2);

Doctor d3 = new Doctor()

{
    StaffId = 103,
    StaffName = "Abhishek",
    Location = "Pune",
    Education = "M.B.B.S",
    Specilization = "General Physician",
    Email = "Abcd@gmail.com",
    DeptName = "Cancer",
    Gender = "male",
    StaffCategory = "Doctor",
    ContactNo = 123,
};
logic.RegisterStaff(d3);


//logic = new NurseLogic();
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

Nurse n2 = new Nurse()
{
    StaffId = 202,
    StaffName = "Neha",
    Location = "Delhi",
    StaffCategory = "Nurse",
    Education = "xyz",
    Experience = 10,
    Email = "Abcd@gmail.com",
    DeptName = "Heart",
    Gender = "female",
    ContactNo = 123,
};

logic.RegisterStaff(n2);


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
        Console.WriteLine("12  search doctor education");
        Console.WriteLine("13  search by staff name ");

        Console.WriteLine("14 search by staff category and location");


    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:

            Doctor doc = new Doctor();
            Console.WriteLine("Enter ID of staff");
            doc.StaffId = Convert.ToInt32(Console.ReadLine());

            foreach (var s in HospitalDbStore.GlobalStaffStore.Keys)
            {


                while (s == doc.StaffId)
                {
                    Console.WriteLine("Staff id already exist, please enter staff id again");
                    doc.StaffId = Convert.ToInt32(Console.ReadLine());
                }
            }

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
            logic.DeleteStaffInfo(id5);
            Console.WriteLine("Successfully deleted");

            break;
        case 4:

            foreach (var s in HospitalDbStore.GlobalStaffStore.Values)
            {
                if (Convert.ToString(s.GetType()).Contains("Doctor"))
                {
                    var a = (Doctor)s;
                    Console.WriteLine(s.StaffId + "    " + s.StaffName + "    " + s.Email + "      " + s.DeptName + "     " + s.Gender + "     " + s.StaffCategory + "       " + s.ContactNo + "       " + a.Education + "    " + a.Specilization);
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                }
            }
                break;
        case 5:
            Console.WriteLine("Enter Staff Id for which you want to search the record");
            int id2 = Convert.ToInt32(Console.ReadLine());
            //var st = logic.GetStaffById(id2)
            foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
            {
                if (s.Key == id2)
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

            foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
            {


                while (s.Key == Nur.StaffId)
                {
                    Console.WriteLine("Staff id already exist, please enter staff id again");
                    Nur.StaffId = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter Name of staff");
            Nur.StaffName = Console.ReadLine();
            
            Console.WriteLine("Enter staff email");
            Nur.Email = Console.ReadLine();
            Console.WriteLine("Enter Department of staff");
            Nur.DeptName = Console.ReadLine();
            Console.WriteLine("Enter Gender of staff");
            Nur.Gender = Console.ReadLine();
            Console.WriteLine("Enter Category of staff");
            Nur.StaffCategory = Console.ReadLine();
            Console.WriteLine("Enter Experience of staff");
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
            int id6;
            Console.WriteLine("Enter the id to delete ");
            id6 = Convert.ToInt32(Console.ReadLine());
            logic.DeleteStaffInfo(id6);
            Console.WriteLine("Successfully deleted");
            break;
        case 9:
            foreach (var s in HospitalDbStore.GlobalStaffStore.Values)
            {
                if (Convert.ToString(s.GetType()).Contains("Nurse"))
                {
                    var a = (Nurse)s;
                    Console.WriteLine(s.StaffId + "    " + s.StaffName + "    " + s.Email + "      " + s.DeptName + "     " + s.Gender + "     " + s.StaffCategory + "       " + s.ContactNo + "       " + a.Education );
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                }
            }

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
                    Console.WriteLine(s.Value.StaffId + "    " + s.Value.StaffName + "    " + s.Value.Email + "      " + s.Value.DeptName + "     " + s.Value.Gender + "     " + s.Value.StaffCategory  + "      " + a.Experience);
                }

            }
            break;

        case 11:

            Console.WriteLine("Using An Accountant GAteway to Get an INome");
            Console.WriteLine("Enter staff id to Get an INome");
            int id11 = Convert.ToInt32(Console.ReadLine());

            foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
            {
                //Console.Clear();
                //if (s.Key == id11 && id11 >= 100 && id11 <= 200)

                if(s.Key==id11 && s.Value.StaffCategory=="Doctor")
                    
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

                    Console.WriteLine("                     PAY SLIP                 ");

                    Console.WriteLine("===============================================================================================");

                    Console.WriteLine(a + "                         " + b + "                              " + c);

                    Console.WriteLine("===============================================================================================");
                    //Console.WriteLine(b);
                    //Console.WriteLine(c);

                    Accounts accounts = new Accounts();
               
                    Console.WriteLine($"Total Income = {accounts.GetStaffTotalIncome(staffDoc)}");
                    var abc= convertToWords.convertToWords(accounts.GetStaffTotalIncome(staffDoc));
                    Console.WriteLine(abc);
                   
                    Console.WriteLine("===============================================================================================");
                    Console.WriteLine($" ShareToHospital  = {accounts.GetShareToHospital(staffDoc)}");
                    var abc1 = convertToWords.convertToWords(accounts.GetShareToHospital(staffDoc));
                    Console.WriteLine(abc1);

                    Console.WriteLine("===============================================================================================");
                    Console.WriteLine($" Net Income  = {accounts.GetStaffNetIncome(staffDoc)}");
                    var abc2 = convertToWords.convertToWords(accounts.GetStaffNetIncome(staffDoc));
                    Console.WriteLine(abc2);

                    Console.WriteLine("===============================================================================================");
                    Console.WriteLine($"Net Tax  = {accounts.GetTax(staffDoc)}");
                    var abc3 = convertToWords.convertToWords(accounts.GetTax(staffDoc));
                    Console.WriteLine(abc3);

                    Console.WriteLine("===============================================================================================");
                    Console.WriteLine($"Gross Income  = {accounts.GetGrossIncome(staffDoc)}");
                    var abc4 = convertToWords.convertToWords(accounts.GetGrossIncome(staffDoc));
                    Console.WriteLine(abc4);

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

                    Accounts accounts = new Accounts();


                    Console.WriteLine("                     PAY SLIP                 ");

                    Console.WriteLine("===============================================================================================");

                    Console.WriteLine(a + "                         " + b + "                              " + c);

                    Console.WriteLine("===============================================================================================");

                    Console.WriteLine($"Total Income  = {accounts.GetStaffTotalIncome(staffNur)}");
                    var abc1 = convertToWords.convertToWords(accounts.GetStaffTotalIncome(staffNur));
                    Console.WriteLine(abc1);
                    Console.WriteLine("===============================================================================================");

                    Console.WriteLine($" ShareToHospital  = {accounts.GetShareToHospital(staffNur)}");
                    var abc2 = convertToWords.convertToWords(accounts.GetShareToHospital(staffNur));
                    Console.WriteLine(abc2);

                    Console.WriteLine("===============================================================================================");

                    Console.WriteLine($" Net Income  = {accounts.GetStaffNetIncome(staffNur)}");
                    var abc3 = convertToWords.convertToWords(accounts.GetStaffNetIncome(staffNur));
                    Console.WriteLine(abc3);

                    Console.WriteLine("===============================================================================================");

                    Console.WriteLine($"Net Tax  = {accounts.GetTax(staffNur)}");
                    var abc4 = convertToWords.convertToWords(accounts.GetTax(staffNur));
                    Console.WriteLine(abc4);
                    Console.WriteLine("===============================================================================================");

                    Console.WriteLine($"Gross Income = {accounts.GetGrossIncome(staffNur)}");
                    var abc5 = convertToWords.convertToWords(accounts.GetGrossIncome(staffNur));
                    Console.WriteLine(abc5);
                    Console.WriteLine();
                    //break;
                }


               // else
                 //   Console.WriteLine($"Staff id {id11} is not registered, please register it first");
            }
            break;
        case 12:
            Console.WriteLine("enter doctor Education to search");

            string spl = Console.ReadLine();
            logic = new DoctorLogic();
            logic.searchdoctor(spl);
           

              //var abc = (Doctor)s.Value;
            break;
        case 13:
            Console.WriteLine("enter staff name to search type of staff ");

            string spl1 = Console.ReadLine();

            foreach (var s1 in HospitalDbStore.GlobalStaffStore.Values)
            {
                if (s1.StaffName == spl1)
                {
                    Console.WriteLine(s1.StaffCategory);
                }
            }

                break;

        case 14:

            Console.WriteLine("enter staff category to search");

            string str8 = Console.ReadLine();

            Console.WriteLine("enter location of staff to search");

            string str9 = Console.ReadLine();
            foreach (var s2 in HospitalDbStore.GlobalStaffStore.Values)
            {
                if(s2.StaffCategory == str8 && s2.Location == str9)
               {
                        if (Convert.ToString(s2.GetType()).Contains("Doctor"))
                        {
                            var a = (Doctor)s2;
                            // Doctor abcd = new Doctor();
                            Console.WriteLine(s2.StaffId + "    " + s2.StaffName + "    " + s2.Email + "      " + s2.DeptName + "     " + s2.Gender + "     " + s2.StaffCategory + "       " + s2.ContactNo + "       " + a.Education + "    " + a.Specilization);
                            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

                         }
                        else if (Convert.ToString(s2.GetType()).Contains("Nurse"))
                        {
                            var a = (Nurse)s2;
                            // Doctor abcd = new Doctor();
                            Console.WriteLine(s2.StaffId + "    " + s2.StaffName + "    " + s2.Email + "      " + s2.DeptName + "     " + s2.Gender + "     " + s2.StaffCategory + "       " + s2.ContactNo + "       " + a.Education + "    " + a.Experience);
                            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

                        }

                }

            }
    
          break;
        

    } //while (continueExecution == "y" || continueExecution == "Y") ;




    // Console.ReadLine();

} while (continueExecution == "y" || continueExecution == "Y");











