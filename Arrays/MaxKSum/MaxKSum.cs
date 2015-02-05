/*Problem 6. Maximal K sum

    Write a program that reads two integer numbers N and K and an array of N elements from the console.
    Find in the array those K elements that have maximal sum.
*/

using System;

class MaxKSum
{
    static void Main()
    {
        Console.Title = "Maximal K Sum";
        //reading the array
        Console.Write("Please, enter the length of the array N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Please, enter an integer K: ");
        int K = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter the elements of the array!");
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Element [{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        int sum = 0;
        int[] maxSum = new int[K];
        for (int i = 0; i < K; i++)
        {
            sum += maxSum[i] = array[N - K + i];
        }

        Console.WriteLine("{0} = {1}", string.Join(" + ", maxSum), sum);

        Console.ReadKey();
    }
}