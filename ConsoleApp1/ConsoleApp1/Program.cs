using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the string here: ");
            string input = Console.ReadLine();

            Console.Write("enter a character to search: ");
            char searchInput = Console.ReadLine()[0];
            int searchIndex = input.IndexOf(searchInput);

            Console.WriteLine("index of character {0} in string is {1}", searchInput, searchIndex);

            Console.Write("enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("enter last name: ");
            string lastName = Console.ReadLine();

            string fullName = string.Concat(firstName, " ", lastName);
            Console.WriteLine("your full name {0}", fullName);

            Console.ReadKey();
        }
    }
}
