using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Events;

namespace CS_Events
{ 

    public class notifications
    {
        StaffLogic sl;
        DoctorLogic dl;

        public notifications(DoctorLogic dl)
        {
            this.dl = dl;

            dl.Registration_event += Registration_notification;


        }

        private void Registration_notification()
        {
            Console.WriteLine("registration successfull");
        }
    }

}









