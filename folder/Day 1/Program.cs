//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Day_1;
using System.Text;
using System.Collections.Generic;

namespace Day1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int a = 10;
            //string str = "Hello World";
            //double dub = 3.14d;
            //float flo = 123.456f;
            //decimal deciM = 987.654m;
            //bool flag = true;

            //double deel = 3.14;
            //int newInt = (int)deel;
            //string numString = Convert.ToString(newInt);
            ////Convert.ToString

            //string str2 = 5 + " hello there";
            //Console.WriteLine(str2);

            //double d1 = a * dub;

            //string str3 = str + " " + dub + " " + 5;
            //Console.WriteLine(str3);

            //string strInterpolation = $"{str} = {flo}";
            //Console.WriteLine(strInterpolation);

            // array built by array size
            //int[] array1 = new int[5];
            //array1[0] = 1;

            //// Array built by length and content
            //int[] array2 = new int[5] { 1, 2, 4, 5, 6 };

            //// array by content
            //int[] array3 = new int[] { 1, 2, 4, 5, 6 };

            ////omit of new
            //int[] array4 = { 1, 20, 7, 3, 6 };
            ////new creates an instance of an object. be used to create an object or instance of an object

            ////two dimentional arrayys
            //int[,] array5 = new int[2, 3];
            //int[,] array6 = { { 1, 2, 3 }, { 4, 5, 6 } };

            ////Jagged arrays: multiarrays that does not need to have the same length for each array in the multiarray
            //int[][] jaggedArray = new int[6][];
            //jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
            //jaggedArray[1] = new int[5] { 1, 2, 4, 5, 7 };


            ////for (int i = 0; i < array4.Length; i++)
            ////{
            ////    Console.WriteLine(array4[i]);
            ////}

            ////foreach (int i in array4)
            ////{
            ////    Console.WriteLine(i);
            ////}

            //Array.Sort(array4);
            //for (int i = 0; i < array4.Length; i++)
            //{
            //    Console.WriteLine(array4[i]);
            //}
            //Console.WriteLine(array4);

            ////value types: will directly hold value while memory tpyes will hold memory addressor reference for the value
            ////reference types : uses a pointer that points towards the address where content is stored in memory

            //int nullInt;
            //string nullString = null;

            //string immute = "helloworld";
            ////immute[0] = 'B';
            //Console.WriteLine(immute[0]);

            //StringBuilder strBui = new StringBuilder("helloworld");
            //strBui[0] = 'B';

            //immute = "this new String";
            //immute = immute + " more words";

            //// Boxing and Unboxing: aability to convert a value type to a reference type and vice versa
            //int box = 10;
            //object obj = box;
            //int unbox = (int)obj;

            ////Enums
            //int Monday = 1;
            //int Tuesday = 2;
            //int Wednesday = 3; 
            //int Thursday = 4;
            //int Friday = 5;
            //int Saturday = 6;
            //int Sunday = 7;

            string input = Console.ReadLine();
            //Console.WriteLine(input);
            int numberForDay;
            if(Int32.TryParse(input, out numberForDay))
            {
                Console.WriteLine(numberForDay);
            }
            else
            {
                Console.WriteLine("Input was not an acceptable value");
            }
            ////if(numberForDay == 5)
            ////{
            ////    Console.WriteLine("Friday");
            ////}

            //if(numberForDay == (int)DayOfWeek.Friday)
            //{
            //    Console.WriteLine(DayOfWeek.Friday);
            //}

            //[Access Modifier] [static] return-type MethodName ([Formal Paramters]){
            //}

            int a = 10;
            int b = 20;
            ParaPass para = new ParaPass();
            para.PassByValue(a, b);
            Console.WriteLine($" a = {a}, b = {b} sum = {a + b} Outside Function");

            //Pass By reference
            para.PassByRef(ref a, ref b);
            Console.WriteLine($" a = {a}, b = {b} sum = {a + b} Outside Function");

            para.AreaOfCircle(10);
            para.AreaOfCircle(10, 3);

            string msg = "";

            bool result = para.Author("bob", "smith", out msg);
            Console.WriteLine($"{result}  {msg}");

            Console.WriteLine(para.AddNumbers(10, 23, 45));

            //para.AddTwo(10, 20);


        }
    }
}


/*
Encapsulation
Inheritance
Abstraction
Polymorphism
 */