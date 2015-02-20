/*Problem 7. Reverse number

    Write a method that reverses the digits of given decimal number.

Example:
input 	output
256 	652
123.45 	54.321
*/

using System;
using System.Linq;


class ReverseNumber
{
    static void Main()
    {
        Console.Write("Please, enter a decimal number: ");
        decimal input = decimal.Parse(Console.ReadLine());
        decimal output = ReverseDigits(input);
        Console.WriteLine("The inverted number is {0}", output);

        Console.ReadKey();
    }

    static decimal ReverseDigits(decimal number)
    {
        string numberString = number.ToString();
        char[] numberArray = numberString.ToCharArray();
        Array.Reverse(numberArray);
        string reversedString = new string(numberArray);
        decimal result = decimal.Parse(reversedString);
        return result;
    }
}