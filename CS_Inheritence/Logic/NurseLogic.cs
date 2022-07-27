using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Inheritence.Models;

namespace CS_Inheritence.Logic
{
    public class NurseLogic
    {
        //List<Doctor> Doctors = new List<Doctor>();
        Dictionary<int, Nurse> Nur_Dict = new Dictionary<int, Nurse>();
        Nurse Nur = new Nurse();



        public Dictionary<int, Nurse> RegisterNewNurse(int id, Nurse nur)
        {
            Nur_Dict.Add(id, nur);
            return Nur_Dict;
        }

        public Dictionary<int, Nurse> UpdateNewNurse(int id, Nurse nur)
        {
            foreach (KeyValuePair<int, Nurse> s in Nur_Dict)
            {
                if (id == s.Value.StaffId)
                {
                    s.Value.StaffName = nur.StaffName;
                    s.Value.Email = nur.Email;
                }
                else
                {
                    Console.WriteLine("Record Not Found");
                }

            }

            return Nur_Dict;
        }

        public Dictionary<int, Nurse> DeleteNurse(int id)
        {
            // Logic for Delete
            // 1. Serach the object
            Staff searchedStaff = null;
            foreach (KeyValuePair<int, Nurse> s in Nur_Dict)
            {
                if (id == s.Value.StaffId)
                {
                    searchedStaff = Nur;
                    break;
                }
            }
            // 2. Delete
            //Dr_Dict.Remove();
            Console.WriteLine("Record deleted succesfully");

            return Nur_Dict;
        }
        public Dictionary<int, Nurse> GetAllNurse()
        {

            return Nur_Dict;
        }
        public Staff GetStaffById(int id)
        {
            // Search based on id if found return else return null
            Staff searchedStaff = null;
            foreach (KeyValuePair<int, Nurse> s in Nur_Dict)
            {
                if (id == s.Value.StaffId)
                {
                    searchedStaff = Nur;
                    break;
                }
            }
            return searchedStaff;
        }
    }
}

