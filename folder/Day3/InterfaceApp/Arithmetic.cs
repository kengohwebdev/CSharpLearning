using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.InterfaceApp
{
    public class Arithmetic : IArithmetic<int>, ISeconds<int>
    {
        void IArithmetic<int>.Addition(params int[] a)
        {
            int sum = 0;
            foreach(int i in a)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        void ISeconds<int>.Addition(params int[] a)
        {
            int sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public void Substraction(params int[] a)
        {
            int diff = a[0];
            for(int i = 1; i < a.Length; i++)
            {
                diff -= a[i];
            }
            Console.WriteLine(diff);
        }
    }
}
