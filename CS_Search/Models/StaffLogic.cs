﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Search.Entities;
using CS_Search.Models;
using CS_Search.Database;

namespace CS_Search.Models
{
    public abstract class StaffLogic
    {
        public abstract void RegisterStaff(Staff statff);
        public abstract Dictionary<int, Staff> GetStatffs();
        public abstract Dictionary<int, Staff> UpdateStaffInfo(int id, Staff staff);

        public abstract Dictionary<int, Staff> DeleteStaffInfo(int id, Staff staff);

       

        // public abstract Dictionary<int, Staff> DoctorIncome(int id, Staff staff);

        //public abstract decimal CalculateIncome(int id, Staff staff);

    }

    public class DoctorLogic : StaffLogic
    {

        
        public override void RegisterStaff(Staff statff)
        {
            if (HospitalDbStore.GlobalStaffStore != null)
            {
                HospitalDbStore.GlobalStaffStore.Add(statff.StaffId, statff);
            }
        }
        public override Dictionary<int, Staff> GetStatffs()
        {
            return HospitalDbStore.GlobalStaffStore;
        }
        public override Dictionary<int, Staff> UpdateStaffInfo(int id, Staff staff)
        {
            foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
            {
                if (s.Key == id)
                {
                    var a = (Doctor)s.Value;
                    a.StaffName = staff.StaffName;
                    Doctor st = (Doctor)staff;
                    a.Specilization = st.Specilization;

                    //s.Value.Email = doc.Email;
                }
                else
                {
                    Console.WriteLine("Record Not Found");
                }

            }
            return HospitalDbStore.GlobalStaffStore;

        }

        public override Dictionary<int, Staff> DeleteStaffInfo(int id, Staff staff)
        {

            //Doctor searchedStaff;
            // Logic for Delete
            // 1. Serach the object
            //Doctor searchedStaff ;
            foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
            {
                if (s.Key == id)
                {
                    // searchedStaff = s.Value;
                    break;
                }
                // Dr_Dict.Remove(searchedStaff);
            }

            // 2. Delete
            // HospitalDbStore.GlobalStaffStore.Remove(id, out searchedStaff);
            //Console.WriteLine("Record deleted succesfully");

            return HospitalDbStore.GlobalStaffStore;
        }

        /*public override decimal CalculateIncome(int id, Staff staff)
        {
            foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
            {
                if (s.Key == id)
                {
                    Doctor st = (Doctor)staff;
                    decimal operationFees = st.operationsPerDay * 30 * 10000;
                    decimal patientsFessReceived = st.patientsDiagonsed * 30 * 500;
                    // Call BAse CLass Implementation to ger return value
                    decimal TotalIncome = base.CalculateIncome() + operationFees + patientsFessReceived;
                }

            }
            return TotalIncome;


        }*/

        


    }


        public class NurseLogic : StaffLogic
        {
        public decimal BasicPay = 0;

       
        public override void RegisterStaff(Staff statff)
            {
                if (HospitalDbStore.GlobalStaffStore != null)
                {
                    HospitalDbStore.GlobalStaffStore.Add(statff.StaffId, statff);
                }
            }
            public override Dictionary<int, Staff> GetStatffs()
            {
                return HospitalDbStore.GlobalStaffStore;
            }

            public override Dictionary<int, Staff> UpdateStaffInfo(int id, Staff staff)
            {
                foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
                {
                    if (s.Key == id)
                    {
                        Nurse x = (Nurse)staff;
                        x.StaffName = staff.StaffName;
                        Nurse y = (Nurse)staff;
                        x.Experience = y.Experience;

                        //s.Value.Email = doc.Email;
                    }
                    else
                    {
                        Console.WriteLine("Record Not Found");
                    }

                }
                return HospitalDbStore.GlobalStaffStore;

            }

            public override Dictionary<int, Staff> DeleteStaffInfo(int id, Staff staff)
            {

                //Doctor searchedStaff;
                // Logic for Delete
                // 1. Serach the object
                //Doctor searchedStaff ;
                foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
                {
                    if (s.Key == id)
                    {
                        // searchedStaff = s.Value;
                        break;
                    }
                    // Dr_Dict.Remove(searchedStaff);
                }

                // 2. Delete
                // HospitalDbStore.GlobalStaffStore.Remove(id, out searchedStaff);
                //Console.WriteLine("Record deleted succesfully");

                return HospitalDbStore.GlobalStaffStore;
            }

       

  


        }
}


