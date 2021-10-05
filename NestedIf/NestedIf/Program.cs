using System;

namespace NestedIf
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("please enter your username");



            userName = Console.ReadLine();
            if (isRegistered && userName != "" && userName.Equals("Admin"))
            {
                Console.WriteLine("hi there, registered user!");

                Console.WriteLine("hi there, " + userName);

                Console.WriteLine("hi there, Admin!");

            }

            if(isAdmin || isRegistered)
            {
                Console.WriteLine("you are logged in");
            }
            Console.Read();
        }
    }
}
