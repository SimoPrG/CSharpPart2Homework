/*Problem 7. Selection sort

    Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
    Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the
    smallest from the rest, move it at the second position, etc.
*/

using System;

class SelectionSort
{
    static void Main()
    {
        Console.Title = "Selection Sort";
        //reading the array
        Console.Write("Please, enter the length of the array N: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = i + 1; j < N; j++)
            {
                if (array[i] > array[j])
                {
                    array[i] ^= array[j];
                    array[j] ^= array[i];
                    array[i] ^= array[j];
                }
            }
        }

        Console.WriteLine(string.Join(", ", array));

        Console.ReadKey();
    }
}