/*Problem 10. Unicode characters

    Write a program that converts a string to a sequence of C# Unicode character literals.
    Use format strings.

Example:
input 	output
Hi! 	\u0048\u0069\u0021
*/

using System;
using System.Text;
using System.Text.RegularExpressions;
class UnicodeCharacters
{
    static void Main()
    {
        Console.WriteLine("Please, enter some text to see its unicode characters representation:");
        string text = Console.ReadLine();

        string unicodeLiterals = ConvertStringToUnicode(text);

        Console.WriteLine(unicodeLiterals);

        Console.ReadKey();
    }

    private static string ConvertStringToUnicode(string text)
    {
        StringBuilder output = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            output.AppendFormat("\\u{0:X4}", (int)text[i]);
        }

        return output.ToString();
    }
}