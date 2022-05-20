using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Selector
    {

        public Employees Deduct(Employees anyFullTimeEmployee, int hoursDeduct)
        {
            anyFullTimeEmployee.Hours = hoursDeduct;
            return anyFullTimeEmployee;
        }

        public void anyMethod(Employees e)
        {
            switch (e)
            {
                case (FullTime):
                    // code block
                    break;
                case (PartTime):
                    // code block
                    break;
                default:
                    // code block
                    break;
            }
        }

        public Employees Choice(int intChoice)
        {
            switch (intChoice)
            {
                case 0:
                    return new FullTime();
                    break;
                case 1:
                    return new PartTime();
                    break;
                default:
                    return new Employees();
                    break;
            }
        }
    }
}
