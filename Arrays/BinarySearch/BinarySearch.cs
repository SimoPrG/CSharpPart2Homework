/*Problem 11. Binary search

    Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
*/

using System;
using System.IO;

class BinarySearch
{
    static void Main()
    {
        Console.Title = "Binary Search";

        // Tell console to get its input from a file, not from the keyboard
        //StreamReader file = new StreamReader(@"..\..\input.txt");  //uncoment this two lines to read from file
        //Console.SetIn(file);                                       //uncoment this two lines to read from file

        //reading the array
        Console.WriteLine("Please, enter the elements of the array separated by space or comma!");
        Console.WriteLine("They must be sorted in increasing order!");
        string[] splitSeparators = { " ", ", ", "," };
        string[] userInput = Console.ReadLine().Split(splitSeparators, StringSplitOptions.RemoveEmptyEntries);
        int[] elements = Array.ConvertAll(userInput, int.Parse);

        //reading the element
        Console.Write("Please, enter the element value to search for its index: ");
        int element = int.Parse(Console.ReadLine());

        Console.WriteLine("index: " + MyBinarySearch(element, elements));

        // Reset console input to the standard (keyboard) input so we can wait for keyboard enter
        Console.SetIn(new StreamReader(Console.OpenStandardInput()));

        // Wait for keyboard enter
        Console.ReadKey();
    }

    static int MyBinarySearch (int key, int[] array)
    {
        int min = 0;
        int max = array.Length - 1;
        while (min <= max)
        {
            int mid = (max + min) / 2;
            if (key == array[mid])
            {
                return mid;
            }
            else if (array[mid] < key) // change min index to search upper subarray
            {
                min = mid + 1;
            }
            else // change max index to search lower subarray
            {
                max = mid - 1;
            }
        }
        //key was not found
        return -1;
    }
}