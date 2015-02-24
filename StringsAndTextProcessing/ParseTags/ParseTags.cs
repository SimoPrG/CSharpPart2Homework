/*Problem 5. Parse tags

    You are given a text.
    Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
    The tags cannot be nested.

Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
*/

using System;

class ParseTags
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine(ReplaceUpcaseTags(text));

        text = "<upcase>We</upcase> are living in a <upcase>yellow submarine</upcase>. We don't have anything else.";
        Console.WriteLine(ReplaceUpcaseTags(text));

        Console.ReadKey();
    }

    static string ReplaceUpcaseTags (string taggedText)
    {
        string[] upcaseTags = { "<upcase>", "</upcase>" };
        string[] splitedText = taggedText.Split(upcaseTags, StringSplitOptions.None);

        for (int i = 1; i < splitedText.Length; i += 2)
        {
            splitedText[i] = splitedText[i].ToUpper();
        }

        return string.Join("", splitedText);
    }
}