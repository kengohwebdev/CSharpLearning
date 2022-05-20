using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Exceptions
{
    public class AgeException : ApplicationException
    {
        public override string Message => "Age must be between 18-65";
    }

    public class Employee
    {

        public int Id { get; set; }
        public int Age
        {
            get { return Age; }

            set
            {
                if (value < 18 || value > 65) { throw new AgeException(); }
                Age = value;
            }
        }
    }
}
