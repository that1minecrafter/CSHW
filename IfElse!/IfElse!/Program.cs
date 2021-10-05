using System;

namespace IfElse_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what's the temperature like?");
            string temp = Console.ReadLine();
            int numTemp = int.Parse(temp);

            if(numTemp < 40)
            {
                Console.WriteLine("take a jacket");
            }else if(numTemp == 60)
            {
                Console.WriteLine("it's a nice temperature outside!");
            }else if(numTemp > 70)
            {
                Console.WriteLine("it's too hot for this");
            }

            Console.Read();
        }
    }
}
