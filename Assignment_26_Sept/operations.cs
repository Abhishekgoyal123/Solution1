using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using StaffLogic;
using Account;
using Data;
using System.IO;

namespace Assignment_26_Sept
{
    public class operations
    {
        public List<Staff> l1 = new List<Staff>();
        public void updateSalary(object l1)
        {
            Console.WriteLine("Using An Accountant GAteway to Get an INome");
            Console.WriteLine("Enter staff id to Get an INome");
            int id11 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(StaffData.StaffList.Count);
            foreach (var item in (List<Staff>)l1)
            {

                if (item.StaffId == id11)
                {
                    Console.WriteLine("Hello");
                    Doctor doc1 = new Doctor();

                    Console.WriteLine("Enter total patients diagnosed  for doctor");
                    doc1.patientsDiagonsed = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter operations per day for doctor");
                    doc1.operationsPerDay = Convert.ToInt32(Console.ReadLine());

                    int a = item.StaffId;
                    string b = item.StaffName;
                    string c = item.StaffCategory;

                    StaffLogicAbstract staffDoc = new DoctorLogicEx(id11, doc1.patientsDiagonsed, doc1.operationsPerDay);

                    Console.WriteLine("                     PAY SLIP                 ");

                    Console.WriteLine("===============================================================================================");

                    Console.WriteLine(a + "                         " + b + "                              " + c);

                    Console.WriteLine("===============================================================================================");
                    //Console.WriteLine(b);
                    //Console.WriteLine(c);

                    Accounts accounts = new Accounts();

                    Console.WriteLine($"Total Income = {accounts.GetStaffTotalIncome(staffDoc)}");


                    Console.WriteLine("===============================================================================================");
                    Console.WriteLine($" ShareToHospital  = {accounts.GetShareToHospital(staffDoc)}");


                    Console.WriteLine("===============================================================================================");
                    Console.WriteLine($" Net Income  = {accounts.GetStaffNetIncome(staffDoc)}");


                    Console.WriteLine("===============================================================================================");
                    Console.WriteLine($"Net Tax  = {accounts.GetTax(staffDoc)}");


                    Console.WriteLine("===============================================================================================");
                    Console.WriteLine($"Gross Income  = {accounts.GetGrossIncome(staffDoc)}");



                    Console.WriteLine("===============================================================================================");
                    Console.WriteLine();


                    item.Salary = accounts.GetGrossIncome(staffDoc);

                    item.Tax = accounts.GetTax(staffDoc);

                    Console.WriteLine("updated lkist");



                }
            }

        }

        public void Master(object l1)
        {

            using (StreamWriter sw = new StreamWriter($@"C:\Assignment\Threading\Master.txt", true))
            {
                foreach (var item in (List<Staff>)l1)
                {
                    sw.WriteLine(JsonSerializer.Serialize(item));
                }
            }
        }

        public void salarySlip(object l1)
        {
            foreach(var item in (List<Staff>)l1)
            {
                using (StreamWriter sw = new StreamWriter($@"C:\Assignment\Threading\{item.StaffId}.txt", true))
                {
                    sw.WriteLine($" Name: {item.StaffName} \n Category : {item.StaffCategory} \n salary: {item.Salary} \n tax = {item.Tax}");
                }
            }


        }

    }

}



   
