using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2;

namespace Day3
{
    public class Comparer<T> where T : struct 
    {
        //public bool CheckEquality(int a, int b)
        //{
        //    return a == b;
        //}
        //public bool CheckEquality(float a, float b)
        //{
        //    return a.Equals(b);
        //}
        


        public bool CheckEquality(T a, T b)
        {
            return a.Equals(b);
        }
    }
}
