using C44_G02_EFCore03.Context;
using C44_G02_EFCore03.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace C44_G02_EFCore03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var context = new CompanyDbContext();

            #region TPH


            #region PartTimeEmployee


            var partTime1 = new PartTimeEmployee
            {
                Name = "Ali",
                Email = "Ali.123@gmail.com",
                Adress = "Alex",
                HourWorked = 20,
                HourlyRate = 20,
            };

            var partTime2 = new PartTimeEmployee
            {
                Name = "Sara",
                Email = "Sara.456@gmail.com",
                Adress = "Cairo",
                HourWorked = 25,
                HourlyRate = 18,
            };

            var partTime3 = new PartTimeEmployee
            {
                Name = "Omar",
                Email = "Omar.789@gmail.com",
                Adress = "Giza",
                HourWorked = 30,
                HourlyRate = 22,
            };

            var partTime4 = new PartTimeEmployee
            {
                Name = "Mona",
                Email = "Mona.321@gmail.com",
                Adress = "Mansoura",
                HourWorked = 15,
                HourlyRate = 19,
            };

            var partTime5 = new PartTimeEmployee
            {
                Name = "Khaled",
                Email = "Khaled.654@gmail.com",
                Adress = "Tanta",
                HourWorked = 28,
                HourlyRate = 21,
            };
            #endregion

            #region FullTimeEmployee

       
            var fullTime1 = new FullTimeEmploee
            {
                Name = "Khaled",
                Email = "Khaled.654@gmail.com",
                Adress = "Tanta",
                MonthlySalary = 3500
            };

            var fullTime2 = new FullTimeEmploee
            {
                Name = "Sara",
                Email = "Sara.987@gmail.com",
                Adress = "Cairo",
                MonthlySalary = 4200
            };

            var fullTime3 = new FullTimeEmploee
            {
                Name = "Omar",
                Email = "Omar.123@gmail.com",
                Adress = "Alexandria",
                MonthlySalary = 3900
            };

            var fullTime4 = new FullTimeEmploee
            {
                Name = "Mona",
                Email = "Mona.456@gmail.com",
                Adress = "Giza",
                MonthlySalary = 4100
            };

            var fullTime5 = new FullTimeEmploee
            {
                Name = "Ali",
                Email = "Ali.789@gmail.com",
                Adress = "Mansoura",
                MonthlySalary = 3700
            };
            #endregion

            //context.AddRange(partTime1,partTime2,partTime3,partTime4,partTime5,fullTime1, fullTime2, fullTime3, fullTime4, fullTime5);
            //context.SaveChanges();

            //foreach ( var fullTime in context.Set<FullTimeEmploee>() )
            //{
            //    Console.WriteLine(fullTime);
            //}
            //Console.WriteLine();
            //foreach (var fullTime in context.FullTimeEmploees)
            //{
            //    Console.WriteLine(fullTime);
            //}
            //Console.WriteLine();
            //foreach (var fullTime in context.Employees.OfType<FullTimeEmploee>())
            //{
            //    Console.WriteLine(fullTime);
            //}
            //Console.WriteLine();


            #endregion


            #region TPCC
            //context.FullTimeEmploees.AddRange(fullTime1, fullTime2, fullTime3, fullTime4, fullTime5);
            //context.PartTimeEmployees.AddRange(partTime1, partTime2, partTime3, partTime4, partTime5);
            //context.SaveChanges();
            #endregion


            #region insert data & Related data


            //var dep1 = new Department { Name = "Human Resources" };
            //var dep2 = new Department { Name = "Finance" };
            //var dep3 = new Department { Name = "IT" };

            //var Employee1 = new List<Employee>
            //{
            //    new Employee () { Name = "ali" ,   Email = "Ali.123@gmail.com",Adress = "Alex"},
            //    new Employee () { Name = "Sara", Email = "Sara.456@gmail.com",Adress = "Cairo"},
            //    new Employee () { Name = "mohamed", Email = "mohamed.456@gmail.com",Adress = "Cairo"},
            //};

            //dep1.Employees = Employee1; 
            //context.Departments.Add(dep1);
            //context.SaveChanges();

            //var Employee2 = new List<Employee>
            //{
            //    new Employee () { Name = "dd" ,   Email = "dd.123@gmail.com",Adress = "Alex" , DepartmentId =1},
            //    new Employee () { Name = "ss", Email = "ss.456@gmail.com",Adress = "Cairo" , DepartmentId =1},
            //    new Employee () { Name = "drt", Email = "drt.456@gmail.com",Adress = "Cairo" , DepartmentId =1},
            //};

            //context.Employees.AddRange(Employee2 );
            //context.SaveChanges();


            //var Employee3 = new List<Employee>
            //{
            //    new Employee () { Name = "dd" ,   Email = "dd.123@gmail.com",Adress = "Alex" , Department = dep3},
            //    new Employee () { Name = "ss", Email = "ss.456@gmail.com",Adress = "Cairo" , Department = dep3},
            //    new Employee () { Name = "drt", Email = "drt.456@gmail.com",Adress = "Cairo" , Department =dep3},
            //};

            //context.Employees.AddRange(Employee3);
            //context.SaveChanges();
            #endregion


            #region Data seeding

            // var emp = JsonSerializer.Deserialize<List<Employee>>(@"");


            #endregion

            #region Loading data

            //1. Explcit Loading

            //var Employee = context.Employees.FirstOrDefault();
            //// Console.WriteLine($"Emplyee = {Employee?.Name?? "NA" } - Department => {Employee?.Department?.Name ?? "NA"}");

            //var department = context.Departments.First();

            ////refrence 
            //context.Entry(Employee).Reference(x => x.Department).Load();
            //context.Entry(department).Collection(x => x.Employees).Load();


            //2. Eager Loading

            //var Employeeeager = context.Employees.Include("Department").FirstOrDefault();
            //var Employeeeager2 = context.Employees.Include(x=> x.Department).FirstOrDefault();


            //3. projection

            //var Employeeeager3 = context.Employees.Select(emp => new
            //{
            //    emp.Name,
            //    emp.Email,
            //    emp.Adress,
            //    departmentname = emp.Department.Name,
            //    departmentid = emp.Department.Id
            //}).Where(x => x.departmentid == 1);

            //foreach (var emp in Employeeeager3)
            //{
            //    Console.WriteLine(emp);
            //}


            //lazy loading

            //var Employee = context.Employees.FirstOrDefault();
            //context.Entry(Employee).Reference(x => x.Department).Load();
            //Console.WriteLine($"Emplyee = {Employee?.Name ?? "NA"} - Department => {Employee?.Department?.Name ?? "NA"}");

            #endregion



            Console.ReadLine(); 
        }
    }
}
