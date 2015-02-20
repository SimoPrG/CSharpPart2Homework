/*Problem 10. N Factorial

    Write a program to calculate n! for each n in the range [1..100].

Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
*/

using System;
using System.Linq;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        Console.Write("Please, enter an integer between 1 and 100 to find its factorial!\n" +
            "number: ");
        int number = int.Parse(Console.ReadLine());

        int[] array = Enumerable.Range(1, number).ToArray();

        Console.WriteLine("Result: {0}", CalculateFactorial(array));

        Console.ReadKey();
    }

    static BigInteger CalculateFactorial(int[] array)
    {
        BigInteger result = 1;
        for (int i = 0; i < array.Length; i++)
        {
            result *= array[i];
        }
        return result;
    }
}