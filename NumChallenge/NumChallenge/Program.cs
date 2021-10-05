using System;

namespace NumChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 32;
            Console.WriteLine(myByte);
            sbyte mySByte = -73;
            Console.WriteLine(mySByte);
            int myInt = 147;
            Console.WriteLine(myInt);
            uint myUInt = 368;
            Console.WriteLine(myUInt);
            short myShort = 767;
            Console.WriteLine(myShort);
            ushort myUShort = 653;
            Console.WriteLine(myUShort);
            long myLong = -934781625;
            Console.WriteLine(myLong);
            ulong myULong = 483903821;
            Console.WriteLine(myULong);
            float myFloat = -68.3958f;
            Console.WriteLine(myFloat);
            double myDouble = 1.578239;
            Console.WriteLine(myDouble);
            char myChar = 'N';
            Console.WriteLine(myChar);
            bool myBool = false;
            Console.WriteLine(myBool);
            string myText = "i control text";
            Console.WriteLine(myText);
            string numText = "18";

            int myNumFromText = int.Parse(numText);
            Console.WriteLine(myNumFromText);
            Console.ReadLine();
        }
    }
}
