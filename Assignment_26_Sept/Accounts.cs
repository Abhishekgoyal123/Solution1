
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_26_Sept;
using StaffLogic;
namespace Account
{
    public class Accounts
    {
        decimal NetIncome;

        decimal StaffTotalIncome;

        decimal GrossIncome;

        decimal Tax;
        /// <summary>
        /// Dynamic Polymorphism
        /// </summary>
        /// <param name="staff"></param>
        /// <returns></returns>
        public decimal GetStaffTotalIncome(StaffLogicAbstract staff)
        {
            StaffTotalIncome = staff.CalculateIncome();
            return StaffTotalIncome;

        }
        public decimal GetStaffNetIncome(StaffLogicAbstract staff)
        {
            NetIncome = staff.CalculateIncome() - staff.ShareToHospital();
            return NetIncome;
            
        }

        public decimal GetShareToHospital(StaffLogicAbstract staff)
        {
            decimal ShareToHospital = staff.ShareToHospital();
            return ShareToHospital;

        }

        public decimal GetTax(StaffLogicAbstract staff)
        {
             Tax = NetIncome * Convert.ToDecimal(0.1);
            return Tax;

        }

        public decimal GetGrossIncome(StaffLogicAbstract staff)
        {
             GrossIncome = NetIncome - Tax;
            return GrossIncome;

        }
    }
}

