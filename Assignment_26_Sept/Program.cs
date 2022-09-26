// See https://aka.ms/new-console-template for more information
using Assignment_26_Sept;
using StaffLogic;
using Account;
using Data;
using System.Threading;
Console.WriteLine("Hello, World!");

StaffData sd = new StaffData();
sd.data();


operations op1 = new operations();


Thread t1 = new Thread(new ParameterizedThreadStart(op1.updateSalary));
t1.Start(StaffData.StaffList);
t1.Join();

foreach (var item1 in StaffData.StaffList)
{
    Console.WriteLine(item1.Salary);
}

Thread t2 = new Thread(new ParameterizedThreadStart(op1.Master));
t2.Start(StaffData.StaffList);
t2.Join();

Thread t3 = new Thread(new ParameterizedThreadStart(op1.salarySlip));
t3.Start(StaffData.StaffList);
t3.Join();




