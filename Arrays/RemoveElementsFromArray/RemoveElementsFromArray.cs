/*Problem 18.* Remove elements from array

    Write a program that reads an array of integers and removes from it a minimal number of elements in such a way
    that the remaining array is sorted in increasing order.
    Print the remaining sorted array.

Example:
input 	                    result
6, 1, 4, 3, 0, 3, 6, 4, 5 	1, 3, 3, 4, 5
*/

using System;
using System.IO;

class RemoveElementsFromArray
{
    static void Main()
    {
        Console.Title = "Remove elements from array";

        // Tell console to get its input from a file, not from the keyboard
        //StreamReader file = new StreamReader(@"..\..\input.txt");  //uncoment this two lines to read from file
        //Console.SetIn(file);                                       //uncoment this two lines to read from file

        //reading the array
        Console.WriteLine("Please, enter the elements of the array separated by space or comma!");
        string[] splitSeparators = { " ", ", ", "," };
        string[] userInput = Console.ReadLine().Split(splitSeparators, StringSplitOptions.RemoveEmptyEntries);
        int[] elements = Array.ConvertAll(userInput, int.Parse);
        int length = elements.Length;

        int[] len = new int[length]; //in this array I keep the maximum lenght of any increasing subarray which ends at elements[i]
        len[0] = 1; //the maximum length of the first subarray is always 1
        for (int i = 1; i < length; i++) //the outer loop goes from elements[1] to elements[length - 1]
        {
            int subArrayLength; // this will keep the current subarray length.
            for (int j = 0; j < i; j++) //the inner loop goes from elements[o] to elements[i-1]
            {
                if (elements[j] <= elements[i]) //if we find a subarray which is smaller or equal to the present element we increase its lenght with 1
                {
                    subArrayLength = len[j] + 1;
                }
                else // if we dont find, this is a new subarray with lenght 1
                {
                    subArrayLength = 1;
                }

                if (subArrayLength > len[i]) //the default value of len[i] is 0. Here we find the greates subarray length
                {
                    len[i] = subArrayLength;
                }
            }
        }
        // here we find the maximum length of all subarrays
        int max = 0;
        for (int i = 0; i < length; i++)
        {
            if (max < len[i])
            {
                max = len[i];
            }
        }
        // with this loop we will print all subarrays with maximum length
        for (int i = 0; i < length; i++)
        {
            if (len[i] == max)
            {
                int[] subArray = new int[max];
                int subArrayIndex = max; //-1
                int index = i;
                do
                {
                    if (len[index] == subArrayIndex)
                    {
                        subArrayIndex--;
                        subArray[subArrayIndex] = elements[index];
                    }
                    index--;
                    
                } while (subArrayIndex > 0);
                Console.WriteLine(string.Join(", ", subArray));
            }
        }

        // Reset console input to the standard (keyboard) input so we can wait for keyboard enter
        Console.SetIn(new StreamReader(Console.OpenStandardInput()));

        // Wait for keyboard enter
        Console.ReadKey();
    }
}