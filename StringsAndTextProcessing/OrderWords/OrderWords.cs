/*Problem 24. Order words

    Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
*/

using System;

class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Please, enter some words separated by spaces!");
        string input = Console.ReadLine();
        string[] sortedWords = input.Split();
        Array.Sort(sortedWords);
        Console.WriteLine(string.Join("\n", sortedWords));
        Console.ReadKey();
    }
}