/*Problem 14. Integer calculations

    Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
    Use variable number of arguments.
*/

using System;
using System.Linq;

class IntegerCalculations
{
    static void Main()
    {
        int min = GetMinimum(1, 2, 3, 4, 5, 6, 7, 8, 9);
        int max = GetMaximum(1, 2, 3, 4, 5, 6, 7, 8, 9);
        long sum = GetSum(1, 2, 3, 4, 5, 6, 7, 8, 9);
        long product = GetProduct(1, 2, 3, 4, 5, 6, 7, 8, 9);
        double average = GetAverage(1, 2, 3, 4, 5, 6, 7, 8, 9);

        Console.WriteLine("min: {0}\n" +
                          "max: {1}\n" +
                          "sum: {2}\n" +
                          "product: {3}\n" +
                          "average: {4}",
                          min, max, sum, product, average);

        Console.ReadKey();
    }

    static int GetMinimum(params int[] array)
    {
        int min = array[0];
        for (int i = 1; i < array.Length; i++)
            if (min > array[i])
                min = array[i];
        return min;
    }

    static int GetMaximum(params int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
            if (max < array[i])
                max = array[i];
        return max;
    }

    static long GetSum(params int[] array)
    {
        long sum = 0;
        for (int i = 0; i < array.Length; i++)
            sum += array[i];
        return sum;
    }

    static long GetProduct(params int[] array)
    {
        long product = 1;
        for (int i = 0; i < array.Length; i++)
            product *= array[i];
        return product;
    }

    static double GetAverage(params int[] array)
    {
        return (double)GetSum(array) / array.Length;
    }
}