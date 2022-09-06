using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
//using CS_Assignment.Entities;
//using CS_Assignment.Models;

namespace CS_New
{

    [Serializable]
    public class Staff
    {

        
        private int _StaffId;
        public int StaffId
        {
            get { return _StaffId; }
            set
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
        //private string _StaffName;
        public string StaffName { get; set; }


        
        
        public string Email { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;
        public string DeptName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string StaffCategory { get; set; } = string.Empty;

        //private int _ContactNo;
        //public int ContactNo
        //{
        //    get { return _ContactNo; }
        //    set
        //    {
        //    _ContactNo = value;
        //    }
        //}

        private int _ContactNo;
        public int ContactNo
        {
            get { return _ContactNo; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("ContactNo cannot be negative");
                    Console.WriteLine("Enter correct ContactNo");
                    value = Convert.ToInt32(Console.ReadLine());
                    _ContactNo = value;
                }
                else
                {
                    _ContactNo = value;
                }
            }
        }


    }

    [Serializable]
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
                    Console.WriteLine("patients Diagonsed cannot be negative");
                    Console.WriteLine("Enter correct patients Diagonsed");
                    value = Convert.ToInt32(Console.ReadLine());
                    _patientsDiagonsed = value;
                }
                else
                {
                    _patientsDiagonsed = value;
                }
            }
        }



       // public int operationsPerDay { get; set; }

        private int _operationsPerDay;
        public int operationsPerDay
        {
            get { return _operationsPerDay; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("patients Diagonsed cannot be negative");
                    Console.WriteLine("Enter correct patients Diagonsed");
                    value = Convert.ToInt32(Console.ReadLine());
                    _operationsPerDay = value;
                }
                else
                {
                    _operationsPerDay = value;
                }
            }
        }
    }






    [Serializable]
    public class Nurse : Staff
    {

   // public int Experience { get; set; }

        private int _Experience;
        public int Experience
        {
            get { return _Experience; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("patients Diagonsed cannot be negative");
                    Console.WriteLine("Enter correct patients Diagonsed");
                    value = Convert.ToInt32(Console.ReadLine());
                    _Experience = value;
                }
                else
                {
                    _Experience = value;
                }
            }
        }
       // public int InjectionApplied { get; set; }

        private int _InjectionApplied;
        public int InjectionApplied
        {
            get { return _Experience; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("patients Diagonsed cannot be negative");
                    Console.WriteLine("Enter correct patients Diagonsed");
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
                    Console.WriteLine("patients Diagonsed cannot be negative");
                    Console.WriteLine("Enter correct patients Diagonsed");
                    value = Convert.ToInt32(Console.ReadLine());
                    _PatientsMonitored = value;
                }
                else
                {
                    _PatientsMonitored = value;
                }
            }
        }

        public string Education { get; set; } = string.Empty;

    }
}
