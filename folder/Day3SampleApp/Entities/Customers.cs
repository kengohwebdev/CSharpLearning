using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3SampleApp.Entities
{
    public abstract class BaseCustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract void LogInformation();
    }
    public class Customers : BaseCustomer
    {
        public Customers()
        {

        }
        public Customers(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Spent { get; set; }
        public int ItemNum { get; set; }
        public override void LogInformation()
        {
            Console.Write("Enter Id: ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Money Spent? ");
            Spent = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many items? ");
            ItemNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Avg Item Price = {(double)Spent / ItemNum}");
        }
    }
    public class Visitor : BaseCustomer
    {
        public string Reason { get; set; }
        public override void LogInformation()
        {
            Console.Write("Enter Id: ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("REason to leave without Purchase? ");
            Reason = Console.ReadLine();
            Console.WriteLine(Reason);
        }
    }
}
