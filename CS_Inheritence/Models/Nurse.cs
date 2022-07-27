using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritence.Models
{
    public class Nurse : Staff
    {
        public Nurse()
        {
            //Console.WriteLine("CTOR for Nurse");
        }
        public string Specialization { get; set; } = String.Empty;
        public int Nurse_BasicFees { get; set; }
        public int NoOfMonitoring { get; set; }
        public int Nurse_Overtime { get; set; }
        public int Nurse_WorkingHours { get; set; }

        public string DeptName { get; set; } = String.Empty;
        public string Gender { get; set; } = String.Empty;
        public string StaffCategory { get; set; } = String.Empty;



    }

}
