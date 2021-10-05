using System;

namespace MethodChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Micky";
            string name2 = "Alex";
            string name3 = "Shaymus";
            GreetFriend(name1);
            GreetFriend(name2);
            GreetFriend(name3);
        }
        static public void GreetFriend(string name)
        {
            Console.WriteLine("haii " + name);
        }
    }
}
