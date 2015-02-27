/*Problem 19. Dates from text in Canada

    Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
    Display them in the standard date format for Canada.
*/

using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

class DatesFromTextInCanada
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("bg-BG");
        string text = "I was born on 23.10.1986, my brother was born on 22.2.1984. 1.1.2016 is not in my calendar because I will be unavailable on 31.12.2015.";

        string regex = @"((((0?[1-9])|[12][0-9]|3[01])\.((0?[13578])|(1[02])))|(((0?[1-9])|[12][0-9]|30)\.((0?[469])|11))|(((0?[1-9])|[12][0-9])\.(0?2)))\.\d{4}";

        MatchCollection matches = Regex.Matches(text, regex);

        foreach (Match match in matches)
        {
            Console.WriteLine(DateTime.Parse(match.Value).ToString( "d", CultureInfo.GetCultureInfo("en-CA")));
        }

        Console.ReadKey();
    }
}