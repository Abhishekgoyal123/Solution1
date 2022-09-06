using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_New1.Entities;
using CS_New1.Models;

namespace CS_New1.Database
{
    public class HospitalDbStore
    {
        /// <summary>
        /// Global Store
        /// </summary>
        public static Dictionary<int, Staff>? GlobalStaffStore { get; set; } = new Dictionary<int, Staff>();

    }
}
