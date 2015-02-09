/*Problem 14. Quick sort

    Write a program that sorts an array of strings using the Quick sort algorithm.
*/

// I have used this explanation to implement a solution: https://www.youtube.com/watch?v=COk73cpQbFQ
using System;
using System.IO;

class QuickSort
{
    static void Main()
    {
        Console.Title = "Quick Sort";

        // Tell console to get its input from a file, not from the keyboard
        //StreamReader file = new StreamReader(@"..\..\input.txt");  //uncoment this two lines to read from file
        //Console.SetIn(file);                                       //uncoment this two lines to read from file

        //reading the array
        Console.WriteLine("Please, enter the elements of the array separated by space or comma!");
        string[] splitSeparators = { " ", ", ", "," };
        string[] userInput = Console.ReadLine().Split(splitSeparators, StringSplitOptions.RemoveEmptyEntries);
        int[] elements = Array.ConvertAll(userInput, int.Parse);

        MyQuickSort(elements, 0, elements.Length - 1);

        Console.WriteLine(string.Join(", ", elements));

        // Reset console input to the standard (keyboard) input so we can wait for keyboard enter
        Console.SetIn(new StreamReader(Console.OpenStandardInput()));

        // Wait for keyboard enter
        Console.ReadKey();
    }

    static void MyQuickSort(int[] array, int startIndex, int endIndex)
    {
        if (startIndex < endIndex)
        {
            int partitionIndex = Partition(array, startIndex, endIndex);
            MyQuickSort(array, startIndex, partitionIndex - 1);
            MyQuickSort(array, partitionIndex + 1, endIndex);
        }
    }

    static int Partition(int[] array, int startIndex, int endIndex)
    {
        int pivot = array[endIndex];
        int partitionIndex = startIndex;
        int temp;

        for (int i = startIndex; i < endIndex; i++)
        {
            if (array[i] <= pivot)
            {
                temp = array[i];
                array[i] = array[partitionIndex];
                array[partitionIndex] = temp;

                partitionIndex++;
            }
        }

        temp = array[partitionIndex];
        array[partitionIndex] = array[endIndex];
        array[endIndex] = temp;

        return partitionIndex;
    }
}