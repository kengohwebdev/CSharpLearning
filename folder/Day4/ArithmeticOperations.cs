using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class ArithmeticOperations
    {
        readonly int intRead = 10;
        public void Addition(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Subtraction(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public int Multiply(int a , int b) //Does not work because return type does not match
        {
            return a * b;
        }

        public void Division(float a, float b) //does not work cause parameter type does not match
        {
            Console.WriteLine(a/b);
        }

        public void UseDelegate(MathDelegate del, int a, int b)
        {
            del(a, b);
        }
    }
}
