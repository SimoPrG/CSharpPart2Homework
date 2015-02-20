/*Problem 6. First larger than neighbours

    Write a method that returns the index of the first element in array that is larger than its neighbours, or -1,
    if there’s no such element.
    Use the method from the previous exercise.
*/
using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Please, enter the elements of the array separated by ' ' or ', '");
        int[] elements = Console.ReadLine()
            .Split(new string[] { " ", ", ", "," }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        Console.WriteLine("The index of the first larger neighbour is {0}.", GetFirstNeighbour(elements));
        Console.ReadKey();
    }

    static int GetFirstNeighbour(int[] array)
    {
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (IsLargerThanNeighbours(i, array))
            {
                return i;
            }
        }
        return index;
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