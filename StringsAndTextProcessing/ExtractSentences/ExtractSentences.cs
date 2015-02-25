/*Problem 8. Extract sentences

    Write a program that extracts from a given text all sentences containing given word.

Example:

The word is: in

The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

Consider that the sentences are separated by . and the words – by non-letter symbols.
*/

using System;
using System.Text;

class ExtractSentences
{
    static void Main()
    {
        Console.WriteLine("Please, enter the text! (Hint: you can copy it from the comments in the code)");
        //You can copy the text from the comments above ;)
        string text = Console.ReadLine();
        Console.Write("Please, enter the key word: ");
        string word = Console.ReadLine();

        Console.WriteLine(ExtractSentencesWithWord(word, text));

        Console.ReadKey();
    }

    static string ExtractSentencesWithWord(string word, string text)
    {
        bool containsWord = false;
        var currentWord = new StringBuilder();
        var currentSentene = new StringBuilder();
        var output = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            currentSentene.Append(text[i]);

            if (char.IsWhiteSpace(text[i]) || text[i] == '.')
            {
                if (currentWord.ToString().ToLower() == word.ToLower())
                {
                    containsWord = true;
                }

                currentWord.Clear();
            }
            else
            {
                currentWord.Append(text[i]);
            }

            if (text[i] == '.')
            {
                if (containsWord)
                {
                    output.Append(currentSentene);
                }

                currentSentene.Clear();
                containsWord = false;
            }
        }

        return output.ToString().Trim();
    }
}