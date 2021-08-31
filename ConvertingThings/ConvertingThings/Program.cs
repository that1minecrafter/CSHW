using System;

namespace ConvertingThings
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            int num = 12390532;
            long bigNum = num;

            float myFloat = 15.73f;
            double myNewDouble = myFloat;

            double myDouble = 15.73;
            int myInt;
            //explicit conversion
            //cast double to int
            myInt = (int)myDouble;

            //type conversion
            string myString = myDouble.ToString();
            string myFloatString = myFloat.ToString();

            Console.WriteLine(myString);
            Console.Read();
        }
    }
}
