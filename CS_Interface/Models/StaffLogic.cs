using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Interface.Models;
using CS_Interface.Logic;
using CS_Interface.Entities;


namespace CS_Interface.Models
{

    public class DoctorLogic : IDbOperations<Doctor,int>
    {

        void IDbOperations<Doctor, int>.Create(int id,Doctor entity)
        {
            if (HospitalDbStore.GlobalStaffStore != null)
            {
                HospitalDbStore.GlobalStaffStore.Add(id, entity);
            }
            //return HospitalDbStore.GlobalStaffStore;
        }

        Dictionary<int, Staff> IDbOperations<Doctor, int>.Delete(int id)
        {
            foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
            {
                if (s.Key == id)
                {
                    HospitalDbStore.GlobalStaffStore.Remove(id);
                    break;
                }
            }

           
            return HospitalDbStore.GlobalStaffStore;
        }

        //Doctor IDbOperations<Doctor, int>.Get(int id)
        //{
        //    throw new NotImplementedException();
        //}

        Dictionary<int ,Staff> IDbOperations<Doctor, int>.GetAll()
        {
            return HospitalDbStore.GlobalStaffStore;
        }

        Dictionary<int, Staff> IDbOperations<Doctor, int>.Update(int id, Doctor entity)
        {

            foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
            {
                if (s.Key == id)
                {
                    var a = (Doctor)s.Value;
                    a.StaffName = Console.ReadLine();
                    ///var st = (Doctor)s.Value;
                    a.Specilization = Console.ReadLine();

                    //s.Value.Email = doc.Email;
                }
                //else
                //{
                //    Console.WriteLine("Record Not Found");
                //}

            }
            return HospitalDbStore.GlobalStaffStore;
        }
       
    }

    public class NurseLogic : IDbOperations<Nurse, int>
    {

        void IDbOperations<Nurse, int>.Create(int id, Nurse entity)
        {
            if (HospitalDbStore.GlobalStaffStore != null)
            {
                HospitalDbStore.GlobalStaffStore.Add(id, entity);
            }
            //return HospitalDbStore.GlobalStaffStore;
        }

        Dictionary<int, Staff> IDbOperations<Nurse, int>.Delete(int id)
        {
            foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
            {
                if (s.Key == id)
                {
                    HospitalDbStore.GlobalStaffStore.Remove(id);
                    break;
                }
            }


            return HospitalDbStore.GlobalStaffStore;
        }

        //Doctor IDbOperations<Doctor, int>.Get(int id)
        //{
        //    throw new NotImplementedException();
        //}

        Dictionary<int, Staff> IDbOperations<Nurse, int>.GetAll()
        {
            return HospitalDbStore.GlobalStaffStore;
        }

        Dictionary<int, Staff> IDbOperations<Nurse, int>.Update(int id, Nurse entity)
        {

            foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
            {
                if (s.Key == id)
                {
                    var a = (Nurse)s.Value;
                    a.StaffName = Console.ReadLine(); 
                    ///var st = (Doctor)s.Value;
                   

                    //s.Value.Email = doc.Email;
                }
                //else
                //{
                //    Console.WriteLine("Record Not Found");
                //}

            }
            return HospitalDbStore.GlobalStaffStore;
        }

    }


}
