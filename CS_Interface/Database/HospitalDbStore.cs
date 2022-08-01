using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CS_Interface.Database
{
    public class HospitalDbStore
    {
        /// <summary>
        /// Global Store
        /// </summary>
        public static Dictionary<int, Staff>? GlobalStaffStore { get; set; } = new Dictionary<int, Staff>();

    }
}
