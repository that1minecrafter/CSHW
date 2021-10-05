using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("i am an argument called from a method");
            Console.Read();
        }

        public static void  WriteSomething()
        {
            Console.WriteLine("i am called from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
    }
}
