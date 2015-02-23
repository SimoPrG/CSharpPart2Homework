/*Problem 6. Sum integers

    You are given a sequence of positive integer values written into a string, separated by spaces.
    Write a function that reads these values from given string and calculates their sum.

Example:
input 	output
"43 68 9 23 318" 	461
*/

using System;
using System.Linq;

class SumIntegers
{
    static void Main()
    {
        Console.Title = "Sum Integers";

        Console.WriteLine("Please, enter some integers separated by space!");
        int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine("The sum is {0}", array.Sum());

        Console.ReadKey();
    }
}