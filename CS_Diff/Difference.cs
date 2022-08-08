using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.TimeSpan;

namespace CS_Diff
{
    public class Difference
    {
        
        public  void GetDateDifference(DateTime StartDate, DateTime EndDate)
        {
            DateTime time;
            int Startdate = StartDate.Day;
            int Enddate = EndDate.Day;
            int hour = 0;
            int StartMin = StartDate.Minute;
            int EndMin = EndDate.Minute;

            int days = EndDate.Day - StartDate.Day;
            var months = EndDate.Month - EndDate.Month;
            var year  = StartDate.Year - EndDate.Year;

             if (StartDate.Day > EndDate.Day)
            {
                days = StartDate.Day - EndDate.Day;
            }

            if (EndDate.Day > StartDate.Day)
            {
                days = EndDate.Day - EndDate.Day;
            }

            if (StartDate.Hour > EndDate.Hour)
            {
                hour = StartDate.Hour - EndDate.Hour;
            }

            if (EndDate.Hour > StartDate.Hour)
            {
                hour = EndDate.Hour - StartDate.Hour;

            }

            if (hour > 24)
            {
                days++;
            }

            if(days > 30 || days > 31 )
            {
                months++;
            }

            if( days > 365 || months>12)
            {
                year++;
            }


            //var days = EndDate.Day - StartDate.Day;

            Console.WriteLine($" Year = {year} Months ={months} Days = {days} Hour = {hour}");
            //return ;

        }
        
    }
   
}
