using Day4SampleApp.Entities;
using Day4SampleApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4SampleApp.UI
{
    public class ManageDepartment
    {
        IRepository<Department> _repository;
        public ManageDepartment()
        {
            _repository = new DepartmentRepository();
        }

        void AddDepartment()
        {
            Department department = new Department();
            Console.Write("Enter Id: ");
            department.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            department.Name = Console.ReadLine();
            Console.Write("Enter Location: ");
            department.Location = Console.ReadLine();
            _repository.Insert(department);
            Console.WriteLine("Department Added Successfully");
        }

        void PrintAllDepartments()
        {
            IEnumerable<Department> depoList = _repository.GetAll();
            foreach(Department department in depoList)
            {
                Console.WriteLine($"{department.Id} \t {department.Name} \t {department.Location}");
            }
        }
        void DeleteDepartment()
        {
            Console.Write("Enter Id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            _repository.Delete(id);
            Console.WriteLine("Department Deleted Successfully");
        }
        void UpdateDepartment()
        {
            Department d = new Department();
            Console.Write("Enter Id = ");
            d.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            d.Name = Console.ReadLine();
            Console.Write("Enter Location: ");
            d.Location = Console.ReadLine();
            _repository.Update(d);
        }

        public void Run()
        {
            int choice = (int)Options.Exit;
            Menu m = new Menu();
            do
            {
                Console.Clear();
                choice = m.Print();
                switch (choice)
                {
                    case (int)Options.Insert:
                        AddDepartment();
                        break;
                    case (int)Options.Delete:
                        DeleteDepartment();
                        break;
                    case (int)Options.Print:
                        PrintAllDepartments();
                        break;
                    case (int)Options.Update:
                        UpdateDepartment();
                        break;
                    case (int)Options.Exit:
                        Console.WriteLine("Thanks for visiting !!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid value....");
                        break;
                }
                Console.WriteLine("Press Enter to Continue....");
                Console.ReadLine();

            } while (choice != (int)Options.Exit);
        }
    }
}
