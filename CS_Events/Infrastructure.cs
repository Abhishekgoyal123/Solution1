using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Events;

namespace CS_Events
{


    public delegate void NotificationEventHandler();

    public class Notification
    {
        int a = 5;

        
       

        public event NotificationEventHandler Registration;
        public event NotificationEventHandler Deletion;
        public void Register()
        {
           
            
            foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
            {

                //    var a = (Doctor)s.Value;
                int b = HospitalDbStore.GlobalStaffStore.Count;
                if (b>a)

               {
                    Registration();
                }
            }

            //foreach (var s in HospitalDbStore.GlobalStaffStore.Values)
            //{

            //    var a = (Doctor)s;

            //    if (a.StaffId == s.StaffId)

            //    {
            //        Registration();
            //    }
            //}

        }

        public void Delete()
        {

           // foreach (KeyValuePair<int, Staff> s in HospitalDbStore.GlobalStaffStore)
           //{

           //     var a = (Doctor)s.Value;

           //     if(s.Key != a.StaffId)

           //     {
           //         Deletion();
           //     }
           // }

            foreach (var s in HospitalDbStore.GlobalStaffStore.Values)
            {

                int b = HospitalDbStore.GlobalStaffStore.Count;
                if (b > a)

                {
                    Deletion();
                }
            }





        }


    }

    public class EventListener
    {
        private Notification n;

        public EventListener (Notification n)
        {
            this.n = n;
            n.Registration += n_Registration;
            n.Deletion += n_Deletion;
        }

            private void n_Registration()
        {
            Console.WriteLine("Registration sucessfull");
        }

        private void n_Deletion()
        {
            Console.WriteLine("Deletion sucessfull");
        }
    }
}
