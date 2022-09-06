using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_CSV.Entities;
using CS_CSV.Models;

namespace CS_CSV.Database
{
    public class HospitalDbStore
    {
        /// <summary>
        /// Global Store
        /// </summary>
        public static Dictionary<int, Staff>? GlobalStaffStore { get; set; } = new Dictionary<int, Staff>();

    }
}
