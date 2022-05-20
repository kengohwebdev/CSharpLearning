using Day3SampleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3SampleApp
{
    internal class Dashboard
    {
        Menu menu;
        CustomerFactory customerFactory;

        public Dashboard()
        {
            menu = new Menu();
            customerFactory = new CustomerFactory(); 
        }

        public void Run()
        {
            int choice = menu.Print();
            BaseCustomer b = customerFactory.GetObject(choice);
            b.LogInformation();

        }
    }
}
