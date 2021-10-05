using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate());
            Console.Read();
        }

        public static int Calculate()
        {
            Console.WriteLine("please enter the first number");
            string number1 = Console.ReadLine();
            Console.WriteLine("please enter second number");
            string number2 = Console.ReadLine();

            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);

            int result = num1 + num2;
            return result;

        }
    }
}
