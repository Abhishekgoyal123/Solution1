using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Events;


namespace CS_Events
{
    public delegate void NotificationEventHandler();


    public abstract class StaffLogic
    {
        public abstract void RegisterStaff(Staff statff);
        public abstract Dictionary<int, Staff> GetStatffs();
        public abstract Dictionary<int, Staff> UpdateStaffInfo(int id, Staff staff);

        public abstract Dictionary<int, Staff> DeleteStaffInfo(int id);

        public abstract void searchdoctor(string str);

       // public event NotificationEventHandler Registration;


        //public abstract void searchByName(string str);



        // public abstract Dictionary<int, Staff> DoctorIncome(int id, Staff staff);

        //public abstract decimal CalculateIncome(int id, Staff staff);

    }

    public class DoctorLogic : StaffLogic
    {
        public event NotificationEventHandler Registration_event;

        public override void RegisterStaff(Staff statff)
        {
            if (HospitalDbStore.GlobalStaffStore != null)
            {
                HospitalDbStore.GlobalStaffStore.Add(statff.StaffId, statff);

                Registration_event();
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
                //else
                //{
                //    Console.WriteLine("Record Not Found");
                //}

            }
            return HospitalDbStore.GlobalStaffStore;

        }

        public override Dictionary<int, Staff> DeleteStaffInfo(int id)
        {

            //Doctor searchedStaff;
            // Logic for Delete
            // 1. Serach the object
            //Doctor searchedStaff ;
            foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
            {
                if (s.Key == id)
                {
                    HospitalDbStore.GlobalStaffStore.Remove(id);
                    break;
                }
                // Dr_Dict.Remove(searchedStaff);
            }

            // 2. Delete
            // HospitalDbStore.GlobalStaffStore.Remove(id, out searchedStaff);
            //Console.WriteLine("Record deleted succesfully");

            return HospitalDbStore.GlobalStaffStore;
        }
        string str = "";
        public override void searchdoctor(string str)
        {
            string str1 = String.Empty;
            foreach (var s1 in HospitalDbStore.GlobalStaffStore.Values)
            {
                if (Convert.ToString(s1.GetType()).Contains("Doctor"))
                {
                    var a = (Doctor)s1;
                    // Doctor abcd = new Doctor();
                    if (a.Education == str)
                    {
                        Console.WriteLine(a.StaffName);

                    }

                }

            }
        }

      


    }





    public class NurseLogic : StaffLogic
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
                    Nurse x = (Nurse)staff;
                    x.StaffName = staff.StaffName;
                    Nurse y = (Nurse)staff;
                    x.Experience = y.Experience;

                    //s.Value.Email = doc.Email;
                }
                //else
                //{
                //    Console.WriteLine("Record Not Found");
                //}

            }
            return HospitalDbStore.GlobalStaffStore;

        }

        public override Dictionary<int, Staff> DeleteStaffInfo(int id)
        {

            //Doctor searchedStaff;
            // Logic for Delete
            // 1. Serach the object
            //Doctor searchedStaff ;
            foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
            {
                if (s.Key == id)
                {
                    HospitalDbStore.GlobalStaffStore.Remove(id);
                    break;
                }
                // Dr_Dict.Remove(searchedStaff);
            }

            // 2. Delete
            // HospitalDbStore.GlobalStaffStore.Remove(id, out searchedStaff);
            //Console.WriteLine("Record deleted succesfully");

            return HospitalDbStore.GlobalStaffStore;
        }

        public override void searchdoctor(string str)
        {
            string str1 = String.Empty;
            foreach (var s1 in HospitalDbStore.GlobalStaffStore.Values)
            {
                if (Convert.ToString(s1.GetType()).Contains("Nurse"))
                {
                    var a = (Nurse)s1;
                    // Doctor abcd = new Doctor();
                    if (a.Education == str)
                    {
                        Console.WriteLine(a.StaffName);

                    }

                }

            }
        }

    }
   
}



