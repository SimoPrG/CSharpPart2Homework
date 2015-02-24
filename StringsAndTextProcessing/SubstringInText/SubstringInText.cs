/*Problem 4. Sub-string in text

    Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

Example:

The target sub-string is in

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9
*/

using System;

class SubstringInText
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight." +
            "So we are drinking all the day. We will move out of it in 5 days.";
        string substring = "in";

        int count = CountSubstringOccurance(text, substring);

        Console.WriteLine("Substring \"{0}\" appears {1} times in the text:\n{2}", substring, count, text);

        Console.ReadKey();
    }

    static int CountSubstringOccurance(string text, string sub)
    {
        int count = 0;
        int index = 0;

        if (sub == null)
        {
            return count;
        }

        if (sub == string.Empty)
        {
            if (string.IsNullOrEmpty(text))
            {
                return count;
            }
            else
            {
                return text.Length - 1;
            }
        }

        while ((index = text.IndexOf(sub, index)) >= 0)
        {
            count++;
            index += sub.Length;
        }
        return count;
    }
}