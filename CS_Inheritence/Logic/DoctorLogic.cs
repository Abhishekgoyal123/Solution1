using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Inheritence.Models;

namespace CS_Inheritence.Logic
{
    public class DoctorLogic
    {
        //List<Doctor> Doctors = new List<Doctor>();
        Dictionary<int, Doctor> Dr_Dict = new Dictionary<int, Doctor>();
        Doctor doc = new Doctor();
        Doctor searchedStaff;



        public Dictionary<int, Doctor> RegisterNewDoctor(int id, Doctor doc)
        {
            /*int i = 0;
            for (int count = 0; count <= 10; count++)
            {
                //string name = Console.ReadLine();
                Dr_Dict.Add(doc.StaffId++, doc);
            }
            //Dr_Dict.Add(id, doc);*/

            //foreach (KeyValuePair<int, Doctor> s in Dr_Dict)
            //{
                Dr_Dict.Add(id, doc);
            
                return Dr_Dict;
        }

        public Dictionary<int, Doctor> UpdateNewDoctor(int id, Doctor doc)
        {
           foreach(KeyValuePair<int, Doctor> s in Dr_Dict)
            {
                if(s.Key==id)
                {
                    s.Value.StaffName = doc.StaffName;
                    s.Value.Email = doc.Email;
                }
                else
                {
                    Console.WriteLine("Record Not Found");
                }

            }
            
            return Dr_Dict;
        }

        public Dictionary<int, Doctor> DeleteDoctor(int id)
        {
            // Logic for Delete
            // 1. Serach the object
            //Doctor searchedStaff ;
            foreach (KeyValuePair<int, Doctor> s in Dr_Dict)
            {
                if (s.Key == id)
                {
                    searchedStaff = s.Value;
                    break;
                }
               // Dr_Dict.Remove(searchedStaff);
            }

            // 2. Delete
            Dr_Dict.Remove(id,out searchedStaff);
            //Console.WriteLine("Record deleted succesfully");

            return Dr_Dict;
        }

        public Dictionary<int, Doctor> GetAllDoctor()
        {
            
            return Dr_Dict;
        }


        public Dictionary<int, Doctor> GetStaffById(int id)
        {
            // Search based on id if found return else return null
           // Doctor searchedStaff = null;
            foreach (KeyValuePair<int, Doctor> s in Dr_Dict)
            {
                if (s.Key == id)
                {
                    return Dr_Dict;

                }

               // return Dr_Dict;
            }
            return Dr_Dict;
        }


        public Dictionary<int, Doctor> DoctorIncome(int id)
        {
            // Search based on id if found return else return null
            // Doctor searchedStaff = null;
            foreach (KeyValuePair<int, Doctor> s in Dr_Dict)
            {
                if (s.Key == id)
                {
                    StaffLogicAbstract staffabcd = new DoctorLogicEx(id, 300, 4);

                    Accounts accounts = new Accounts();

                    Console.WriteLine($"Net Income for Doctor with staff id {id} = {accounts.GetStaffIncome(staffabcd)}");
                    Console.WriteLine();

                }

                // return Dr_Dict;
            }
            return Dr_Dict;
        }


    }
}
