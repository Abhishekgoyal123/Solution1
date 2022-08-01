using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CS_Interface.Entities
{
    public class Staff
    {

        private int _StaffId;
        public int StaffId
        {
            get { return _StaffId; }
            set
            {
                foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
                {
                    if (value < 0)
                    {
                        Console.WriteLine("StaffId cannot be negative");
                        Console.WriteLine("Enter correct StaffId");
                        value = Convert.ToInt32(Console.ReadLine());
                        _StaffId = value;
                    }

                    else
                    {
                        _StaffId = value;
                    }
                }
                   
            }
        }
        //private string _StaffName;
        public string StaffName { get; set; }
        
        
        public string Email { get; set; } = string.Empty;
        public string DeptName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string StaffCategory { get; set; } = string.Empty;

        private int _ContactNo;
        public int ContactNo
        {
            get { return _ContactNo; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Contact number cannot be negative");
                    Console.WriteLine("Enter correct contact number");
                    value = Convert.ToInt32(Console.ReadLine());
                    ContactNo = value;
                }
                else
                {
                    _ContactNo = value;
                }
            }
        }


    }

    public class Doctor : Staff
    {

       
        public string Education { get; set; } = string.Empty;
        public string Specilization { get; set; } = string.Empty;

        //public int patientsDiagonsed { get; set; }

        private int _patientsDiagonsed;
        public int patientsDiagonsed
        {
            get { return _patientsDiagonsed; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("patientsDiagonsed cannot be negative");
                    Console.WriteLine("Enter correct patientsDiagonsed");
                    value = Convert.ToInt32(Console.ReadLine());
                    _patientsDiagonsed = value;
                }
                else
                {
                    _patientsDiagonsed = value;
                }
            }
        }

        //public int operationsPerDay { get; set; }

        private int _operationsPerDay;
        public int operationsPerDay
        {
            get { return _operationsPerDay; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("operationsPerDay cannot be negative");
                    Console.WriteLine("Enter correct operationsPerDay");
                    value = Convert.ToInt32(Console.ReadLine());
                    _patientsDiagonsed = value;
                }
                else
                {
                    _patientsDiagonsed = value;
                }
            }
        }


    }

    public class Nurse : Staff
    {
        //public int Experience { get; set; }

        private int _Experience;
        public int Experience
        {
            get { return _Experience; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Experience cannot be negative");
                    Console.WriteLine("Enter correct Experience");
                    value = Convert.ToInt32(Console.ReadLine());
                    _Experience = value;
                }
                else
                {
                    _Experience = value;
                }
            }
        }



        //public int InjectionApplied { get; set; }

        private int _InjectionApplied;
        public int InjectionApplied
        {
            get { return _InjectionApplied; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Injection Applied cannot be negative");
                    Console.WriteLine("Enter correct Injection Applied");
                    value = Convert.ToInt32(Console.ReadLine());
                    _InjectionApplied = value;
                }
                else
                {
                    _InjectionApplied = value;
                }
            }
        }

        //public int PatientsMonitored { get; set; }

        private int _PatientsMonitored;
        public int PatientsMonitored
        {
            get { return _PatientsMonitored; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Patients Monitored cannot be negative");
                    Console.WriteLine("Enter correct PatientsMonitored");
                    value = Convert.ToInt32(Console.ReadLine());
                    _PatientsMonitored = value;
                }
                else
                {
                    _PatientsMonitored = value;
                }
            }
        }
    }
}
