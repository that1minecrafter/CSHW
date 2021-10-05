using System;

namespace IfChallenge
{
    class Program
    {
        static string username;
        static string password;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("please enter your username");
            username = Console.ReadLine();
            Console.WriteLine("please enter your password");
            password = Console.ReadLine();
            Console.WriteLine("user registered!");
            Console.WriteLine("---------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("please enter your username");
            if(username == Console.ReadLine())
            {
                Console.WriteLine("please enter your password");
                if(password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful!");
                }
                else
                {
                    Console.WriteLine("login failed, please restart program!");
                }
            }
            else
            {
                Console.WriteLine("login failed, please restart program!");
            }
        }
    }
}
