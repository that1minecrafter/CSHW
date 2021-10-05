using System;

namespace TernaryOperatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputTemp = 0;
            string tempMsg = string.Empty;
            string inputValue = string.Empty;

            Console.Write("enter the current temperature");
            inputValue = Console.ReadLine();

            bool validint = int.TryParse(inputValue, out inputTemp);

            if(validint)
            {
                tempMsg = inputTemp <= 15 ? "it's cold here" : (inputTemp >= 16 && inputTemp <= 70) ? "it's okay" : inputTemp > 70 ? "it's hot here" : "";
                Console.WriteLine(tempMsg);
            }
            else
            {
                Console.WriteLine("not a valid temperature!");
            }
        }
    }
}
