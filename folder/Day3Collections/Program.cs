using Day3Collections.Entities;

namespace Day3Collections
{
    public class Program
    {

        public static void Main(string[] args)
        {
            //int[] arrInt = new int[]{ 4, 3, 2, 1 };

            //for (int i = 0; i < arrInt.Length; i++)
            //{
            //    Console.WriteLine( arrInt[i]);
            //}

            //foreach(int i in arrInt)
            //{
            //    Console.WriteLine( i);
            //}

            //var enumerator = arrInt.GetEnumerator();

            //var enumerator2 = arrInt.GetEnumerator(); //This is considered a different enumerator for the same array
            //enumerator2.MoveNext();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //    Console.WriteLine(enumerator2.Current); 
            //}

            ManageEmployee manageEmployee = new ManageEmployee();
            manageEmployee.AddEmployee();
            manageEmployee.PrintEmployees();


            Dictionary<string, Employee> empCollection = new Dictionary<string, Employee>();
            empCollection.Add("William", new Employee() { Id = 1, Name = "William", Salary = 9876, DeptId = 2, Age = 43 });
            foreach(var emp in empCollection)
            {
                Console.WriteLine(emp.Key + " " + emp.Value.Salary);
            }
            if (empCollection.ContainsKey("William")){
                empCollection.Remove("William");
            }
        }
    }
}