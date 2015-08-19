using System;

namespace _02.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            //Write a program to convert binary numbers to their decimal representation.

            Console.WriteLine("Enter binary number:");
            string binaryNumber = Console.ReadLine();
            int binary = int.Parse(binaryNumber);
            double result = 0;
            int lastDigit = 0;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                lastDigit = binary % 10;
                result = result + lastDigit * (Math.Pow(2, i));
                binary = binary / 10;
            }
            Console.WriteLine("Decimal number = {0}", result);
        }
    }
}
