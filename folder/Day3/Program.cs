using Day3.InterfaceApp;

namespace Day3
{
    public class Program
    {
        //Extension methods: is a way to add new functionality into an existing type
        //LINQ and Dapper are based on Extension Methods

        //Generic

        //Abstract
        //Interfaces

        //SampleApp
        //Collections: Lists/Dictionaries/IEnumerable

        public static void Main(string[] args)
        {
            //int extensionInt = 10;
            //Console.WriteLine(extensionInt.IsEven());

            Comparer<int> comparer = new Comparer<int>();
            int a = 10;
            int b = 10;
            Console.WriteLine(comparer.CheckEquality(a, b));

            Comparer<double> comparer1 = new Comparer<double>();
            double da = 10.10;
            double da2 = 11.11;
            Console.WriteLine(comparer1.CheckEquality(da, da2));

            //Does not work since its not a struct but a class
            //Comparer<string> comparer2 = new Comparer<string>();

            // Shape s = new Shape();
            // IArithmetic<int> interfaceImp = new IArithmetic<int>();
            
        }
    }
}