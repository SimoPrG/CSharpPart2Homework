/*Problem 19.* Permutations of set

    Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].

Example:
N 	result
3 	{1, 2, 3}
    {1, 3, 2}
    {2, 1, 3}
    {2, 3, 1}
    {3, 1, 2}
    {3, 2, 1}
*/

using System;

class PermutationsOfSet
{
    static void Main()
    {
        Console.Title = "Permutations of Set";

        Console.Write("Please, enter an integer N: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];

        for (int i = 0; i < array.Length; )
        {
            array[i] = ++i;
        }

        Permutation(array, array.Length, 0);

        // Wait for keyboard enter
        Console.ReadKey();
    }

    //recursive function to generate permutations
    static void Permutation(int[] array, int n, int i) // this function generates the permutations of the array from element i to element n-1
    {
        if (i == n) // if we are at the end of the array, we have one permutation we can use
        {
            Console.WriteLine(string.Join(", ", array));
        }
        else // recursively explore the permutations starting at index i going through index n-1
        {
            for (int j = i; j < n; j++)
            {
                // try the array with i and j switched
                Swap(array, i, j);
                Permutation(array, n, i + 1);
                // swap them back the way they were
                Swap(array, i, j);
            }
        }
    }

    //function to swap array elements
    static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}