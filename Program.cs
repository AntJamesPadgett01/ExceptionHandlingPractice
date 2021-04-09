using System;

namespace ExceptionHandlingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);

            }
            catch (DivideByZeroException e)  // you add the exception you are trying to catch.
            {

                Console.WriteLine(e.Message);
            }
            catch (FormatException e)          /// a bunch of C# exceptions can be used.
            {
                Console.WriteLine(e.Message);
                
            }

          

            
        }
    }
}
