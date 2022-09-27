// See https://aka.ms/new-console-template for more information
using Assignment_26_Sept;
using StaffLogic;
using Account;
using Data;
using System.Threading;
using System.Text.Json;
Console.WriteLine("Hello, World!");

StaffData sd = new StaffData();
sd.data();


operations op1 = new operations();


Thread t1 = new Thread(op1.updateSalary);
t1.Start(StaffData.StaffList);
t1.Join();

//foreach (var item1 in StaffData.StaffList)
//{
//    Console.WriteLine(item1.Salary);
//}

//Thread t2 = new Thread(new ParameterizedThreadStart(op1.Master));
//t2.Start(StaffData.StaffList);
//t2.Join();

//Thread t3 = new Thread(new ParameterizedThreadStart(op1.salarySlip));
//t3.Start(StaffData.StaffList);
//t3.Join();

//Parallel.For(0, StaffData.StaffList.Count, (i) =>
//{
//    //using (StreamWriter sw = new StreamWriter($@"C:\Assignment\Threading\Master.txt", true))
//    //{
//    //    foreach (var item in StaffData.StaffList)
//    //    {
//    //        sw.WriteLine(JsonSerializer.Serialize(item));
//    //    }
//    //}

//    //foreach (var item in StaffData.StaffList)
//    //{
//    //    using (StreamWriter sw = new StreamWriter($@"C:\Assignment\Threading\{item.StaffId}.txt", true))
//    //    {
//    //        sw.WriteLine($" Name: {item.StaffName} \n Category : {item.StaffCategory} \n salary: {item.Salary} \n tax = {item.Tax}");
//    //    }
//    //}

//    op1.Master(StaffData.StaffList);
//    op1.salarySlip(StaffData.StaffList);
//});

Parallel.Invoke(() =>
{
    op1.Master(StaffData.StaffList);
    op1.salarySlip(StaffData.StaffList);
});



