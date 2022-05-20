using Day4Exceptions;

namespace Day4Expections
{
    public class Program
    {
        //Exceptions are errors done in runtime
        public static void Main(string[] args)
        {
            try
            {
                //var i = Console.ReadLine();
                //int detect = Convert.ToInt32(i);
                //int letOver = checked(Int32.MaxValue + detect);
                Employee emp = new Employee();
                //emp.Age = 75;


            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (AgeException ex)
            {
                Console.WriteLine("This was our custom Excpetion");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("No matter what, i will run");
            }
            Console.WriteLine("Still running");


            //using (Connection)
            //{
            //    int o = 0;
            //}

            
        }
    }
}