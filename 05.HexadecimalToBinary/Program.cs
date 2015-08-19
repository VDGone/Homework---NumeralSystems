using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HexadecimalToBinary
{
    class HexadecimalToBinary
    {
        static void Main(string[] args)
        {
            //Write a program to convert hexadecimal numbers to binary numbers (directly).

            Console.WriteLine("Enter hex number: ");
            string hexNumber = Console.ReadLine();
            hexNumber = hexNumber.ToLower();
            string result ="";
            for (int i=hexNumber.Length - 1; i >= 0; i--)
            {
                switch (hexNumber[i])
                {
                    case '0':
                        result = "0000" + result;
                        break;
                    case '1':
                        result = "0001" + result;
                        break;
                    case '2':
                        result = "0010" + result;
                        break;
                    case '3':
                        result = "0011" + result;
                        break;
                    case '4':
                        result = "0100" + result;
                        break;
                    case '5':
                        result = "0101" + result;
                        break;
                    case '6':
                        result = "0110" + result;
                        break;
                    case '7':
                        result = "0111" + result;
                        break;
                    case '8':
                        result = "1000" + result;
                        break;
                    case '9':
                        result = "1001" + result;
                        break;
                    case 'a':
                        result = "1010" + result;
                        break;
                    case 'b':
                        result = "1011" + result;
                        break;
                    case 'c':
                        result = "1100" + result;
                        break;
                    case 'd':
                        result = "1101" + result;
                        break;
                    case 'e':
                        result = "1110" + result;
                        break;
                    case 'f':
                        result = "1111" + result;
                        break;
                    default:
                        Console.WriteLine("Invalid Hex number!");
                        break;
                }
            }
            int binaryNumber = int.Parse(result);
            Console.WriteLine("Binary number = {0}", result);
        }
    }
}
