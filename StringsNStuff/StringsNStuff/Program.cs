using System;

namespace StringsNStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 14;
            string name = "Nico";
            string grade = "sophmore";

            //string concatentation
            Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old, and i am a " + grade);

            //string formatting
            Console.WriteLine("hello my name is {0}, I am {1} years old, and i am a {2}", name, age, grade);


        }
    }
}
