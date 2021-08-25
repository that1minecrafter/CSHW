using System;

namespace intTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //basic integers
            int num1;
            num1 = 7;

            int num2 = 11;

            num2 = 18;
            //Console.WriteLine("num1 is: " + num1);
            int sum = num1 + num2;
            Console.WriteLine("num1: " + num1 + " num2: " + num2 + " is " + sum);

            //doubles
            double d1 = 7.47;
            double d2 = 5.12;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is: " + dDiv);

            //floats
            float f1 = 7.47f;
            float f2 = 5.12f;
            float fMult = f1 * f2;
            Console.WriteLine("f1*f2 is: " + fMult);

            //combining
            double dIDiv = d1 / num1;
            Console.WriteLine("d1/num1 is: " + dIDiv);

            Console.Read();
        }
    }
}
