/*Problem 22. Words count

    Write a program that reads a string from the console and lists all different words in the string along with information
    how many times each word is found.
*/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

class WordsCount
{
    static void Main()
    {
        Console.WriteLine("Please enter some text!");
        string text = Console.ReadLine();

        var sortedWords = ListAndCountWordsInText(text);

        foreach (var word in sortedWords)
        {
            Console.WriteLine("{0,-15}{1} time{2}", word.Key, word.Value, word.Value > 1 ? "s" : "");
        }

        Console.ReadKey();
    }

    private static List<KeyValuePair<string, int>> ListAndCountWordsInText(string text)
    {
        string regex = @"([\w#+]+)"; //this regex matches all the symbols considered words \w and the symbols '#' and '+'

        var words = new Dictionary<string, int>();

        foreach (Match match in Regex.Matches(text, regex))
        {
            if (words.ContainsKey(match.Value))
            {
                words[match.Value]++;
            }
            else
            {
                words.Add(match.Value, 1);
            }
        }

        var sortedWords = words.ToList();
        sortedWords.Sort((x, y) => x.Key.CompareTo(y.Key));
        return sortedWords;
    }
}