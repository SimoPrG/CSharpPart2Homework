/*Problem 4. Maximal sequence

    Write a program that finds the maximal sequence of equal elements in an array.

Example:
input 	                        result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1 	2, 2, 2
*/

using System;

class MaximalSequence
{
    static void Main()
    {
        Console.Title = "Maximal Sequence";
        //reading the array
        Console.Write("Please, enter the length of the array: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        Console.WriteLine("Please, enter the elements of the array!");
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int start = 0;
        int length = 1;
        int bestStart = 0;
        int bestLength = 1;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                length++;
            }
            else
            {
                length = 1;
                start = i + 1;
            }

            if (length > bestLength)
            {
                bestLength = length;
                bestStart = start;
            }
        }

        for (int i = bestStart; i < bestStart + bestLength; i++)
        {
            Console.Write("{0} ", array[i]);
        }

        Console.ReadKey();
    }
}