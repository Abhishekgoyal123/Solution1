// See https://aka.ms/new-console-template for more information
using Linq_Practice;

Console.WriteLine("Hello, World!");

EmployeeCollection employees = new EmployeeCollection();

DepartmentCollection Department = new DepartmentCollection();

//var MaxSalary = from emp in employees
//                join dep in Department on emp.DeptNo equals dep.DeptNo
//                group emp by dep.DeptName into DeptGroup

//                select new
//                {
//                    DeptName = DeptGroup.Key,
//                    //val = DeptGroup,
//                    Salary = DeptGroup.MaxBy(e => e.Salary),
//                };

//foreach( var s in MaxSalary)
//{
//    Console.WriteLine($"Max salary = { s.Salary.Salary} Dept name = {s.DeptName} Emp name = {s.Salary.EmpName} Emp no = {s.Salary.EmpNo}");
//}

//var MaxSalaryPerDept = from emp in employees
//                       join dep in Department on emp.DeptNo equals dep.DeptNo
//                       group emp by dep.DeptName into deptgroup

//                       select new
//                       {
//                           DeptName = deptgroup.Key,
//                           Sal = deptgroup.Sum(e => e.Salary)
//                       };

//foreach ( var a in MaxSalaryPerDept)
//{
//    Console.WriteLine($" Dept name = {a.DeptName} Salary = {a.Sal}");
//}

//var EmpDetails = from emp in employees
//                 join dep1 in Department on emp.DeptNo equals dep1.DeptNo
//                 group emp by dep1.DeptName into deptgroup



//                 select new
//                 {
//                     DName = deptgroup.Key,
//                     val = deptgroup

//                 };

//foreach( var b in EmpDetails)
//{

//    foreach( var c in b.val)
//    {
//        Console.WriteLine($" emp name = {c.EmpName} emp id = {c.EmpNo}");

//    }

//}

//var empcount = from emp in employees
//               join dep in Department on emp.DeptNo equals dep.DeptNo
//               group emp by dep.Location into deptgroup

//               select new
//               {
//                    DeptLocation = deptgroup.Key,
//                    val = deptgroup
//               };

//foreach( var d in empcount)
//{
//    //foreach( var e in d.val)
//    //{
//        Console.WriteLine($" emp dept = {d.DeptLocation} count = {d.val.Count()}");
//    //}
//}

//var empcoutPerDept = from emp in employees
//                     join dep in Department on emp.DeptNo equals dep.DeptNo
//                     group emp by dep.DeptName into deptgroup

//                     select new
//                     {
//                         DName = deptgroup.Key,
//                         val = deptgroup

//                     };

//foreach( var q in empcoutPerDept)
//{
//    Console.WriteLine($" dept = {q.DName} count ={q.val.Count()}");
//}


//var Asc = from emp in employees
//          join dep in Department on emp.DeptNo equals dep.DeptNo
//          orderby emp.EmpName ascending
//          group emp by dep.DeptName into deptgroup


//          select new
//          {
//              deptName = deptgroup.Key,
//              val = deptgroup
//          };

//foreach(var item in Asc)
//{
//    foreach(var a in item.val)
//    {
//        Console.WriteLine($"Emp no = {a.EmpNo} Emp name = {a.EmpName} emp sal = {a.Salary} designation = {a.Designation}"  );
//    }

//}

var AvgSalaryPerDept = from emp in employees
                       join dep in Department on emp.DeptNo equals dep.DeptNo
                       group emp by dep.DeptName into deptgroup

                       select new
                       {
                           Dname = deptgroup.Key,

                           AvgSal = deptgroup.Average(e => e.Salary),


                           val = deptgroup
                           
                       };

                        

foreach(var items in AvgSalaryPerDept)
{
    Console.WriteLine($"dept name = {items.Dname} avg sal = {items.AvgSal}");

    foreach( var a in items.val)
    {
        if(a.Salary> items.AvgSal)
        {
            Console.WriteLine($"emp name = {a.EmpName} salary = {a.Salary}");
        }
    }
    
}
         