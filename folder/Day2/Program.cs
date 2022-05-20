using System.Text;
using System.Collections.Generic;
using System;
using Day2;


namespace Day2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string name = "bob";
            //Person person = new Person();
            //person.Id = 1;
            //Console.WriteLine(person.Id);

            //Console.WriteLine(person._id);

            //person.Name = "bob";
            //Console.WriteLine(person.Name);

            //Inheritance:
            //Employees employees = new Employees();

            //FullTime fullTime = new FullTime();

            //fullTime.Work();
            
            //FullTime ft = new FullTime(1000);

            //Console.WriteLine(ft.Name);



            //Console.WriteLine(ft.T);


            //Polymorphism
            //PartTime partTime = new PartTime();
            //partTime.Add(9, 8);

            //partTime.Add(strAdd: "hello", intAdd : 4); //Actual parameters

            //partTime.CallByName(second: "hello", first : "no");

            //Upcasting 
            //Employees employees = new Employees();
            Employees fullT = new FullTime();
            //Employees partT = new PartTime();

            //employees.ShowHours();
            //fullT.ShowHours(); //Method overriding
            //partT.ShowHours(); //Method hiding

            //PartTime partT2 = new PartTime();
            //partT2.ShowHours();

            //FullTime fullT2 = new FullTime();
            //fullT2.ShowHours();

            ////Downcasting
            if(fullT is FullTime)
            {
                Console.WriteLine("This employee is actually FullTime");
                FullTime ft = (FullTime)fullT;
            }
            //else
            //{
            //    Console.WriteLine("This employee is not fulltime");
            //}
            //FullTime backToFull = (FullTime)fullT;
            //backToFull.IdentityCrisis();


            MathOper.Add(5, 10);
            Console.WriteLine(MathOper.PI);
            MathOper.PI = 10;
            Console.WriteLine(MathOper.PI);

            FullTime fullTime = new FullTime();
            FullTime.TotalFullTimeEmployee = 100;
        }


        
    }
}