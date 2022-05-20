using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLearning
{
    public class ManageEmployees
    {
        EmployeeRepository employeeRepository;
        public ManageEmployees()
        {
            employeeRepository = new EmployeeRepository();
        }

        public void Run()
        {
            
            Demo();
        }

        public Employee FunctionForSelect(Employee emp)
        {
            return emp;
        }
        public void Demo()
        {
            //Select * From Employees
            //
            //foreach(Employee emp in employeeRepository.GetEmployees())
            //{
            //    Console.WriteLine(emp);
            //}

            //Query Syntax
            /*var result = from employee in employeeRepository.GetEmployees()
                         select employee;*/
            //var result = employeeRepository.GetEmployees().Select(emp => emp).ToList();
            //var result = employeeRepository.GetEmployees().Select(FunctionForSelect).ToList();

            //foreach (var emp in result)
            //{
            //    Console.WriteLine(emp.Id + "\t" + emp.FullName + "\t" + emp.Salary + "\t" + emp.Department + "\t" + emp.Age);
            //}

            //Query Syntax
            //var result = from employee in employeeRepository.GetEmployees()
            //            select employee.FullName;
            //method syntax
            //var result = employeeRepository.GetEmployees().Select(emp => emp.FullName).ToList();

            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //query syntax
            //var result = from employee in employeeRepository.GetEmployees()
            //             select new
            //             {
            //                 Id = employee.Id,
            //                 FullName = employee.FullName,
            //                 Department = employee.Department
            //             };
            //var result = employeeRepository.GetEmployees()
            //    .Select(emp => new {Id = emp.Id, FullName = emp.FullName, Dept = emp.Department}).ToList();

            //foreach (var employee in result)
            //{
            //    Console.WriteLine(employee.FullName + " " + employee.Id + " " + employee.Dept);
            //}
            //var result = (from employee in employeeRepository.GetEmployees()
            //             select employee.Department).Distinct();

            //var result = employeeRepository.GetEmployees()
            //    .Select(emp => emp.Department).Distinct() ;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //var result = employeeRepository.GetEmployees().Select(emp => new { Id = emp.Id, FullName = emp.FullName, Dept = emp.Department })
            //    .SingleOrDefault(fod => fod.Dept == "IT") ?? new {Id = -1, FullName = "N/A", Dept = "N/A"};

            //Console.WriteLine(result.Id + " " + result.FullName + " " + result.Dept);


            //var result = from employee in employeeRepository.GetEmployees()
            //             orderby employee.Salary descending, employee.FullName descending
            //             select new
            //             {
            //                 Id = employee.Id,
            //                 FullName = employee.FullName,
            //                 Salary = employee.Salary
            //             };
            //var result2 = employeeRepository.GetEmployees().OrderByDescending(money => money.Salary)
            //    .ThenByDescending(x => x.FullName).Select(emp => new {Id = emp.Id, FullName = emp.FullName, Salary = emp.Salary});


            //Where filtering
            //var result = from employee in employeeRepository.GetEmployees()
            //             where employee.Salary > 7000 && employee.Department == "Sales"
            //             select new
            //             {
            //                 Id = employee.Id,
            //                 FullName = employee.FullName,
            //                 Salary = employee.Salary,
            //             };

            //var result2 = employeeRepository.GetEmployees().Where(x => x.Salary > 7000 & x.Department == "Sales")
            //    .Select(x => new { Id = x.Id, FullName = x.FullName, Salary = x.Salary });

            //foreach(var result3 in result)
            //{
            //    Console.WriteLine(result3);
            //    Console.WriteLine(result3);
            //}

            //var result = employeeRepository.GetEmployees().Any(x => x.Salary <= 4000);
            //Console.WriteLine(result);

            //query syntax
            /*
            var result = from employee in employeeRepository.GetEmployees()
                         group employee by employee.Department;

            var result2 = employeeRepository.GetEmployees().GroupBy(x => x.Department);
            foreach(var itemGroup in result)
            {
                Console.WriteLine(itemGroup.Key);
                foreach(var emp in itemGroup)
                {
                    Console.WriteLine(emp.FullName);
                }
                Console.WriteLine();
            }
            */

            //Aggregation:
            var result = employeeRepository.GetEmployees().Average(x => x.Salary);
            Console.WriteLine(result) ;

            var result1 = employeeRepository.GetEmployees().GroupBy(x => x.Department).Select(x => new
            {
                Department = x.Key,
                TotalSalary = x.Sum(e => e.Salary),
                AverageSalary = Math.Round(x.Average(e => e.Salary), 2)
            }).OrderBy(x => x.Department);
            foreach(var item in result1)
            {
                Console.WriteLine(item.Department + "\t" + item.TotalSalary + "\t" + item.AverageSalary);
            }
        }
    }
}
