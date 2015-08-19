using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            //Write a program to convert decimal numbers to their hexadecimal representation.

            Console.WriteLine("Enter decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            int remainder = 0;
            string result = "";

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 16;
                decimalNumber /= 16;
                
                if (remainder < 10)
                {
                    result = remainder.ToString() + result;
                }
                else if (remainder > 10)
                {
                    switch (remainder)
                    {
                        case 10:
                            result = result + "A";
                            break;
                        case 11:
                            result = result + "B";
                            break;
                        case 12:
                            result = result + "C";
                            break;
                        case 13:
                            result = result + "D";
                            break;
                        case 14 :
                            result = result + "E";
                            break;
                        case 15:
                            result = result + "F";
                            break;
                        default:
                            result = result + "";
                            break;

                    }
                }
            }
            Console.WriteLine("Hex number = {0}.", result);
        }
    }
}
