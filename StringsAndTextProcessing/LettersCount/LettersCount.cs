/*Problem 21. Letters count

    Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
*/

using System;
using System.Text.RegularExpressions;

class LettersCount
{
    static void Main()
    {
        Console.WriteLine("Please, enter some text!");
        string text = Console.ReadLine();

        string regex = @"[^a-z]+"; //This regex, combined with IgnoreCase, finds all symbols which are not letters.

        string textLettersOnly = Regex.Replace(text, regex, String.Empty, RegexOptions.IgnoreCase);

        var smallLetters = new int[26];
        var bigLetters = new int[26];

        for (int i = 0; i < textLettersOnly.Length; i++)
        {
            if (char.IsLower(textLettersOnly[i]))
            {
                smallLetters[textLettersOnly[i] - 'a']++;
            }
            else
            {
                bigLetters[textLettersOnly[i] - 'A']++;
            }
        }

        for (int i = 0; i < 26; i++)
        {
            if (bigLetters[i] != 0)
            {
                Console.WriteLine("{0} {1}", (char)(i+'A'), bigLetters[i]);
            }

            if (smallLetters[i] != 0)
            {
                Console.WriteLine("{0} {1}", (char)(i + 'a'), smallLetters[i]);
            }
        }

        Console.ReadKey();
    }
}