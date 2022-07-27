// See https://aka.ms/new-console-template for more information
using CS_OPPS;

Staff staff = new Staff();

StaffLogic logic = new StaffLogic();

var staffs9 = logic.GetAllStaff();

string continueExecution = "y";
do
{
    Console.WriteLine("1. New Staff Registration");
    Console.WriteLine("2. Update Staff Information");
    Console.WriteLine("3. Delete Staff Information");
    Console.WriteLine("4. Display record of all Staff");
    Console.WriteLine("5. Search record of a particular staff");

    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter ID of staff");
            staff.StaffId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name of staff");
            staff.StaffName = Console.ReadLine();
            Console.WriteLine("Enter Email of staff");
            staff.Email = Console.ReadLine();
            Console.WriteLine("Enter Department of staff");
            staff.DeptName = Console.ReadLine();
            Console.WriteLine("Enter Gender of staff");
            staff.Gender = Console.ReadLine();
            Console.WriteLine("Enter Category of staff");
            staff.StaffCategory = Console.ReadLine();
            Console.WriteLine("Enter Education of staff");
            staff.Education = Console.ReadLine();
            Console.WriteLine("Enter contact number of staff");
            staff.ContatNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("New Staff Registered successfully");
            logic.RegisterNewStaff(staff);
            break;

        case 2:
            Console.WriteLine("Enter Staff Id for which you want to update the record");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter details of staff to be updated");

            staff = new Staff()
            {
                StaffId = id,
                StaffName = Console.ReadLine(),
                Email = Console.ReadLine(),
                DeptName = "Pathology",
                Gender = "Male",
                DateOfBirth = new DateTime(1976, 9, 6),
                StaffCategory = "Technician",
                Education = "Bsc. Path",
                ContatNo = 77474996
            };


            var v=logic.UpdateStaffInfo(id, staff);
            Console.WriteLine("Record updated successfully");
            
            foreach(var s in staffs9)
            {
                Console.WriteLine(s.StaffId + "    " + s.StaffName + "    " + s.Email + "     " + "   " + s.DeptName + "      " + s.Gender + "     " + s.StaffCategory + "     " + s.Education + "    " + s.ContatNo);
               // Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            }
    //}


            break;

        case 3:
            Console.WriteLine("Enter Staff Id for which you want to delete the record");
            int id1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Record after deletion is: ");
            logic.DeleteStaff(id1);
            foreach (var s in staffs9)
            {
                Console.WriteLine(s.StaffId + "    " + s.StaffName + "    " + s.Email + "     " + "   " + s.DeptName + "      " + s.Gender + "     " + s.StaffCategory + "     " + s.Education + "    " + s.ContatNo);
                 Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            }
            break;
        case 4:
            
            foreach(var s in staffs9)
            {
                Console.WriteLine(s.StaffId +"    " +s.StaffName + "    " + s.Email + "     " + "   " + s.DeptName + "      " + s.Gender + "     " + s.StaffCategory + "     " + s.Education + "    "  +  s.ContatNo); 
                
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            }
            break;
        case 5:
            Console.WriteLine("Enter Staff Id for which you want to search the record");
            int id2 = Convert.ToInt32(Console.ReadLine());
            var st=logic.GetStaffById(id2);
            //foreach (var s in staffs9)
            {
                Console.WriteLine(st.StaffId + "    " + st.StaffName + "    " + st.Email + "     " + "   " + st.DeptName + "      " + st.Gender + "     " + st.StaffCategory + "     " + st.Education + "    " + st.ContatNo);
                //Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            }
    //}
                //Console.WriteLine(st.StaffName);
            break;

            Console.WriteLine("Please enter y or Y to continue");
            continueExecution = Console.ReadLine();
            Console.Clear();
    }

} while (continueExecution == "y" || continueExecution == "Y") ;

    Console.ReadLine();





