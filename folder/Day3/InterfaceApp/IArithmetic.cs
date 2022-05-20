using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.InterfaceApp
{
    // Interface is a contract (as it gives is a list of methods) which is implemented by the 
    // derived class

    /*
     Interfaces, by default, has all members be public
    interfaces can only have method declaration not implementation
    interfaces can not have constructors, abstract can
    interfaces cannot have variables
    interfaces can still have properties
    you cannot make instance of an interface like abstract.
    Interfaces can support multiple inheritance, classes cannot.
     */
    public interface IArithmetic<T> where T : struct
    {
        public void Addition(params T[] a);

        public void Substraction(params T[] a);
    }
}
