/*Problem 4. Binary search

    Write a program, that reads from the console an array of N integers and an integer K,
    sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
*/

using System;
using System.IO;

class BinarySearch
{
    static void Main()
    {
        Console.Title = "Sequence n matrix";

        // Tell console to get its input from a file, not from the keyboard
        StreamReader file = new StreamReader(@"..\..\input.txt"); //uncoment this two lines to read from file
        Console.SetIn(file);                                      //uncoment this two lines to read from file

        Console.Write("Please, enter the size of the array N: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Please, enter an integer K: ");
        int K = int.Parse(Console.ReadLine());
        Array.Sort(array);

        int result = 0;
        int index = Array.BinarySearch(array, K);
        if (index < 0)
        {
            index = ~index - 1;
        }
        if (index >= 0)
        {
            result = array[index];
        }

        Console.WriteLine("the largest number in the array which is ≤ K is {0}", result);
        // Reset console input to the standard (keyboard) input so we can wait for keyboard enter
        Console.SetIn(new StreamReader(Console.OpenStandardInput()));
        // Wait for keyboard enter
        Console.ReadKey();
    }
}