/*Problem 9. Sorting array

    Write a method that return the maximal element in a portion of array of integers starting at given index.
    Using it write another method that sorts an array in ascending / descending order.
*/

using System;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        Console.WriteLine("Please, enter the elements of the array separated by ' ' or ', '");
        int[] elements = Console.ReadLine()
            .Split(new string[] { " ", ", ", "," }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
        Console.Write("Please, enter the start index: ");
        int startIndex = int.Parse(Console.ReadLine());
        Console.Write("Please, enter the end index: ");
        int endIndex = int.Parse(Console.ReadLine());

        Console.WriteLine("The biggest element between indexes {0} and {1} is {2}.", startIndex, endIndex,
            GetMaxElementInRange(elements, startIndex, endIndex));

        Console.Write("Please, press 'y' if you want to sort the array in decending order." +
            " If you want to sort it in ascending order press any other key: ");
        bool choice = false;
        if (Console.ReadKey().Key == ConsoleKey.Y)
        {
            choice = true;
        }
        SortArray(choice, elements);
        Console.WriteLine("\nThis is the ordered array: {0}", string.Join(", ", elements));

        Console.ReadKey();
    }

    static int GetMaxElementInRange(int[] array, int startIndex, int endIndex)
    {
        int maxElement = array[startIndex];
        for (int i = startIndex + 1; i <= endIndex; i++)
            if (array[i] > maxElement)
                maxElement = array[i];
        return maxElement;
    }

    static void SortArray(bool descending, int[] array)
    {
        int length = array.Length;
        bool swapped;
        if (descending)
        {
            do
            {
                swapped = false;
                for (int i = 1; i < length; i++)
                {
                    if (GetMaxElementInRange(array, i - 1, i) > array[i - 1])
                    {
                        Swap(array, i - 1, i);
                        swapped = true;
                    }
                }
                length--;
            } while (swapped);
        }
        else
        {
            do
            {
                swapped = false;
                for (int i = 1; i < length; i++)
                {
                    if (GetMaxElementInRange(array, i - 1, i) > array[i])
                    {
                        Swap(array, i - 1, i);
                        swapped = true;
                    }
                }
                length--;
            } while (swapped);
        }
    }

    static void Swap(int[] array, int p1, int p2)
    {
        int temp = array[p1];
        array[p1] = array[p2];
        array[p2] = temp;
    }
}