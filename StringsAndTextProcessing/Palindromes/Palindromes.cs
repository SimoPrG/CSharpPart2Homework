/*Problem 20. Palindromes

    Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
*/

using System;
using System.Text.RegularExpressions;

class Palindromes
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi! Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.";

        string regex = @"[,;:\-\!\?\.\s]+";

        foreach (var word in Regex.Split(text, regex))
        {
            if (word.Length > 1 && word.ToLower().Equals(ReverseString(word.ToLower())))
            {
                Console.WriteLine(word);
            }
        }

        Console.ReadKey();
    }

    static string ReverseString(string str)
    {
        char[] array = str.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}