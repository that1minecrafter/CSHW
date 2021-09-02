using System;

namespace StringChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            Console.Write("please enter your name and press enter: ");
            myName = Console.ReadLine();
            string myNameUpper = String.Format("Uppercase: {0}", myName.ToUpper());
            string myNameLower = String.Format("Lowercase: {0}", myName.ToLower());
            string myNameTrimmed = String.Format("Trimmed Value: {0}", myName.Trim());
            string myNameSubString = String.Format("Substring Value: {0}", myName.Substring(0, 4));

            Console.WriteLine(myNameUpper);
            Console.WriteLine(myNameLower);
            Console.WriteLine(myNameTrimmed);
            Console.WriteLine(myNameSubString);

            Console.ReadKey();
        }
    }
}
