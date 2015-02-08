/*Problem 8. Maximal sum

    Write a program that finds the sequence of maximal sum in given array.

Example:
input 	                            result
2, 3, -6, -1, 2, -1, 6, 4, -8, 8 	2, -1, 6, 4

    Can you do it with only one loop (with single scan through the elements of the array)?
*/

using System;

class MaxSum
{
    static void Main()
    {
        Console.Title = "Maximal Sum";
        //reading the array
        Console.Write("Please, enter the length of the array N: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        //finding the max sequence
        int currentSum = 0;
        int currentStart = 0; //start index of the current sequence
        int bestSum = int.MinValue;        
        int bestStart = 0; //start index of the best sequence        
        int bestEnd = 0; // end index of the best sequence
        for (int currentEnd = 0; currentEnd < array.Length; currentEnd++)
        {
            currentSum += array[currentEnd];

            if (currentSum > bestSum)
            {
                bestSum = currentSum;
                bestStart = currentStart;
                bestEnd = currentEnd;
            }
            if (currentSum <= 0)
            {
                currentStart = currentEnd + 1;
                currentSum = 0;
            }
        }
        // printing the sequence
        for (int i = bestStart; i <= bestEnd; i++)
        {
            Console.WriteLine(array[i]);
        }
        Console.WriteLine("Sum = " + bestSum);

        Console.ReadKey();
    }
}