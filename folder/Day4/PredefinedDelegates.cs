using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class PredefinedDelegates
    {
        /*
        Action: action takes any type of input but returns void
        Predicate: it takes any type of input but returns a boolean (used for condiitions)
        Func: can take in any input value and return any output
        */
        //Anonymous method:

        public void ActionExample()
        {
            Action<int> action = length =>
            {
                int a = 0, b = 1, c = 2;
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(a + " ");
                    c = a + b;
                    a = b;
                    b = c;
                }
            };

            Action<int> action2 = Fib;
            action(10);
            Console.WriteLine("-------------------");
            action2(10);
        }
        public void Fib(int length)
        {
            int a = 0, b = 1, c = 2;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
        }

        public void PredicateExample()
        {
            Predicate<string> isLongerThanTen = (str) =>
            {
                if (str.Length > 10) { return true; }
                return false;
            };
        }
        public void FuncExample()
        {
            Func<string, int, int> isLongerthanInt = (str, num) =>
            {
                if (str.Length > num) { return 1; }
                return 0;
            };

            List<int> lint = new List<int>();
            
        }
        
    }
}
