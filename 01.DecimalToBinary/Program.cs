using System;

namespace _01.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            //Write a program to convert decimal numbers to their binary representation.

            Console.WriteLine("Enter decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            int remainder = 0;
            string result = "";

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            int resultBinary = int.Parse(result);
            Console.WriteLine("Binary number = {0}.", resultBinary);
        }
    }
}
