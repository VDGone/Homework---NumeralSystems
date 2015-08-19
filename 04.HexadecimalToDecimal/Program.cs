using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            //Write a program to convert hexadecimal numbers to their decimal representation.

            Console.WriteLine("Enter hex number:");
            string number = Console.ReadLine();
            number = number.ToLower();
            int result = 0;
            int lastDigit = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (Char.IsDigit(number[i]))
                {
                    result += (int)((number[i] - '0') * Math.Pow(16, hexNumber.Length - i - 1));
                    result += (int)(lastDigit * Math.Pow(16, hexNumber.Length - i - 1));
                }
                else  
                {
                    
                    switch (number[i])
                    {
                        case 'a':
                            result = result + 10;
                            break;
                        case 'b':
                            result = result + 11;
                            break;
                        case 'c':
                            result = result + 12;
                            break;
                        case 'd':
                            result = result + 13;
                            break;
                        case 'e':
                            result = result + 14;
                            break;
                        case 'f':
                            result = result + 15;
                            break;
                        default:
                            result = result + 0;
                            break;
                    }
                    result += (int)((number[i] - '0') * Math.Pow(16, hexNumber.Length - i - 1));
                }
            }
            Console.WriteLine("Decimal number = {0}", result);
        }
    }
}
