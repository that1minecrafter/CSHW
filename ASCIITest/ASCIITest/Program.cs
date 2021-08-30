using System;

namespace ASCIITest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a string and press enter:");
            string readInput = Console.ReadLine();
            Console.WriteLine("you have entered {0}", readInput);

            Console.Write("enter a string and press enter:");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}:", asciiValue);
            Console.ReadKey();
        }
    }
}
