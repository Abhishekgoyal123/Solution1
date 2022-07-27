using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CS_Search.Entities
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string DeptName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string StaffCategory { get; set; } = string.Empty;
        public int ContactNo { get; set; }


    }

    public class Doctor : Staff
    {

       
        public string Education { get; set; } = string.Empty;
        public string Specilization { get; set; } = string.Empty;

        public int patientsDiagonsed { get; set; }

        public int operationsPerDay { get; set; }
    }

    public class Nurse : Staff
    {
        public int Experience { get; set; }
    }
}
