/*Problem 6. String length

    Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20,
    the rest of the characters should be filled with *.
    Print the result string into the console.
*/

using System;

class StringLength
{
    static void Main()
    {
        Console.WriteLine("Please, enter a string up to 20 characters!");
        string text = Console.ReadLine();

        text = text.PadRight(20, '*');

        Console.WriteLine(text);

        Console.ReadKey();
    }
}