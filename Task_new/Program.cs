using Assignment_28_Sept;
using System.Diagnostics;
using System.Text.Json;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("USing Asynchronous operation");


var empList = new EmployeeList();

var timer = Stopwatch.StartNew();

Task task = Task.Factory.StartNew(() =>
{
    for (int i = 0; i < empList.Count; i++)
    {
        Console.WriteLine("hi");
        empList[i] = ProcessTax.CalculateTax(empList[i]);
    }

}).ContinueWith((t) =>
{
    Master();


}).ContinueWith((t) =>
{
    salarySlip();


});

Task.WaitAll();
var totalTime = timer.Elapsed.TotalMilliseconds;
Console.WriteLine($"Total Time = {totalTime}");
//=============================================================================================================================


//Task task = Task.Factory.StartNew(() =>
//{
//    for (int i = 0; i < empList.Count; i++)
//    {
//    Console.WriteLine("hi");
//    empList[i] = ProcessTax.CalculateTax(empList[i]);
//    }

//});


//Task t1 = Task.Factory.StartNew(() =>
//{
//    Master();

//});


//Task t2 = Task.Factory.StartNew(() =>
//{
//    salarySlip();
//});

//Task.WaitAll();

async void Master()
{
    // Monitor.Enter(locker);
    Console.WriteLine("hello");
    using (StreamWriter sw = new StreamWriter($@"C:\Assignment\Threading\Master.txt", true))
    {
        foreach (var item in empList)
        {
            await sw.WriteLineAsync(JsonSerializer.Serialize(item));
        }
    }
    //Monitor.Exit(locker);
}


async void salarySlip()
{

    foreach (var item in empList)
    {
        using (StreamWriter sw = new StreamWriter($@"C:\Assignment\Threading\{item.EmpNo}.txt", true))
        {
            await sw.WriteLineAsync($" Name: {item.EmpName}  \n salary: {item.Salary} \n tax = {item.TDS}");
        }
    }
}




Console.ReadLine();
