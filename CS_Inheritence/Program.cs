// See https://aka.ms/new-console-template for more information
using CS_Inheritence.Models;
using CS_Inheritence.Logic;

Staff staff = new Staff();


var Doctor = new Doctor();
//Doctor doc = new Doctor();
int staffId = 1;
DoctorLogic logic = new DoctorLogic();
var Doc = logic.GetAllDoctor();


var Nurse = new Nurse();
int staffId1 = 1;
//Nurse Nur = new Nurse();
NurseLogic logic_Nur= new NurseLogic();
var nur = logic_Nur.GetAllNurse();

//var Dr = logic.GetAllDoctor();

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

            logic.RegisterNewDoctor(doc.StaffId, doc);
            //staffId++;
            Console.WriteLine("New Doctor Registered successfully");
            break;
        //Console.WriteLine(Staff.StaffName);


        case 2:
            Console.WriteLine("Enter Staff Id for which you want to update the record");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter details of staff to be updated");

            doc = new Doctor()
            {
                StaffId = id,
                StaffName = Console.ReadLine(),
                Email = Console.ReadLine(),
                DeptName = "Pathology",
                Gender = "Male",
                //DateOfBirth = new DateTime(1976, 9, 6),
                StaffCategory = "Technician",
                Education = "Bsc. Path",
                ContactNo = 77474996
            };

            var v = logic.UpdateNewDoctor(id, doc);
            Console.WriteLine("Record updated successfully");

            foreach (KeyValuePair<int, Doctor> s in Doc)
            {
                Console.WriteLine(s.Value.StaffId + "    " + s.Value.StaffName + "    " + s.Value.Email + "     " + "   " + s.Value.DeptName + "      " + s.Value.Gender + "     " + s.Value.StaffCategory + "     " + s.Value.Education + "    " + s.Value.ContactNo);
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            }

            break;
        case 3:
            int id5;
            Console.WriteLine("Enter the id to delete ");
            id5 = Convert.ToInt32(Console.ReadLine());
            logic.DeleteDoctor(id5);
            Console.WriteLine("Successfully deleted");

            break;
        case 4:
            foreach (KeyValuePair<int, Doctor> s in Doc)
            {
                Console.WriteLine(s.Value.StaffId + "    " + s.Value.StaffName + "    " + s.Value.Email + "     " + "   " + s.Value.DeptName + "      " + s.Value.Gender + "     " + s.Value.StaffCategory + "     " + s.Value.Education + "    " + s.Value.ContactNo);
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            }
            break;
        case 5:
            Console.WriteLine("Enter Staff Id for which you want to search the record");
            int id2 = Convert.ToInt32(Console.ReadLine());
             var st = logic.GetStaffById(id2);
            foreach(KeyValuePair<int , Doctor> s in st)
            {
                Console.WriteLine($"Staff name at the id {id2} is {s.Value.StaffName}");
            }

           // Console.WriteLine(st.StaffName );
            //Console.WriteLine("-----------------------------------------------------------------------------------------------------------");


            //Console.WriteLine(st.StaffName);
            break;
            

        case 6:
            Nurse Nur = new Nurse();
            Console.WriteLine("Enter ID of staff");
            Nur.StaffId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name of staff");
            Nur.StaffName = Console.ReadLine();
            Console.WriteLine("Enter Email of staff");
            Nur.Email = Console.ReadLine();
            Console.WriteLine("Enter Department of staff");
            Nur.DeptName = Console.ReadLine();
            Console.WriteLine("Enter Gender of staff");
            Nur.Gender = Console.ReadLine();
            Console.WriteLine("Enter Category of staff");
            Nur.StaffCategory = Console.ReadLine();
            Console.WriteLine("Enter Education of staff");
            Nur.Education = Console.ReadLine();
            Console.WriteLine("Enter contact number of staff");
            Nur.ContactNo = Convert.ToInt32(Console.ReadLine());

            logic_Nur.RegisterNewNurse(Nur.StaffId, Nur);
            Console.WriteLine("New Nurse Registered successfully");
            break;

        case 7:
            Console.WriteLine("Enter Staff Id for which you want to update the record");
            int id1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter details of staff to be updated");

            Nur = new Nurse()
            {
                StaffId = id1,
                StaffName = Console.ReadLine(),
                Email = Console.ReadLine(),
                DeptName = "Pathology",
                Gender = "Male",
                //DateOfBirth = new DateTime(1976, 9, 6),
                StaffCategory = "Technician",
                Education = "Bsc. Path",
                ContactNo = 77474996
            };

            var v1 = logic_Nur.UpdateNewNurse(id1, Nur);
            Console.WriteLine("Record updated successfully");

            foreach (KeyValuePair<int, Nurse> s in nur)
            {
                Console.WriteLine(s.Value.StaffId + "    " + s.Value.StaffName + "    " + s.Value.Email + "     " + "   " + s.Value.DeptName + "      " + s.Value.Gender + "     " + s.Value.StaffCategory + "     " + s.Value.Education + "    " + s.Value.ContactNo);
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            }

            break;

        case 8:
            break;
        case 9:
            foreach (KeyValuePair<int, Nurse> s in nur)
            {
                Console.WriteLine(s.Value.StaffId + "    " + s.Value.StaffName + "    " + s.Value.Email + "     " + "   " + s.Value.DeptName + "      " + s.Value.Gender + "     " + s.Value.StaffCategory + "     " + s.Value.Education + "    " + s.Value.ContactNo);
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            }
            break;
        case 10:
            break;
        case 11:
            Console.WriteLine("Play with Inheritence with BAsed and Derived classes");

            //StaffLogic sLogic = new StaffLogic(10000);
            //Console.WriteLine($"Staff Income =  {sLogic.CalculateIncome()}");


            //DoctorLogicabcd dLogic = new DoctorLogicabcd(50000, 500, 10);
            // Console.WriteLine($"Doctro Income is = {dLogic.CalculateIncome()}");

            // Lets Type-Cast the DoctorLogic instance to StaffLogic
            // Polymorphic behavior to method using an Instance Casting
            // var income = ((StaffLogic)dLogic).CalculateIncome();
            //Console.WriteLine($"Income = {income}");

            Console.WriteLine();
            Console.WriteLine("Using An Accountant GAteway to Get an INome");
            Console.WriteLine("Enter staff id to Get an INome");
            int id11 = Convert.ToInt32(Console.ReadLine());

            logic.DoctorIncome(id11);
           /* Accounts accounts = new Accounts();
            StaffLogicAbstract staffabcd = new DoctorLogicEx(id11, 300, 4);

           


                if (id11 >= 1 && id11 <= 100)
            {
                //StaffLogicAbstract staffabcd = new DoctorLogicEx(id11, 300, 4);

                //Accounts accounts = new Accounts();

                Console.WriteLine($"Net Income for Doctor with staff id {id11} = {accounts.GetStaffIncome(staffabcd)}");
                Console.WriteLine();
                //break;
            }
            if (id11 >= 101 && id11 <= 200)
            {
                staffabcd = new NurseLogicEx(id11,1000, 60);

                Console.WriteLine($"Net Income for Nurse with Staff is {id11} = {accounts.GetStaffIncome(staffabcd)}");
            }

            else
                Console.WriteLine($"Staff id {id11} is not registered, please register it first");*/
            break;


    } //while (continueExecution == "y" || continueExecution == "Y") ;




   // Console.ReadLine();

} while (continueExecution == "y" || continueExecution == "Y");

Console.ReadLine();

