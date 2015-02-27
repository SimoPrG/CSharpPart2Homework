﻿/*Problem 23. Series of letters

    Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

Example:
input 	output
aaaaabbbbbcdddeeeedssaa 	abcdedsa
*/

using System;
using System.Text;
using System.Text.RegularExpressions;

class SeriesOfLetters
{
    static void Main()
    {
        Console.WriteLine("Please, enter a text with many repetitive letters!");
        string text = Console.ReadLine();

        string regex = @"(.)\1+|.|\s"; //this regex captures all repetitive chars, after that all the single chars left and finally the line fold

        StringBuilder result = new StringBuilder();

        foreach (Match match in Regex.Matches(text, regex))
        {
            result.Append(match.Value[0]);
        }

        Console.WriteLine(result);
    }
}