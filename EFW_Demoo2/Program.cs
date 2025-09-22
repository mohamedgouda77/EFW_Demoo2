using EFW_Demoo2.Contexts;
using EFW_Demoo2.Contexts.Models;
using Microsoft.EntityFrameworkCore;

namespace EFW_Demoo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using CompanyDbContext context = new CompanyDbContext();

            #region Add
            //Employee employee = new Employee
            //{

            //    Name = "Ahmed",
            //    Address = "Cairo",
            //    Age = 25,
            //    Test = 100,
            //    Salary = 6000,
            //    Password = "12345",              
            //};


            //context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;

            //Console.WriteLine(context.Entry(employee).State); //Detached

            //context.Add(employee);
            ////context.Add<Employee>(employee);
            ////context.Employees.Add(employee);
            ////context.Set<Employee>().Add(employee); 
            ////context.Entry<Employee>(employee).State = EntityState.Added;

            //Console.WriteLine(context.Entry(employee).State); //Added
            //Console.WriteLine($"Employee Id is {employee.Id} Before Saving");

            //context.SaveChanges();

            //Console.WriteLine(context.Entry(employee).State);
            //Console.WriteLine($"Employee Id is {employee.Id} After Saving");

            #endregion

            #region Retrieve
            ////var employee = context.Employees.AsNoTracking().FirstOrDefault(employee => employee.Id==5);
            //var employee = context.Employees.FirstOrDefault(employee => employee.Id == 5);
            //employee.Name = "Mohamed";
            ////Console.WriteLine(employee.Salary);

            //if (employee is not null)
            //{
            //    Console.WriteLine(context.Entry(employee).State);
            //    Console.WriteLine(employee.Name);
            //}
            #endregion

            #region Update

            //var employee = context.Employees.FirstOrDefault(employee => employee.Id == 5);
            //if (employee is not null)
            //{
            //    Console.WriteLine(context.Entry(employee).State);

            //    Console.WriteLine(employee.Name);
            //    employee.Name = "Mohamed";

            //    Console.WriteLine(context.Entry(employee).State);
            //    Console.WriteLine(employee.Name);

            //    context.SaveChanges();
            //    Console.WriteLine(context.Entry(employee).State);

            //}

            #endregion

            #region Delete
            //var employee = context.Employees.FirstOrDefault(employee => employee.Id == 5);
            //if (employee is not null)
            //{ 
            //  Console.WriteLine(context.Entry(employee).State);

            //    context.Remove(employee);
            //    //context.Remove<Employee>(employee);
            //    //context.Employees.Remove(employee);
            //    //context.Set<Employee>().Remove(employee); 
            //    //context.Entry<Employee>(employee).State = EntityState.Removed;
            //    Console.WriteLine(context.Entry(employee).State);
            //    context.SaveChanges();
            //    Console.WriteLine(context.Entry(employee).State);
            //}
            #endregion

            //var employee = context.Employees.FirstOrDefault(x => x.Id == 3);

            //if (employee is not null)
            //{

            //    Console.WriteLine($"Id=> {employee.Id}, Name => {employee.Name}, DeptName => {employee.Department.Name}");

            //}

            //var department = context.Departments.FirstOrDefault(x => x.DeptId == employee.DepartmentId);
            //Console.WriteLine($"DeptName => {department?.Name}");

            var employee = context.Employees.FirstOrDefault(x => x.Id == 3);

            if (employee is not null)
            {
                //context.Entry(employee).Reference(x => x.Department).Load();
                //var department = context.Departments.FirstOrDefault(x => x.DeptId == employee.DepartmentId);
                //context.Entry(department).Collection(x => x.Employees).Load();

                Console.WriteLine($"Id=> {employee.Id}, Name => {employee.Name}, DeptName => {employee.Department.Name}");

            }

            var query = (from emp in context.Employees.AsNoTracking()
                        join dept in context.Departments.AsNoTracking()
                        on emp.DepartmentId equals dept.DeptId
                        where dept.Name == "HR"
                        select new 
                        {
                           EmployeeName = emp.Name,
                           DepartmentName= dept.Name
                            
                        }).ToList();

            foreach (var item in query)
            {
                Console.WriteLine($"{item.EmployeeName} => {item.DepartmentName}");
            }
        }
    }
}
