/*Problem 4. Appearance count

    Write a method that counts how many times given number appears in given array.
    Write a test program to check if the method is workings correctly.
*/

using System;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        Console.WriteLine("Please, enter the elements of the array separated by ' ' or ', '");
        int[] elements = Console.ReadLine()
            .Split(new string[] { " ", ", ", "," }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
        Console.Write("Please, enter the number you are counting: ");
        int number = int.Parse(Console.ReadLine());

        int result = CountAppearance(number, elements);
        Console.WriteLine("The number {0} appears {1} time{2} in the array.", number, result, result != 1 ? "s" : "");

        Console.ReadKey();
    }

    static int CountAppearance(int x, int[] array)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
            if (x == array[i])
                count++;

        return count;
    }
}