using System;

namespace TryAndCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number!");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result; 
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("can't divide by zero");
            }

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("format exeception, please enter a number next time!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("exception: number is too long or short");
            }
            finally
            {
                Console.WriteLine("this is called anyways!");
            }
            Console.ReadKey();
        }
    }
}
