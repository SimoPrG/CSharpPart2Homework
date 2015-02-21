/*Problem 1. Decimal to binary

    Write a program to convert decimal numbers to their binary representation.
*/

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Title = "Decimal to Binary Number"; //Changing the title of the console.

        Console.Write("Please, enter an integer: ");
        long n = long.Parse(Console.ReadLine());
        bool isNegative = n < 0;
        string binaryBackwards = null; // We will devide n by two and we will keep the reminders in this string.

        do
        {
            binaryBackwards += Math.Abs(n % 2); //We make sure that we will add only "0"s and "1"s to the string without "-"s.
            n /= 2;
        } while (n != 0);

        if (isNegative)
        {
            binaryBackwards += "-";
        }

        char[] charBinary = binaryBackwards.ToCharArray();
        Array.Reverse(charBinary);
        string stringBinary = new string(charBinary);

        Console.WriteLine("\r\nBinary representation: {0}", stringBinary);

        Console.ReadKey(); // Keeping the console opened.
    }
}