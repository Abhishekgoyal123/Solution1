using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq_Practice;

namespace Linq_Practice
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }

        public int DeptNo { get; set; }
    }
    public class EmployeeCollection : List<Employee>
    {
        public EmployeeCollection()
        {
            Add(new Employee() { EmpNo = 1001, EmpName = "YashodaNandan", Designation = "Manager", Salary = 53000, DeptNo = 1 });
            Add(new Employee() { EmpNo = 1002, EmpName = "DevkiNandan", Designation = "Admin", Salary = 33000, DeptNo = 2 });
            Add(new Employee() { EmpNo = 1003, EmpName = "RadheShyam", Designation = "Developer", Salary = 63000, DeptNo = 3 });
            Add(new Employee() { EmpNo = 1004, EmpName = "Gopal", Designation = "Finance", Salary = 13000, DeptNo = 4 });
            Add(new Employee() { EmpNo = 1005, EmpName = "Govind", Designation = "Developer", Salary = 93000, DeptNo = 3 });
            Add(new Employee() { EmpNo = 1006, EmpName = "Mohan", Designation = "Developer", Salary = 63000, DeptNo = 2 });
            Add(new Employee() { EmpNo = 1007, EmpName = "Madhav", Designation = "Admin", Salary = 23000, DeptNo = 1 });
            Add(new Employee() { EmpNo = 1008, EmpName = "Milind", Designation = "manager", Salary = 53000, DeptNo = 4 });
            Add(new Employee() { EmpNo = 1009, EmpName = "Vasudev", Designation = "finance", Salary = 63000, DeptNo = 3 });
            Add(new Employee() { EmpNo = 1010, EmpName = "Shridhar", Designation = "Developer", Salary = 83000, DeptNo = 1 });


        }
    }
}
