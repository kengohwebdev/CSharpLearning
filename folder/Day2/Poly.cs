using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Hours { get; set; }
        public virtual void ShowHours()
        {
            Console.WriteLine("From Employees");
        }  
    }

    public class FullTime : Employees
    {
        public override void ShowHours()
        {
            Console.WriteLine("From FullTime");

            // Code below allows you to run the previous version of show hours alongside new version
            //base.ShowHours();
        }
        public void IdentityCrisis()
        {
            Console.WriteLine("Im Fulltime though");
        }
        public static int TotalFullTimeEmployee = 0;
    }

    // sealed vs static:
    // both cannot be inherited
    // sealed cass can have instances, static cannot
    // sealed classse can contain either static or nonstatic methods, but static classes 
    // can only constain static methods/variables
    public sealed class PartTime : Employees
    {

        public new void ShowHours()
        {
            Console.WriteLine("From PartTime");
        }

        //Method Overloading

        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b;
        }
        public string Add(string s, int a)
        {
            return a + s;
        }

        public string Add(int intAdd, string strAdd) //Formal Parameters
        {
            return intAdd + strAdd;
        }

        public void CallByName(string first, string second)
        {
            Console.WriteLine(first + second);
           
        }

        //Changing the number of parameters
        //Changing the data type of parameters
        //Changing the order of data types of parameters
        //You can change the returned data type as long as you change one of the three above
    }
}
