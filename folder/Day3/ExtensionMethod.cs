using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public static class ExtensionMethod
    {
        /*
         The class containing extension methods must be a static class
        The extension method must be a static method
        The first parameter must be of type which is being executed
        and must be written after "this" keyword
        */
        public static bool IsEven(this int x)
        {
            return x % 2 == 0;
        }

    }
}
