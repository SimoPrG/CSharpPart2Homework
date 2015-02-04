/*Problem 2. Compare arrays

    Write a program that reads two integer arrays from the console and compares them element by element.
*/

using System;

class CompareArrays
{
    static void Main()
    {
        Console.Title = "Compare Arrays";
        //reading the first array
        Console.Write("Please, enter the length of the first array: ");
        int firstArrayLength = int.Parse(Console.ReadLine());
        int[] firstArray = new int[firstArrayLength];
        Console.WriteLine("Please, enter the elements of the first array!");
        for (int i = 0; i < firstArrayLength; i++)
        {
            Console.Write("Element [{0}] = ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        //reading the second array
        Console.Write("Please, enter the length of the second array: ");
        int secondArrayLength = int.Parse(Console.ReadLine());
        int[] secondArray = new int[secondArrayLength];
        Console.WriteLine("Please, enter the elements of the second array!");
        for (int i = 0; i < secondArrayLength; i++)
        {
            Console.Write("Element [{0}] = ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        //comparing the arrays
        if (firstArray.Length != secondArray.Length)
        {
            Console.WriteLine("The arrays are different.");
        }
        else
        {

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine("The arrays are different.");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("The arrays are equal.");
        }
        Console.ReadKey();
    }
}