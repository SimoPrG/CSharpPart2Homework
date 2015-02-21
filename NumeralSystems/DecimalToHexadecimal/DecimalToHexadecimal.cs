/*Problem 3. Decimal to hexadecimal

    Write a program to convert decimal numbers to their hexadecimal representation.
*/

using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Title = "Decimal to Hexadecimal Number"; //Changing the title of the console.
        Console.Write("Please, enter an integer: ");
        long n = long.Parse(Console.ReadLine());
        bool isNegative = n < 0;
        if (isNegative)
        {
            n = -n;
        }
        string hexadecimalBackwards = null; // We will devide n by 16 and we will keep the reminders in this string.
        do
        {
            switch (n % 16)
            {
                case 0: hexadecimalBackwards += "0"; break;
                case 1: hexadecimalBackwards += "1"; break;
                case 2: hexadecimalBackwards += "2"; break;
                case 3: hexadecimalBackwards += "3"; break;
                case 4: hexadecimalBackwards += "4"; break;
                case 5: hexadecimalBackwards += "5"; break;
                case 6: hexadecimalBackwards += "6"; break;
                case 7: hexadecimalBackwards += "7"; break;
                case 8: hexadecimalBackwards += "8"; break;
                case 9: hexadecimalBackwards += "9"; break;
                case 10: hexadecimalBackwards += "A"; break;
                case 11: hexadecimalBackwards += "B"; break;
                case 12: hexadecimalBackwards += "C"; break;
                case 13: hexadecimalBackwards += "D"; break;
                case 14: hexadecimalBackwards += "E"; break;
                case 15: hexadecimalBackwards += "F"; break;
            }
            n /= 16;
        } while (n != 0);
        if (isNegative)
        {
            hexadecimalBackwards += "-";
        }
        char[] charHexadecimal = hexadecimalBackwards.ToCharArray();
        Array.Reverse(charHexadecimal);
        string stringBinary = new string(charHexadecimal);
        Console.WriteLine("\r\nHexadecimal representation: {0}", stringBinary);
        Console.ReadKey(); // Keeping the console opened.
    }
}