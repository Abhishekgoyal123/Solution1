using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Inheritence.Models;

namespace CS_Inheritence.Logic
{
    public class StaffLogic
    {
        Dictionary<int, Staff> Staff_Dict = new Dictionary<int, Staff>();

        

        public Dictionary<int, Staff> RegisterNewStaff(Staff Staff)
        {
            //Staff_Dict.Add(StaffId, Staff Staff);
            Staff_Dict.Add(Staff.StaffId,Staff);
            return Staff_Dict;

        }

        protected decimal BasicPay = 0;

        public StaffLogic(decimal basicPay)
        {
            BasicPay = basicPay;
        }

        public decimal CalculateIncome()
        {
            return BasicPay;
        }
    }

    public class DoctorLogicabcd : StaffLogic
    {
        private int PatientsDiagonsed = 0;
        private int OperationsPerDay = 0;

        /// <summary>
        /// Calling the BAse Class CTOR and passing parameter to it
        /// </summary>
        /// <param name="sal"></param>
        /// <param name="patientsDiagonsed"></param>
        /// <param name="operationsPerDay"></param>
        public DoctorLogicabcd(decimal sal, int patientsDiagonsed, int operationsPerDay) : base(sal)
        {
            PatientsDiagonsed = patientsDiagonsed;
            OperationsPerDay = operationsPerDay;
        }

        /// <summary>
        /// Shadowed Method
        /// </summary>
        /// <returns></returns>
        public new decimal CalculateIncome()
        {
            decimal operationFees = OperationsPerDay * 30 * 10000;
            decimal patientsFessReceived = PatientsDiagonsed * 30 * 500;
            // Call BAse CLass Implementation to ger return value
            return base.CalculateIncome() + operationFees + patientsFessReceived;
        }

    }
}

 

