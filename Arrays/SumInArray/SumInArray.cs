/*Problem 10. Find sum in array

    Write a program that finds in given array of integers a sequence of given sum S (if present).

Example:
array 	                S 	result
4, 3, 1, 4, 2, 5, 8 	11 	4, 2, 5
*/

using System;
using System.IO;

class SumInArray
{
    static void Main()
    {
        Console.Title = "Find Sum In Array";

        // Tell console to get its input from a file, not from the keyboard
        //StreamReader file = new StreamReader(@"..\..\input.txt");  //uncoment this two lines to read from file
        //Console.SetIn(file);                                       //uncoment this two lines to read from file

        //reading the array
        Console.WriteLine("Please, enter the elements of the array separated by space or comma!");
        string[] splitSeparators = { " ", ", ", "," };
        string[] userInput = Console.ReadLine().Split(splitSeparators, StringSplitOptions.RemoveEmptyEntries);
        int[] elements = Array.ConvertAll(userInput, int.Parse);

        //reading the sum
        Console.Write("Please, enter the sum: ");
        int userSum = int.Parse(Console.ReadLine());

        for (int i = 0; i < elements.Length; i++)
        {
            int sum = 0;
            for (int j = i; j < elements.Length; j++)
            {
                sum += elements[j];
                if (sum == userSum)
                {
                    int[] output = new int[j - i + 1];
                    for (int k = 0; k <= j - i; k++)
                    {
                        output[k] = elements[i + k];
                    }
                    Console.WriteLine(string.Join(", ", output));
                }
            }
        }

        // Reset console input to the standard (keyboard) input so we can wait for keyboard enter
        Console.SetIn(new StreamReader(Console.OpenStandardInput()));

        // Wait for keyboard enter
        Console.ReadKey();
    }
}