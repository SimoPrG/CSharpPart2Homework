/*Problem 3. Compare char arrays

    Write a program that compares two char arrays lexicographically (letter by letter).
*/

using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.Title = "Compare Char Arrays";
        //reading the first array
        Console.Write("Please, enter the length of the first array: ");
        int firstArrayLength = int.Parse(Console.ReadLine());
        char[] firstArray = new char[firstArrayLength];
        Console.WriteLine("Please, enter the elements of the first array!");
        for (int i = 0; i < firstArrayLength; i++)
        {
            Console.Write("Element [{0}] = ", i);
            firstArray[i] = char.Parse(Console.ReadLine());
        }
        //reading the second array
        Console.Write("Please, enter the length of the second array: ");
        int secondArrayLength = int.Parse(Console.ReadLine());
        char[] secondArray = new char[secondArrayLength];
        Console.WriteLine("Please, enter the elements of the second array!");
        for (int i = 0; i < secondArrayLength; i++)
        {
            Console.Write("Element [{0}] = ", i);
            secondArray[i] = char.Parse(Console.ReadLine());
        }

        int smallestLenght = ((firstArrayLength < secondArrayLength) ? (firstArrayLength) : (secondArrayLength));

        for (int i = 0; i < smallestLenght; i++)
        {
            if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("The first array is lexicographically first.");
                Console.ReadKey();
                return;
            }
            else if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("The second array is lexicographically first.");
                Console.ReadKey();
                return;
            }
        }

        if (firstArray.Length < secondArray.Length)
        {
            Console.WriteLine("The first array is lexicographically first.");
        }
        else if (firstArray.Length > secondArray.Length)
        {
            Console.WriteLine("The second array is lexicographically first.");
        }
        else // firstArray.Length == secondArray.Length
        {
            Console.WriteLine("The arrays are equal.");
        }

        Console.ReadKey();
    }
}