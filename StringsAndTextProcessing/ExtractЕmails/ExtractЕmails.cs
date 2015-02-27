/*Problem 18. Extract e-mails

    Write a program for extracting all email addresses from given text.
    All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
*/

using System;
using System.Text.RegularExpressions;

class ExtractЕmails
{
    static void Main()
    {
        string emailText =
@"Examples valid according to RFC2822

me@example.com
a.nonymous@example.com
name+tag@example.com
tag@example.com

Examples invalid according to RFC2822s

me@
@example.com
me.@example.com
.me@example.com
me@example..com
me.example@com
me\@example.com";

        string regex = @"^([a-zA-Z0-9_\-][a-zA-Z0-9_\+\-\.]{0,49}[a-zA-Z0-9_\-])@(([a-zA-Z0-9][a-zA-Z0-9\-]{0,49}\.)+[a-zA-Z]{2,4})";

        MatchCollection matches = Regex.Matches(emailText, regex, RegexOptions.Multiline);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }

        Console.ReadKey();
    }
}