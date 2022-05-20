using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    public class ParaPass
    {
        public int PassByValue(int a, int b)
        {
            a = 100;
            b = 200;
            Console.WriteLine($" a = {a}, b = {b} sum = {a + b} Inside Function");
            return a + b;
        }

        public int PassByRef( ref int a, ref int b)
        {
            a = 100;
            b = 200;
            Console.WriteLine($" a = {a}, b = {b} sum = {a + b} Inside Function");
            return a + b;
        }
        public int AreaOfCircle(double radius, double pi = 3.14)
        {
            Console.WriteLine($"Area of Circle = {radius * radius * pi}");
            return -10;
        }

        public bool Author(string uname, string pass, out string msg)
        {
            msg = "";
            if(uname == "bob" && pass == "smith")
            {
                msg = "verifed";
                return true;
            }else if(uname != "bob")
            {
                msg = "username is wrong";
                return false;
            }else if(pass != "smith")
            {
                msg = "password is wrong";
            }
            return false;
        }
        [Obsolete("Use AddNumbers Instead", true)]
        public int AddTwo( int a, int b)
        {
            return a + b;
        }
        public int AddThree(int a, int b, int c)
        {
            return a + b + c;
        }

        public int AddNumbers( params int[] arr)
        {

            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }
    }
}
