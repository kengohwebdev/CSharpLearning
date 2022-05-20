using Day3SampleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3SampleApp
{
    public class CustomerService
    {
        BaseCustomer baseCustomer;
        CustomerFactory customerFactory;
        CustomerService(int choice)
        {
            customerFactory = new CustomerFactory();
            baseCustomer = customerFactory.GetObject(choice);
        }

        public BaseCustomer Create()
        {
            int id;
            string name;
            LogInformation(out id, out name);
            BaseCustomer baseCustomer = new Customers(id, name);
            return baseCustomer;

        }
        public void FillInformation()
        {
            LogInformation();
            
        }
        public void LogInformation(out int id, out string name)
        {
            Console.Write("Enter Id: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            name = Console.ReadLine();
        }
        public void LogInformation()
        {
            Console.Write("Enter Id: ");
            baseCustomer.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            baseCustomer.Name = Console.ReadLine();
        }

        public Object ConvertBack(BaseCustomer baseCustomer)
        {
            if (baseCustomer is Customers)
            {
                return (Customers)baseCustomer;
            }
            else
            {
                return (Visitor)baseCustomer;
            }
        }

    }
}
