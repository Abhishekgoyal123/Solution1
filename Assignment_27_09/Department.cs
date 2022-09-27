using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Models;
using Entities;

namespace Department
{
    public class DepartmentLogic
    {
        public int DeptNo { get; set; }

        public string DeptName { get; set; } = string.Empty;

        public String Location { get; set; } = string.Empty;

        public int Capacity { get; set; }


        public void RegisterDepartment(DepartmentLogic dept1)
        {
            if (HospitalDbStore.DepartmentInfo != null)
            {
                HospitalDbStore.DepartmentInfo.Add(dept1.DeptNo, dept1);
            }
        }

        public void Search()
        {
            bool isFound;
            Console.WriteLine("enter department to search");

            string dept = Console.ReadLine();

            foreach (var s1 in HospitalDbStore.DepartmentInfo.Values)
            {

                if (dept == s1.DeptName)
                {
                     isFound = true;
                    

                }
                else
                {
                     isFound = false;
                    
                }
                
            }
            
        }
    }
}

