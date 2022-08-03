// See https://aka.ms/new-console-template for more information
using CS_Events;

StaffLogic logic = new DoctorLogic();
Console.WriteLine("Hello, World!");

//Notification n1 = new Notification();
//EventListener listener = new EventListener(n1);


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
logic.RegisterStaff(d1);

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
logic.RegisterStaff(d2);

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
logic.RegisterStaff(d3);


//logic = new NurseLogic();
Nurse n3 = new Nurse()
{
    StaffId = 201,
    StaffName = "Mr. Bee",
    StaffCategory = "Nurse",
    Education = "xyz",
    Experience = 10,
    Email = "Abcd@gmail.com",
    DeptName = "Cancer",
    Gender = "female",
    ContactNo = 123,
};

logic.RegisterStaff(n3);

Nurse n2 = new Nurse()
{
    StaffId = 202,
    StaffName = "Neha",
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


    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:

            //Notification n1 = new Notification();
            //EventListener listener = new EventListener(n1);

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

            Notification n1 = new Notification();
            EventListener listener = new EventListener(n1);
            //staffId++;
            // Console.WriteLine("New Doctor Registered successfully");
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
                ContactNo = 123,

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
            //Console.WriteLine("Successfully deleted");

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
                    Console.WriteLine(s.Value.StaffId + "    " + s.Value.StaffName + "    " + s.Value.Email + "      " + s.Value.DeptName + "     " + s.Value.Gender + "     " + s.Value.StaffCategory + "       " + s.Value.ContactNo + "       " + a.Education + "    " + a.Specilization);
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                }

            }
            break;
    } //while (continueExecution == "y" || continueExecution == "Y") ;




    // Console.ReadLine();

} while (continueExecution == "y" || continueExecution == "Y");

