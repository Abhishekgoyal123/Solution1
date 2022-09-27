using Database;
using Models;
using Entities;
using Department;

StaffLogic logic = new DoctorLogic();

DepartmentLogic deptlogic = new DepartmentLogic();


Doctor d1 = new Doctor()

{
    StaffId = 101,
    StaffName = "Dr. No",
    DeptNo = 1,
    Education = "M.B.B.S",
    Specilization = "General Physician",
    Email = "Abcd@gmail.com",
    ////DeptName = "Cancer",
    Gender = "male",
    StaffCategory = "Doctor",
    ContactNo = 123,
};
logic.RegisterStaff(d1);

Doctor d2 = new Doctor()
{
    StaffId = 102,
    StaffName = "Dr. Deng",
    DeptNo= 2,
    Specilization = "Heart",
    Education = "btech",
    Email = "Abcd@gmail.com",
   // DeptName = "Heart",
    Gender = "male",
    StaffCategory = "Doctor",
    ContactNo = 123,


};
logic.RegisterStaff(d2);

Doctor d3 = new Doctor()

{
    StaffId = 103,
    StaffName = "Rahul",
     DeptNo =3,
    Education = "M.B.B.S",
    Specilization = "General Physician",
    Email = "Abcd@gmail.com",
    //DeptName = "Neuro",
    Gender = "male",
    StaffCategory = "Doctor",
    ContactNo = 123,
};
logic.RegisterStaff(d3);

Doctor d4 = new Doctor()

{
    StaffId = 104,
    StaffName = "Abhishek",
    DeptNo = 1,
    Education = "M.B.B.S",
    Specilization = "General Physician",
    Email = "Abcd@gmail.com",
    //DeptName = "Neuro",
    Gender = "male",
    StaffCategory = "Doctor",
    ContactNo = 123,
};
logic.RegisterStaff(d4);

DepartmentLogic d11 = new DepartmentLogic()
{
    DeptNo = 1,
    DeptName = "Cancer",
    Location = "Pune",
    Capacity = 100
};

deptlogic.RegisterDepartment(d11);

DepartmentLogic d12 = new DepartmentLogic()
{
    DeptNo = 2,
    DeptName = "Heart",
    Location = "Mumbai",
    Capacity = 200
};

deptlogic.RegisterDepartment(d12);

DepartmentLogic d13 = new DepartmentLogic()
{
    DeptNo = 3,
    DeptName = "Neuro",
    Location = "Delhi",
    Capacity = 300
};

deptlogic.RegisterDepartment(d13);



Console.WriteLine("enter department to search");

string dept = Console.ReadLine();

bool isFound = false;


var bgThread = new Thread(() =>
{
    
    foreach (var s1 in HospitalDbStore.DepartmentInfo.Values)
    {

        if (dept == s1.DeptName)
        {
            
             isFound = true;
            Console.WriteLine("dept found");

            var result = from doc in HospitalDbStore.GlobalStaffStore.Values
                         join d1 in HospitalDbStore.DepartmentInfo.Values on doc.DeptNo equals d1.DeptNo
                         where d1.DeptName == s1.DeptName
                         select doc;


            foreach(var item in result)
            {
                Console.WriteLine(item.StaffName);
            }
            break;
        }
        
        
            

    }
});
bgThread.IsBackground = true;
bgThread.Start();
bgThread.Join();

if (isFound == false)
{
    Console.WriteLine("dept not found");
}
