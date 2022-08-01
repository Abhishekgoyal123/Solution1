// See https://aka.ms/new-console-template for more information
using CS_Linq;

Console.WriteLine("Hello, World!");

EmployeeCollection employees = new EmployeeCollection();

DepartmentCollection Department = new DepartmentCollection();

var sumlgroupbydeptname = (from emp in employees

                           join DeptNo in Department on emp.DeptNo equals DeptNo.DeptNo
                           //join DeptNo in employees on emp.DeptNo equals Department.
                           // Group on DeptNAme ponuted by the deptgroup
                           group emp by DeptNo.DeptName into deptgroup
                           

                           //where Salary = Max
                           // selecting each record from each group to calculate Sum of salary
                           // and stored it in Anonymous Type



                           select new
                           {

                               DeptName = deptgroup.Key, // The Group Name

                               val = deptgroup,
                               Salary = deptgroup.MaxBy(e => e.Salary),



                           }).ToList(); // COnvert the result into List




    foreach (var item in sumlgroupbydeptname) 
    {  
               Console.WriteLine($"DeptName = {item.DeptName} and Salary = {item.Salary.Salary}   {item.Salary.EmpName}   {item.Salary.EmpNo} ");
       //break;
       // }
    }

Console.WriteLine("---------------------------------------------------");

var MaxSalaryBydept = (from emp in employees

                       join DeptNo in Department on emp.DeptNo equals DeptNo.DeptNo

                       //join DeptNo in employees on emp.DeptNo equals Department.
                       // Group on DeptNAme ponuted by the deptgroup
                       group emp by DeptNo.DeptName into deptgroup

                       //where Salary = Max
                       // selecting each record from each group to calculate Sum of salary
                       // and stored it in Anonymous Type



                       select new
                       {

                           DeptName = deptgroup.Key, // The Group Name

                           val = deptgroup ,
                           Salary = deptgroup.Sum(e => e.Salary),



                       }) .ToList();


foreach (var item in MaxSalaryBydept)
{
    //foreach(var v in item.val)
    {
        Console.WriteLine($"DeptName = {item.DeptName} and Salary = {item.Salary} ");
    }
}


Console.WriteLine("---------------------------------------------------");

var Empdetails = (from emp in employees

                  join DeptNo in Department on emp.DeptNo equals DeptNo.DeptNo
                  //join DeptNo in employees on emp.DeptNo equals Department.
                  // Group on DeptNAme ponuted by the deptgroup
                  group emp by DeptNo.DeptName into deptgroup


                  //where Salary = Max
                  // selecting each record from each group to calculate Sum of salary
                  // and stored it in Anonymous Type



                  select new
                  {

                      DeptName = deptgroup.Key, // The Group Name

                      val = deptgroup
                      //Salary = deptgroup.Max(e => e.Salary),



                  }); // COnvert the result into List




//foreach (var item in Empdetails)
//{
//    Console.WriteLine(item.DeptName);
//    foreach (var s in item.val)
//    {
//        Console.WriteLine($" EmpNo = {s.EmpNo}  Emp Name = {s.EmpName} DeptName = {item.DeptName} and Salary = {s.Salary} ");
//       // break;
//    }
   
//}

foreach(var items in Empdetails)
{
    foreach(var s in items.val)
    {
        Console.WriteLine($" EmpNo = {s.EmpNo}  Emp Name = {s.EmpName} DeptName = {items.DeptName} and Salary = {s.Salary} ");
    }
}

Console.WriteLine("---------------------------------------------------");

var CountPerLocation = from emp in employees

                        join DeptNo in Department on emp.DeptNo equals DeptNo.DeptNo
                        //join DeptNo in employees on emp.DeptNo equals Department.
                        // Group on DeptNAme ponuted by the deptgroup
                        group emp by DeptNo.Location into deptgroup



                        //where Salary = Max
                        // selecting each record from each group to calculate Sum of salary
                        // and stored it in Anonymous Type



                        select new
                        {

                            Location = deptgroup.Key, // The Group Name

                            val = deptgroup,



                            //Salary = deptgroup.Max(e => e.Salary),



                        };

foreach (var item in CountPerLocation)
{
    Console.WriteLine($"Location = {item.Location}");
    Console.WriteLine($"Location Count = {item.val.Count()}");
}


var PerLocation = from emp in employees

                        join DeptNo in Department on emp.DeptNo equals DeptNo.DeptNo
                        //join DeptNo in employees on emp.DeptNo equals Department.
                        // Group on DeptNAme ponuted by the deptgroup
                        group emp by DeptNo.Location into deptgroup



                        //where Salary = Max
                        // selecting each record from each group to calculate Sum of salary
                        // and stored it in Anonymous Type



                        select new
                        {

                            Location = deptgroup.Key, // The Group Name

                            val = deptgroup,



                            //Salary = deptgroup.Max(e => e.Salary),



                        };

foreach (var items in PerLocation)
{
    Console.WriteLine(items.Location);
    foreach (var s in items.val)
    {
        
        Console.WriteLine($" EmpNo = {s.EmpNo}  Emp Name = {s.EmpName} and Salary = {s.Salary} ");
        
    }
}

Console.ReadLine();
