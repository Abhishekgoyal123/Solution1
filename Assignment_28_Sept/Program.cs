using Assignment_28_Sept;
using System.Diagnostics;
using System.Text.Json;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("USing Asynchronous operation");


var empList = new EmployeeList();
object locker = new object();


Master(empList);
//    salarySlip(empList[i]);

//for (int i = 0; i < empList.Count; i++)
//{
//    empList[i] = ProcessTax.CalculateTax(empList[i]);
//    Console.WriteLine($"Sequential Tax of {empList[i].EmpNo} {empList[i].EmpName} is = {empList[i].TDS}");
//    Master(empList[i]);
//    salarySlip(empList[i]);



//}

//Parallel.For(0, empList.Count, async (i) =>
//{

//    empList[i] = ProcessTax.CalculateTax(empList[i]);
//    Console.WriteLine($"Sequential Tax of {empList[i].EmpNo} {empList[i].EmpName} is = {empList[i].TDS}");
//    Master(empList[i]);
//    salarySlip(empList[i]);
//});


//Task task = Task.Factory.StartNew(() =>
//{
//    for (int i = 0; i < empList.Count; i++)
//    {
//        Master(empList[i]);
//    }

//});

static async void Master()
{
    object locker = new object();
    Monitor.Enter(locker);
    Console.WriteLine("hello");
    using (StreamWriter sw = new StreamWriter($@"C:\Assignment\Threading\Master.txt", true))
    {
           
        await sw.WriteLineAsync(JsonSerializer.Serialize(ob1));
    
    }
    Monitor.Exit(locker);
}


static async void salarySlip(Employee ob1)
{
    object locker = new object();
    Monitor.Enter(locker);
    using (StreamWriter sw = new StreamWriter($@"C:\Assignment\Threading\{ob1.EmpNo}.txt", true))
        {
            await sw.WriteLineAsync($" Name: {ob1.EmpName}  \n salary: {ob1.Salary} \n tax = {ob1.TDS}");
        }
    Monitor.Exit(locker);
}