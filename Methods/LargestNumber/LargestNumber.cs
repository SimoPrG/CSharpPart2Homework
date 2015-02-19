/*Problem 2. Get largest number

    Write a method GetMax() with two parameters that returns the larger of two integers.
    Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
*/

using System;

class LargestNumber
{
    static void Main()
    {
        Console.Write("Please, enter integer a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please, enter integer b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Please, enter integer c: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("The largest integer is {0}", GetMax(a, GetMax(b, c))); //To understand the recursion, first you need to understand the recursion :)

        Console.ReadKey();
    }

    static int GetMax(int a, int b)
    {
        if (a >= b)
            return (a);
        return (b);
    }
}