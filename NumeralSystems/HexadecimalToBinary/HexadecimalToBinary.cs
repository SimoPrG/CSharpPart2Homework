/*Problem 5. Hexadecimal to binary

    Write a program to convert hexadecimal numbers to binary numbers (directly).
*/

using System;
using System.Text;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Title = "Hexadecimal to Binary Number"; //Changing the title of the console.
        Console.Write("Please, enter a hexadecimal number: ");
        string hexadecimal = Console.ReadLine().ToUpper();

        bool isNegative = false;
        if (hexadecimal.StartsWith("-"))
        {
            isNegative = true;
            hexadecimal = hexadecimal.Replace("-", "");
        }

        StringBuilder sum = new StringBuilder();
        foreach (char digit in hexadecimal)
        {
            switch (digit)
            {
                case '0': sum.Append("0000"); break;
                case '1': sum.Append("0001"); break;
                case '2': sum.Append("0010"); break;
                case '3': sum.Append("0011"); break;
                case '4': sum.Append("0100"); break;
                case '5': sum.Append("0101"); break;
                case '6': sum.Append("0110"); break;
                case '7': sum.Append("0111"); break;
                case '8': sum.Append("1000"); break;
                case '9': sum.Append("1001"); break;
                case 'A': sum.Append("1010"); break;
                case 'B': sum.Append("1011"); break;
                case 'C': sum.Append("1100"); break;
                case 'D': sum.Append("1101"); break;
                case 'E': sum.Append("1110"); break;
                case 'F': sum.Append("1111"); break;
                default:
                    Console.WriteLine("Invalid number");
                    Console.ReadKey(); // Keeping the console opened.
                    return;
            }
        }

        while (sum[0] == '0' && sum.Length > 1)//trim leading zeros
        {
            sum.Remove(0, 1);
        }

        if (isNegative)
        {
            sum.Insert(0, '-');
        }

        Console.WriteLine("binary number: {0}", sum);

        Console.ReadKey(); // Keeping the console opened.
    }
}
