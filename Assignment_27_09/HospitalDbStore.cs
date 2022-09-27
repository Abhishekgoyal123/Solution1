using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Entities;
using Department;

namespace Database
{
    public class HospitalDbStore
    {

        /// <summary>
        /// Global Store
        /// </summary>
        public static Dictionary<int, Staff>? GlobalStaffStore { get; set; } = new Dictionary<int, Staff>();

        public static Dictionary<int, DepartmentLogic>? DepartmentInfo { get; set; } = new Dictionary<int, DepartmentLogic>();
    }
}
