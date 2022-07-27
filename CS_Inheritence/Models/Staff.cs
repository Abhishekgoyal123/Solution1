using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritence.Models
{
    public class Staff
    {
        public Staff()
        {
            //Console.WriteLine("CTOR for Staff");
        }
        //private int _StaffId;
        private int _StaffId;
        public int StaffId
        {
            get { return _StaffId; }
            set { _StaffId = value; }
        }
        
        public string StaffName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;

            private int _ContactNo;
        public int ContactNo
        {
            get { return _ContactNo; }
            set { _ContactNo = value; }
        }
        public string Education { get; set; } = String.Empty;
        public int ShiftStartTime { get; set; }
        public int ShiftEndTime { get; set; }
        
    }
}
