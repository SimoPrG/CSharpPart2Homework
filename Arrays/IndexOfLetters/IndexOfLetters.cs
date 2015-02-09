/*Problem 12. Index of letters

    Write a program that creates an array containing all letters from the alphabet (A-Z).
    Read a word from the console and print the index of each of its letters in the array.
*/

using System;
using System.IO;

class IndexOfLetters
{
    static void Main()
    {
        Console.Title = "Index of letters";

        // Tell console to get its input from a file, not from the keyboard
        //StreamReader file = new StreamReader(@"..\..\input.txt");  //uncoment this two lines to read from file
        //Console.SetIn(file);                                       //uncoment this two lines to read from file

        Console.Write("Please, enter a word: ");
        string word = Console.ReadLine().ToUpper();

        char[] alphabet = new char[26];
        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)('A' + i);
        }

        foreach (char letter in word)
        {
            Console.WriteLine("The index of \'{0}\' is {1}.", letter, MyBinarySearch(letter, alphabet));
        }

        // Reset console input to the standard (keyboard) input so we can wait for keyboard enter
        Console.SetIn(new StreamReader(Console.OpenStandardInput()));

        // Wait for keyboard enter
        Console.ReadKey();
    }

    static int MyBinarySearch(char key, char[] array)
    {
        int min = 0;
        int max = array.Length - 1;
        while (min <= max)
        {
            int mid = (max + min) / 2;
            if (key == array[mid])
            {
                return mid;
            }
            else if (array[mid] < key) // change min index to search upper subarray
            {
                min = mid + 1;
            }
            else // change max index to search lower subarray
            {
                max = mid - 1;
            }
        }
        //key was not found
        return -1;
    }
}