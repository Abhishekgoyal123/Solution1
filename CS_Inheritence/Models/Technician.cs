using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritence.Models
{
    public class Technician : Staff
    {
        public Technician()
        {
            Console.WriteLine("CTOR for Nurse");
        }
        public string Specialization { get; set; } = String.Empty;
        public int Technician_BasicFees { get; set; }
        
        public int Technician_WorkingHours { get; set; }

        


    }
}
