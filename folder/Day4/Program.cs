// SampleApp
// Delegates
// var vs dynamic
// Anonymous types
// Exceptions
// Const vs Readonly

namespace Day4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ArithmeticOperations ao = new ArithmeticOperations();
            //MathDelegate math = new MathDelegate(ao.Addition);
            //the below clears stored function pointer
            //math = null;
            ////math(10, 20); //results in 30
            //math += ao.Subtraction;
            //math(10, 20);
            //ao.UseDelegate(math, 100, 50);

            ////Lambda functions: the ability to make anonymous methods with lambda opeators
            //math += (a, b) => { 
            //    Console.WriteLine(a + b);
            //    Console.WriteLine(a - b);
            //    Console.WriteLine(a * b);
            //};

            //PredefinedDelegates pd = new PredefinedDelegates();
            //pd.ActionExample();

            ManageEmployees m = new ManageEmployees();
            m.PrintEmployee();

            //you cannot modify var's datatype once it is set. For dynamic, you can
            //For var, it must be initialized, but dynamic does not need to be initialized
            var e = new ManageEmployees();
            //e = 10; //cannot be done

            dynamic c = 10;
            c = "19";

            var q ='A';
            q = 'C';
            dynamic d;

            //Read only
            //Anonymous types
            var customer = new { Id = 1, Name = "Smith", Email = "@gmail.com" };
            //customer.Name = "Harry";

            //Readonly vs const
            /*
             * both readonly and const can not be changed once they get a value
             * readonly can only be defined globally 
             * read only can only be changed in the constructor, but const cannot be changed anywhere
             * const cant be initialized, but readonly can because it can be changed in constructor
             * const is default static, readonly can be marked static
             */
        }
    }
}