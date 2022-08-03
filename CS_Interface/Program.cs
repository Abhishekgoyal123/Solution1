// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



IDbOperations<Doctor, int> abcde = new DoctorLogic();
IDbOperations<Nurse, int> Nurs = new NurseLogic();


Doctor d1 = new Doctor()
{
    StaffId = 101,
    StaffName = "Dr. No",

    Education = "M.B.B.S",
    Specilization = "General Physician",
    Email = "Abcd@gmail.com",
    DeptName = "Cancer",
    Gender = "male",
    StaffCategory = "Doctor",
    ContactNo = 123,

};
abcde.Create(1, d1);

Doctor d2 = new Doctor()
{
    StaffId = 102,
    StaffName = "Dr. Deng",
    Education = "btech",
    Email = "Abcd@gmail.com",
    DeptName = "Cancer",
    Gender = "male",
    StaffCategory = "Doctor",
    ContactNo = 123,


};
abcde.Create(d2.StaffId,d2);

Doctor d3 = new Doctor()

{
    StaffId = 103,
    StaffName = "Abhishek",
    // StaffType = "Doctor",
    Education = "M.B.B.S",
    Specilization = "General Physician",
    Email = "Abcd@gmail.com",
    DeptName = "Cancer",
    Gender = "male",
    StaffCategory = "Doctor",
    ContactNo = 123,
};
abcde.Create(d3.StaffId, d3);


//logic = new NurseLogic();
Nurse n1 = new Nurse()
{
    StaffId = 201,
    StaffName = "Mr. Bee",
    StaffCategory = "Nurse",
    //Education = "xyz",
    Experience = 10,
    Email = "Abcd@gmail.com",
    DeptName = "Cancer",
    Gender = "female",
    ContactNo = 123,
};

Nurs.Create(n1.StaffId, n1);

Nurse n2 = new Nurse()
{
    StaffId = 202,
    StaffName = "Neha",
    StaffCategory = "Nurse",
    //Education = "xyz",
    Experience = 10,
    Email = "Abcd@gmail.com",
    DeptName = "Heart",
    Gender = "female",
    ContactNo = 123,
};

Nurs.Create(n2.StaffId, n2);

//var a = abcde.GetAll();



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

            // logic.RegisterStaff(doc);
            abcde.Create(doc.StaffId, doc);
            //staffId++;
            Console.WriteLine("New Doctor Registered successfully");
            break;

        case 2:
            Console.WriteLine("Enter Staff Id for which you want to update the record");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name and Specialization of staff to be updated");

            doc = new Doctor()
            {
                StaffId = id,
                //StaffName = Console.ReadLine(),
                //Specilization = Console.ReadLine(),
                Email = "Abcd@gmail.com",
                DeptName = "Cancer",
                Gender = "male",
                StaffCategory = "Doctor",
                ContactNo = 123,

                Education = "Bsc. Path",
                //Specilization = Console.ReadLine(),
            };

            var v = abcde.Update(id, doc);
            Console.WriteLine("Record updated successfully");


            break;

        case 3:
            int id5;
            Console.WriteLine("Enter the id to delete ");
            id5 = Convert.ToInt32(Console.ReadLine());
            abcde.Delete(id5);
            Console.WriteLine("Successfully deleted");

            break;

        case 4:
            foreach (var s in HospitalDbStore.GlobalStaffStore.Values)
            {
                if (Convert.ToString(s.GetType()).Contains("Doctor"))
                {
                    var ab = (Doctor)s;
                    Console.WriteLine(ab.StaffId + "    " + s.StaffName + "    " + s.Email + "      " + s.DeptName + "     " + s.Gender + "     " + s.StaffCategory + "       " + s.ContactNo + "       " + ab.Education + "    " + ab.Specilization);
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
                    Console.WriteLine(s.Value.StaffId + "    " + s.Value.StaffName + "    " + s.Value.Email + "      " + s.Value.DeptName + "     " + s.Value.Gender + "     " + s.Value.StaffCategory + "       " + s.Value.ContactNo + "       " + a.Education + "    " + a.Specilization);
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


            Nurs.Create(Nur.StaffId, Nur);
            Console.WriteLine("New Nurse Registered successfully");
            break;

        case 7:
            Console.WriteLine("Enter Staff Id for which you want to update the record");
            int id1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name of nurse to be updated");

            Nur = new Nurse()
            {
                StaffId = id1,
                //StaffName = Console.ReadLine(),
                //Experience = Convert.ToInt32(Console.ReadLine())
            };

           Nurs.Update(id1, Nur);

            Console.WriteLine("Record updated successfully");


            break;

        case 8:
            int id6;
            Console.WriteLine("Enter the id to delete ");
            id6 = Convert.ToInt32(Console.ReadLine());
            Nurs.Delete(id6);
            Console.WriteLine("Successfully deleted");
            break;
        case 9:
            foreach (var s in HospitalDbStore.GlobalStaffStore.Values)
            {
                if (Convert.ToString(s.GetType()).Contains("Nurse"))
                {
                    var a = (Nurse)s;
                    Console.WriteLine(s.StaffId + "    " + s.StaffName + "    " + s.Email + "      " + s.DeptName + "     " + s.Gender + "     " + s.StaffCategory + "       " + s.ContactNo + "       " + a.Experience);
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
                    Console.WriteLine(s.Value.StaffId + "    " + s.Value.StaffName + "    " + s.Value.Email + "      " + s.Value.DeptName + "     " + s.Value.Gender + "     " + s.Value.StaffCategory + "      " + a.Experience);
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

                    Accounts accounts = new Accounts();

                    Console.WriteLine("                     PAY SLIP                 ");

                    Console.WriteLine("===============================================================================================");

                    Console.WriteLine(a + "                         " + b + "                              " + c);

                    Console.WriteLine("===============================================================================================");
                    //Console.WriteLine(b);
                    //Console.WriteLine(c);

                   // Accounts accounts = new Accounts();

                    Console.WriteLine($"Total Income = {accounts.GetStaffTotalIncome(staffDoc)}");
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

                    //                    Console.WriteLine($"Net Income for {c} {b} with staff id {id11} = {accounts.GetStaffIncome(staffDoc)}");


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

                    // Console.WriteLine($"Net Income for {c} {b} with staff id {id11} = {accounts.GetStaffIncome(staffNur)}");


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
                    Console.WriteLine();
                    //break;
                }


                // else
                //   Console.WriteLine($"Staff id {id11} is not registered, please register it first");
            }
            break;
    
    }
    } while (continueExecution == "y" || continueExecution == "Y") ;



