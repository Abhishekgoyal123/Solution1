using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq_Practice;

namespace Linq_Practice
{
    public class DepartmentData
    {
        public int DeptNo { get; set; }
       
        public string Location { get; set; }
        public int Capacity { get; set; }

        public String DeptName { get; set; }
    }
    public class DepartmentCollection : List<DepartmentData>
    {
        public DepartmentCollection()
        {
            Add(new DepartmentData() { DeptNo = 1, Location = "Pune", DeptName = "IT", Capacity = 1 });
            Add(new DepartmentData() { DeptNo =2, Location = "Mumbai", DeptName = "CTD", Capacity = 1 });
            Add(new DepartmentData() { DeptNo = 3, Location = "Kolkata", DeptName = "SYS", Capacity = 1 });
            Add(new DepartmentData() { DeptNo = 4, Location = "Delhi", DeptName = "HRD", Capacity = 1 });
           // Add(new DepartmentData() { DeptNo = 3, Location = "Pune", DeptName = "SYS", Capacity = 1 });
           // Add(new DepartmentData() { DeptNo = 2, Location = "Delhi", DeptName = "CTD", Capacity = 1 });
           // Add(new DepartmentData() { DeptNo = 1, Location = "Mumbai", DeptName = "IT", Capacity = 1 });
            //Add(new DepartmentData() { DeptNo = 5, Location = "Mumbai", DeptName = "ACCTS", Capacity = 1 });
            //Add(new DepartmentData() { DeptNo = 5, Location = "Delhi", DeptName = "ACCTS", Capacity = 1 });
            //Add(new DepartmentData() { DeptNo = 1, Location = "Pune", DeptName = "IT", Capacity = 1 });

        }
    }
}
