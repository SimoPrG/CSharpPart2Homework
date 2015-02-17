/*Problem 5. Sort by string length

    You are given an array of strings. Write a method that sorts the array by the length of its elements
    (the number of characters composing them).
*/

using System;
using System.Linq;
using System.IO;

class SortByStringLength
{
    static void Main()
    {
        Console.Title = "Sort by string length";

        // Tell console to get its input from a file, not from the keyboard
        StreamReader file = new StreamReader(@"..\..\input.txt"); //uncoment this two lines to read from file
        Console.SetIn(file);                                      //uncoment this two lines to read from file

        Console.Write("Please, enter the size of the string array N: ");
        int N = int.Parse(Console.ReadLine());
        string[] array = new string[N];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Console.ReadLine();
        }

        string[] result = array.OrderBy(s => s.Length).ToArray();

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(result[i]);
        }

        // Reset console input to the standard (keyboard) input so we can wait for keyboard enter
        Console.SetIn(new StreamReader(Console.OpenStandardInput()));
        // Wait for keyboard enter
        Console.ReadKey();
    }
}