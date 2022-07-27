using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OPPS
{
    public class Staff
    {
        // Private Data Members 
        private int _StaffId;
        public int StaffId
        {
            get { return _StaffId; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("StaffId cannot be negative");
                    Console.WriteLine("Enter correct StaffId");
                    value = Convert.ToInt32(Console.ReadLine());
                    _StaffId = value;
                }
                else
                {
                    _StaffId = value;
                }
            }
        }

        private string _StaffName;
        public string StaffName
        {
            get { return _StaffName; }
            set {
                char[] arr = value.ToCharArray();
                for(int i=0;i<arr.Length;i++)
                {
                    int ascii = Convert.ToInt32(arr[i]);


                    if ((ascii >= 33 && ascii <= 47) || (ascii >= 58 && ascii <= 64)
                || (ascii >= 91 && ascii <= 96) || (ascii >= 123 && ascii <= 126))
                    {
                        Console.WriteLine("Special characters are not allowed");
                        Console.WriteLine("Enter correct Staff name without special characters");
                        value = Console.ReadLine();
                        _StaffName = value;
                    }
                    else
                    {
                        _StaffName = value;
                    }
                }
               
                 }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private string _DeptName;
        public string DeptName
        {
            get { return _DeptName; }
            set
            {

                List<string> str = new List<string>() { "Cancer", "Heart", "Pathology", "Radiology", "blood bank", "Organs", "orthopedic", "eye", "dental" };

                if (str.Contains(value))
                {
                    _DeptName = value;
                }
                else
                {
                    while(!str.Contains(value))
                    {
                        Console.WriteLine("enter correct Dept name");

                        value = Console.ReadLine();
                        _DeptName = value;
                    }
                    
                }
            }
        }

        private string _Gender;
        public string Gender
        {
            get { return _Gender; }
            set
            {
                _Gender = value;
            }
        }
        private DateTime _DateOfBirth;
        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set
            {
                _DateOfBirth = value;
            }
        }
        private string _StaffCategory;
        public string StaffCategory
        {
            get { return _StaffCategory; }
            set
            {

                
                List<string> str1 = new List<string>() { "Doctor", "Nurse", "Wardboy", "Brother", "Technician" };

                if (str1.Contains(value))
                {
                    _StaffCategory = value;
                }
                else
                {
                    while (!str1.Contains(value))
                    {
                        Console.WriteLine("enter correct Staff Category name");

                        value = Console.ReadLine();
                        _StaffCategory = value;
                    }


                }
            }
        }
        private string _Education;
        public string Education
        {
            get { return _Education; }
            set { _Education = value; }
        }
        private int _ContactNo;
        public int ContatNo
        {
            get { return _ContactNo; }
            set
            {
                _ContactNo = value;
            }
        }
    }


}
