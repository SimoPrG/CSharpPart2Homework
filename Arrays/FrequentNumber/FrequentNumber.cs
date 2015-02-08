/*Problem 9. Frequent number

    Write a program that finds the most frequent number in an array.

Example:
input 	                                result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 	4 (5 times)
*/

using System;
using System.Collections.Generic;
using System.IO;

class FrequentNumber
{
    static void Main()
    {
        Console.Title = "Frequent Number";

        // Tell console to get its input from a file, not from the keyboard
        //StreamReader file = new StreamReader(@".\input.txt");
        //Console.SetIn(file);

        //reading the array
        Console.WriteLine("Please, enter the elements of the array separated by space or comma!");
        string[] splitSeparators = { " ", ", ", "," };
        string[] userInput = Console.ReadLine().Split(splitSeparators, StringSplitOptions.RemoveEmptyEntries);        
        int[] elements = Array.ConvertAll(userInput, int.Parse);

        List<int[]> numbers = new List<int[]>(); // we need a list of arrays "numbers" to keep each different element in number[0] and its frequency in number[1]

        foreach (int element in elements)
        {
            bool foundInNumbers = false; // a flag showing if the element is already in the list of "numbers"
            for (int i = 0; i < numbers.Count; i++)
            {
                if (element == numbers[i][0])
                {
                    numbers[i][1]++;
                    foundInNumbers = true;
                    break;
                }
            }
            if (!foundInNumbers) // if the element is not in the list, we create a new array and add it to the list.
            {
                int[] number = { element, 1 };
                numbers.Add(number);
            }
        }
        numbers.TrimExcess(); //we set the capacity of the list to its count for the sake of practicing

        // here we find the biggest frequency of all numbers
        int maxFrequency = 0;
        foreach (int[] number in numbers)
        {
            if (number[1] > maxFrequency)
            {
                maxFrequency = number[1];
            }
        }

        // here we print the numbers with the biggest frequency
        foreach (int[] number in numbers)
        {
            if (number[1] == maxFrequency)
            {
                Console.WriteLine("{0} ({1} times)", number[0], number[1]);
            }
        }

        // Reset console input to the standard (keyboard) input so we can wait for keyboard enter
        //Console.SetIn(new StreamReader(Console.OpenStandardInput()));

        // Wait for keyboard enter
        Console.ReadKey();
    }
}