using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritence.Models
{
    public class Doctor : Staff
    {
        public Doctor()
        {
           // Console.WriteLine("CTOR for Doctor");
        }
        public string Specialization { get; set; } = String.Empty;
        public string DeptName { get; set; } = String.Empty;
        public string Gender { get; set; } = String.Empty;
        public string StaffCategory { get; set; } = String.Empty;

        //public string Education { get; set; } = String.Empty;
        //public int  ContactNo { get; set; } 

        public int Fees { get; set; }
        public int MaxPatientsPerDay { get; set; }

        


    }
}
