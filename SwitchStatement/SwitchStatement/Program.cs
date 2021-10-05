using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 14;

            switch(age)
            {
                case 14:
                    Console.WriteLine("too young to drive in the US");
                    break;
                case 23:
                    Console.WriteLine("you may get your license to drive ");
                    break;
                default:
                    Console.WriteLine("how old are you then?");
                    break;
            }
            if(age == 15)
            {
                Console.WriteLine("too young to drive in the US");
            }else if(age == 25)
            {
                Console.WriteLine("you may get your license to drive ");
            }else
            {
                Console.WriteLine("how old are you then?");
            }

            string username = "meep";

            switch (username)
            {
                case "meep":
                    Console.WriteLine("Username is meep");
                    break;
                case "woot":
                    Console.WriteLine("Username is woot");
                    break;
                default:
                    Console.WriteLine("Username cannot be found");
                    break;

            }
        }
    }
}
