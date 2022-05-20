using Day3SampleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3SampleApp
{
    public class CustomerFactory
    {
        public BaseCustomer GetObject(int choice)
        {
            switch (choice)
            {
                case (int)Options.Customer:
                    return new Customers();
                case (int)Options.Visitor:
                    return new Visitor();
            }
            return null;
        }
    }
}
