/*Problem 14. Word dictionary

    A dictionary is stored as a sequence of text lines containing words and their explanations.
    Write a program that enters a word and translates it by using the dictionary.

Sample dictionary:
input 	    output
.NET 	    platform for applications from Microsoft
CLR 	    managed execution environment for .NET
namespace 	hierarchical organization of classes
*/

using System;
using System.Text.RegularExpressions;

class WordDictionary
{
    private static string dictionary =
@".NET 	    platform for applications from Microsoft
CLR 	    managed execution environment for .NET
namespace 	hierarchical organization of classes";
    static void Main()
    {
        Console.Write("Please, enter a search word (.net | clr | namespace): ");
        string searchWord = Console.ReadLine();

        /*this regex finds in one match the beginning of the line ^, the searchWord, the white spaces after the word \s+
         * and any symbol until the end of the line (.|\s)+?$
         * The last symbols are put in group "definition" (?<definition>(.|\s)+?$)
         */
        string regex = "^" + searchWord + @"\s+(?<definition>(.|\s)+?$)";

        MatchCollection matches = Regex.Matches(dictionary, regex, RegexOptions.IgnoreCase | RegexOptions.Multiline);

        if (matches.Count > 0)
        {
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups["definition"]);
            }
        }
        else
        {
            Console.WriteLine("Sorry, this word is not in the dictionary.");
        }

        Console.ReadKey();
    }
}