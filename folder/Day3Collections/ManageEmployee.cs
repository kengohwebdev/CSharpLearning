using Day3Collections.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Collections
{
    public class ManageEmployee
    {
        List<Employee> empCollection;
        public ManageEmployee()
        {
            empCollection = new List<Employee>();
        }

        public void AddEmployee()
        {
            Employee e = new Employee();
            e.Id = 1;
            e.Name = "smith";
            e.Salary = 1234;
            e.DeptId = 1;
            e.Age = 40;
            empCollection.Add(e);

            Employee e1 = new Employee()
            {
                Id = 2,
                Name = "Will",
                Salary = 4567,
                DeptId = 1,
                Age = 18
            };
            empCollection.Add(e1);

            empCollection.Add(new Employee() { Id = 3, Name = "Steven", Salary = 9876, DeptId =2, Age = 43});
        }
        public void PrintEmployees()
        {
            foreach (Employee e in empCollection)
            {
                Console.WriteLine($"{e.Id} \t {e.Name} \t {e.Age} \t {e.Salary} \t {e.DeptId} ");
            }
        }
    }
}
