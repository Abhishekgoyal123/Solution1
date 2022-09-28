using Assignment_28_Sept;
using System.Diagnostics;
using System.Text.Json;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("USing Asynchronous operation");


var empList = new EmployeeList();



//for (int i = 0; i < empList.Count; i++)
//{
//    Task task = Task.Factory.StartNew(() =>
//    {

//        empList[i] = ProcessTax.CalculateTax(empList[i]);


//    });

//    Task t1 = Task.Factory.StartNew(() =>
//    {

//        Master(empList[i]);


//    });

//    Task t2 = Task.Factory.StartNew(() =>
//    {

//        salarySlip(empList[i]);


//    });


//}

//Task.WaitAll();


//============================================================================================================

var timer = Stopwatch.StartNew();
Task task = Task.Factory.StartNew(() =>
{
    for (int i = 0; i < empList.Count; i++)
    {
        empList[i] = ProcessTax.CalculateTax(empList[i]);
    }

}).ContinueWith((t) =>
{

    for (int i = 0; i < empList.Count; i++)
    {
        Master(empList[i]);
    }
}).ContinueWith((t) => {
    for (int i = 0; i < empList.Count; i++)
    {
        salarySlip(empList[i]);
    }


});

var totalTime = timer.Elapsed.TotalMilliseconds;

Console.WriteLine($"Total Time to read files = {totalTime}");


//===========================================================================


//Task t1 = Task.Factory.StartNew(() =>
//{
//    for (int i = 0; i < empList.Count; i++)
//    {
//        Master(empList[i]);
//    }

//});


//Task t2 = Task.Factory.StartNew(() =>
//{
//    for (int i = 0; i < empList.Count; i++)
//    {
//        salarySlip(empList[i]);
//    }

//});

//Task.WaitAll();

async void Master(Employee ob1)
{
   // Monitor.Enter(locker);
    Console.WriteLine("hello");
    using (StreamWriter sw = new StreamWriter($@"C:\Assignment\Threading\Master.txt", true))
    {

        await sw.WriteLineAsync(JsonSerializer.Serialize(ob1));

    }
    //Monitor.Exit(locker);
}


async void salarySlip(Employee ob1)
{
   // Monitor.Enter(locker);
    using (StreamWriter sw = new StreamWriter($@"C:\Assignment\Threading\{ob1.EmpNo}.txt", true))
    {
        await sw.WriteLineAsync($" Name: {ob1.EmpName}  \n salary: {ob1.Salary} \n tax = {ob1.TDS}");
    }
    //Monitor.Exit(locker);
}




Console.ReadLine();