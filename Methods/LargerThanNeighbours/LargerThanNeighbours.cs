/*Problem 5. Larger than neighbours

    Write a method that checks if the element at given position in given array of integers is larger than its two neighbours
    (when such exist).
*/

using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Please, enter the elements of the array separated by ' ' or ', '");
        int[] elements = Console.ReadLine()
            .Split(new string[] { " ", ", ", "," }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
        Console.Write("Please, enter the index of the number to check if it is larger than its neighbours: ");
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine("The number at position {0} is larger than its neighbours: {1}",
            index, IsLargerThanNeighbours(index, elements));

        Console.ReadKey();
    }

    static bool IsLargerThanNeighbours(int index, int[] array)
    {
        if (array.Length == 0)
            return false;

        if (array.Length == 1)
            if (index == 0)
                return true;
            else
                return false;

        if (index >= 0 && index < array.Length)
        {
            if (index == 0)
                if (array[index] > array[index + 1])
                    return true;
                else
                    return false;

            if (index == array.Length - 1)
                if (array[index] > array[index - 1])
                    return true;
                else
                    return false;

            if (array[index] > array[index - 1] && array[index] > array[index + 1])
                return true;
            return false;
        }
        return false;
    }
}