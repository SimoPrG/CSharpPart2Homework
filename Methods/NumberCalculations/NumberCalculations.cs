/*Problem 15.* Number calculations

    Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
    Use generic method (read in Internet about generic methods in C#).
*/

using System;
using System.Collections.Generic;


class NumberCalculations
{
    static void Main()
    {
        dynamic min = GetMinimum(1, 2, 3, 4, 5, 6, 7, 8, 9, Math.PI);
        dynamic max = GetMaximum(1, 2, 3, 4, 5, 6, 7, 8, 9, Math.PI);
        dynamic sum = GetSum(1, 2, 3, 4, 5, 6, 7, 8, 9, Math.PI);
        dynamic product = GetProduct(1, 2, 3, 4, 5, 6, 7, 8, 9, Math.PI);
        dynamic average = GetAverage(1, 2, 3, 4, 5, 6, 7, 8, 9, Math.PI);

        Console.WriteLine("min: {0}\n" +
                          "max: {1}\n" +
                          "sum: {2}\n" +
                          "product: {3}\n" +
                          "average: {4}",
                          min, max, sum, product, average);

        Console.ReadKey();
    }

    static T GetMinimum<T>(params T[] array)
    {
        T min = array[0];
        for (int i = 1; i < array.Length; i++)
            if (Comparer<T>.Default.Compare(min, array[i]) > 0)
                min = array[i];
        return min;
    }

    static T GetMaximum<T>(params T[] array)
    {
        T max = array[0];
        for (int i = 1; i < array.Length; i++)
            if (Comparer<T>.Default.Compare(max, array[i]) < 0)
                max = array[i];
        return max;
    }

    static T GetSum<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
            sum += array[i];
        return sum;
    }

    static T GetProduct<T>(params T[] array)
    {
        dynamic product = 1;
        for (int i = 0; i < array.Length; i++)
            product *= array[i];
        return product;
    }

    static T GetAverage<T>(params T[] array)
    {
        dynamic length = array.Length;
        return GetSum(array) / length;
    }
}