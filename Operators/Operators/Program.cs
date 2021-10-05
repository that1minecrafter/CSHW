using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 6;
            int num2 = 2;
            int num3;

            //unary operator
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is ir sunny? {0}", !isSunny);

            //incrememt operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);
            //pre incrememt
            Console.WriteLine("num is {0}", ++num);

            //decrememt operators
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);
            //pre decrement
            Console.WriteLine("num is {0}", --num);


            int result;
            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 - num2; 
            Console.WriteLine("result of num1 - num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result);
            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result);

            //relational and tpye operators
            bool isLower;
            isLower = num1 > num2;
            Console.WriteLine("result of num1 > num2 is {0}", isLower);

            //equality operators
            bool isEqual;
            isEqual = num1 == num;
            Console.WriteLine("result of num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("result of num1 != num2 is {0}", isEqual);

            //conditional operators
            bool isLowerAndIsSunny;
            //condition1 and condition2
            isLowerAndIsSunny = isLower && isSunny;
            Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndIsSunny);

            isLowerAndIsSunny = isLower || isSunny;
            Console.WriteLine("result of isLower || isSunny is {0}", isLowerAndIsSunny);

            Console.ReadKey();
        }
    }
}
