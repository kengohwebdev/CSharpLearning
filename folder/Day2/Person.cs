using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Person
    {
        public Person()
        {

        }
        public Person(string name)
        {

        }
        public int Id { get; set; }

        // Long version of Properties
        //private int _id;
        //public int Id
        //{
        //    get { return _id; }
        //    set
        //    {
        //        if (value > 10) { _id = value; }
        //        else { Console.WriteLine("get out of here with a low id number"); }
        //    }
        //}

        // read-only
        public string Name { get; private set; }
        //write-Only
        public int Receipt { private get; set; }

        public int GetReceipt()
        {
            FullTime.TotalFullTimeEmployee += 1;
            return Receipt;
        }

    }
}
