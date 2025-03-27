using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Pract
{
    internal class SystemNumber
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Choose your system:");
            Console.WriteLine("1 - 10 System.");
            Console.WriteLine("2 - 2 System.");
            Console.WriteLine("3 - 8 System.");
            Console.WriteLine("4 - 16 System.");
            Console.WriteLine("5 - Out.");
        }

        public int GetSystemChoice()
        {
            int choice;
            while (true)
            {
                Console.Write("Choise: ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 5)
                {
                    return choice;
                }
                throw new InvalidDataException();
            }
        }
    }
    internal class NumberConverter
    {
        public string DecimalToBinary(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 2);
        }

        public int BinaryToDecimal(string binaryNumber)
        {
            return Convert.ToInt32(binaryNumber, 2);
        }

        public string DecimalToOctal(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 8);
        }

        public int OctalToDecimal(string octalNumber)
        {
            return Convert.ToInt32(octalNumber, 8);
        }

        public string DecimalToHexadecimal(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 16).ToUpper();
        }

        public int HexadecimalToDecimal(string hexNumber)
        {
            return Convert.ToInt32(hexNumber, 16);
        }
    }
}
