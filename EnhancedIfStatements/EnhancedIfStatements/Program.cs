using System;

namespace EnhancedIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 96;
            string stateOfMatter;

            /*
            if (temp < 32)
                stateOfMatter = "solid";
            else
                stateOfMatter = "liquid";
            */
            stateOfMatter = temp < 32 ? "solid" : "liquid" ;

            stateOfMatter = temp > 212 ? "gas" : temp < 0 ? "solid" : "liquid"; 

            Console.WriteLine("state of matter is " + stateOfMatter);
            Console.ReadKey();
        }
    }
}
