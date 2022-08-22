using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CS_Search.Models;
using CS_Search.Logic;

namespace CS_Search.Logic
{
    
        public abstract class StaffLogicAbstract
        {
            protected decimal BasicPay = 0;

        public abstract decimal CalculateIncome();
            //{
              //  return this.BasicPay = 10000;
            //}

        public  virtual decimal CalculateBasicPay()
        {
            return this.BasicPay = 0;
        }
        public abstract decimal ShareToHospital();

        
        
        //public abstract decimal Tax();

        }
    

    public class DoctorLogicEx : StaffLogicAbstract
    {
        private int PatientsDiagonsed = 0;
        private int OperationsPerDay = 0;

        private decimal TotalIncome = 0;

        public override decimal CalculateBasicPay()
        {
            return BasicPay = 10000;
        }
        
        public DoctorLogicEx(int id, int patientsDiagonsed, int operationsPerDay)
        {
            PatientsDiagonsed = patientsDiagonsed;
            OperationsPerDay = operationsPerDay;
        }

        /// <summary>
        /// OVerrding Method
        /// </summary>
        /// <returns></returns>
       
        
        public override decimal CalculateIncome()
        {
            decimal operationFees = OperationsPerDay * 30 * 10000;
            
            decimal patientsFessReceived = PatientsDiagonsed * 30 * 500;
            
            // Call BAse CLass Implementation to ger return value
            TotalIncome = (CalculateBasicPay() *(Convert.ToDecimal(0.1))) + operationFees + patientsFessReceived;
            return TotalIncome;
            
           
        }
        public override decimal ShareToHospital()
        {
            decimal ShareToHospital = TotalIncome * Convert.ToDecimal(0.2);

            return ShareToHospital;
        }

        //public override decimal GrossIncome()
        //{
        //    decimal tax = TotalIncome * Convert.ToDecimal(0.2);
        //}

    }


    public class NurseLogicEx : StaffLogicAbstract
    {
        private decimal InjectionApplied = 0;
        private decimal PatientsMonitored = 0;

        private decimal GrossIncome = 0;

        public override decimal CalculateBasicPay()
        {
            return this.BasicPay = 5000;
        }
        public NurseLogicEx(int id,decimal injectionApplied, decimal patientsMonitored)
        {
            InjectionApplied = injectionApplied;
            PatientsMonitored = patientsMonitored;
        }

        public override decimal CalculateIncome()
        {
            decimal duetyFees = PatientsMonitored * 250;
            decimal injecionFees = InjectionApplied * 60;
            GrossIncome = CalculateBasicPay() + duetyFees + injecionFees;
            return GrossIncome;

        }

        public override decimal ShareToHospital()
        {
            return GrossIncome * Convert.ToDecimal(0.05);
        }
    }
}
