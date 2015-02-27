/*Problem 13. Reverse sentence

    Write a program that reverses the words in given sentence.

Example:
input 	                                output
C# is not C++, not PHP and not Delphi! 	Delphi not and PHP, not C++ not is C#!
*/

using System;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;

class ReversedSentence
{
    static void Main()
    {
        Console.WriteLine("Please, enter a correct sentence!");
        string sentence = Console.ReadLine(); // C# is not C++, not PHP and not Delphi!

        string reversed = ReverseSentence(sentence);

        Console.WriteLine(reversed);

        Console.ReadKey();
    }

    private static string ReverseSentence(string sentence)
    {
        //this regex matches the white spaces between the word with the punctuation
        string regex = @"[,;:\-\!\?\.\s]+";

        Stack words = new Stack(); //we will keep the words in a stack in order to reverse them.
        Queue separators = new Queue(); //we will keep the separators in a queue in order to keep their order.

        foreach (var word in Regex.Split(sentence, regex))
        {
            if (word != "")
            {
                words.Push(word);
            }
        }

        foreach (var separator in Regex.Matches(sentence, regex))
        {
            separators.Enqueue(separator);
        }

        StringBuilder reversedSentence = new StringBuilder();

        while (words.Count > 0 && separators.Count > 0)
        {
            reversedSentence.Append(words.Pop());
            reversedSentence.Append(separators.Dequeue());
        }

        return reversedSentence.ToString();
    }
}