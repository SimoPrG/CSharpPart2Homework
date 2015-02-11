/*Problem 20.* Variations of set

    Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].

Example:
N 	K 	result
3 	2 	{1, 1}
        {1, 2}
        {1, 3}
        {2, 1}
        {2, 2}
        {2, 3}
        {3, 1}
        {3, 2}
        {3, 3}
*/

using System;

class VariationsOfSet
{
    static void Main()
    {
        Console.Title = "Variations of Set";

        Console.Write("Please, enter an integer N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Please, enter an integer K: ");
        int K = int.Parse(Console.ReadLine());

        int[] array = new int[N];
        for (int i = 0; i < array.Length; )
        {
            array[i] = ++i;
        }

        Variation(array, array.Length, 0, K);

        // Wait for keyboard enter
        Console.ReadKey();
    }

    //recursive function to generate permutations
    static void Variation(int[] array, int n, int i, int k) // this function generates the permutations of the array from element i to element n-1
    {
        if (i == k) // if we are at the end of the array, we have one permutation we can use
        {
            for (int j = 0; j < k; j++)
            {
                Console.Write("{0} ", array[j]);
            }
            Console.WriteLine();
        }
        else // recursively explore the permutations starting at index i going through index n-1
        {
            for (int j = i; j < n; j++)
            {
                // try the array with i and j switched
                Swap(array, i, j);
                Variation(array, n, i + 1, k);
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