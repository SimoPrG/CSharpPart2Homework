/*Problem 2. Binary to decimal

    Write a program to convert binary numbers to their decimal representation.
*/

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Title = "Binary to Decimal Number"; //Changing the title of the console.
        Console.Write("Please, enter a binary number: ");
        string binary = Console.ReadLine();
        bool isNegative = false;
        if (binary.StartsWith("-"))
        {
            isNegative = true;
            binary = binary.Replace("-", "");
        }
        int sum = 0;
        for (int j = 0, i = binary.Length - 1; i >= 0; j++, i--)
        {
            if (binary[i] == '1')
            {
                sum += 1 << j;
            }
        }
        if (isNegative)
        {
            sum = -sum;
        }
        Console.WriteLine("\r\ndecimal number: {0}", sum);
        Console.ReadKey(); // Keeping the console opened.
    }
}