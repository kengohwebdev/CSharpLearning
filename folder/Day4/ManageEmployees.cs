using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class ManageEmployees
    {
        EmployeeRepository employeeRepository;
        public ManageEmployees()
        {
            employeeRepository = new EmployeeRepository();
        }

        public void PrintEmployee()
        {
            IEnumerable<Employee> employees = employeeRepository.GetDataByCondition(x => x.Name == "Olivia" && x.Department == "HR");
            foreach(Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name} \t {employee.Department} \t {employee.City}");
            }
        }
    }
}
