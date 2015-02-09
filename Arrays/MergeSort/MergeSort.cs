/*Problem 13.* Merge sort

    Write a program that sorts an array of integers using the Merge sort algorithm.
*/

// I have used this explanation to implement a solution: https://www.youtube.com/watch?v=TzeBrDU-JaY
using System;
using System.IO;

class MergeSort
{
    static void Main()
    {
        Console.Title = "Merge Sort";

        // Tell console to get its input from a file, not from the keyboard
        //StreamReader file = new StreamReader(@"..\..\input.txt");  //uncoment this two lines to read from file
        //Console.SetIn(file);                                       //uncoment this two lines to read from file

        //reading the array
        Console.WriteLine("Please, enter the elements of the array separated by space or comma!");
        string[] splitSeparators = { " ", ", ", "," };
        string[] userInput = Console.ReadLine().Split(splitSeparators, StringSplitOptions.RemoveEmptyEntries);
        int[] elements = Array.ConvertAll(userInput, int.Parse);

        MyMergeSort(elements);

        Console.WriteLine(string.Join(", ", elements));

        // Reset console input to the standard (keyboard) input so we can wait for keyboard enter
        Console.SetIn(new StreamReader(Console.OpenStandardInput()));

        // Wait for keyboard enter
        Console.ReadKey();
    }

    static void MyMergeSort(int[] array)
    {
        int n = array.Length;

        if (n < 2)
        {
            return;
        }
        else
        {
            int mid = n/2;
            int[] left = new int[mid];
            int[] right = new int[n - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = array[i];
            }

            for (int i = mid; i < n; i++)
            {
                right[i - mid] = array[i];
            }

            MyMergeSort(left);
            MyMergeSort(right);

            Merge(left, right, array);
        }
    }

    static void Merge (int[] left, int[] right, int[] array)
    {
        int nLeft = left.Length;
        int nRight = right.Length;
        int i = 0, j = 0, k = 0;

        while (i < nLeft && j < nRight)
        {
            if (left[i] <= right[j])
            {
                array[k] = left[i];
                k++;
                i++;
            }
            else
            {
                array[k] = right[j];
                k++;
                j++;
            }
        }

        while (i < nLeft)
        {
            array[k] = left[i];
            k++;
            i++;
        }

        while (j < nRight)
        {
            array[k] = right[j];
            k++;
            j++;
        }
    }
}