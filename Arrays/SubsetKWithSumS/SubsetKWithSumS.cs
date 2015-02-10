/*Problem 17.* Subset K with sum S

    Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
    Find in the array a subset of K elements that have sum S or indicate about its absence.
*/

using System;
using System.IO;

class SubsetKWithSumS
{
    static void Main()
    {
        Console.Title = "Subset K with sum S";

        // Tell console to get its input from a file, not from the keyboard
        StreamReader file = new StreamReader(@"..\..\input.txt");  //uncoment this two lines to read from file
        Console.SetIn(file);                                       //uncoment this two lines to read from file

        //reading the array
        Console.WriteLine("Please, enter the elements of the array separated by space or comma!");
        string[] splitSeparators = { " ", ", ", "," };
        string[] userInput = Console.ReadLine().Split(splitSeparators, StringSplitOptions.RemoveEmptyEntries);
        int[] elements = Array.ConvertAll(userInput, int.Parse);

        int s = int.Parse(Console.ReadLine());

        for (int i = 1; i < Math.Pow(2, elements.Length); i++)
        {
            int sum = 0;
            string print = null;
            for (int j = 0; j < elements.Length; j++)
            {
                if ((i & (1 << j)) != 0)
                {
                    sum += elements[(int)Math.Log(1 << j, 2)];
                    print += elements[(int)Math.Log(1 << j, 2)] + " ";
                }
            }
            if (sum == s)
            {
                Console.WriteLine(print);
            }
        }

        // Reset console input to the standard (keyboard) input so we can wait for keyboard enter
        Console.SetIn(new StreamReader(Console.OpenStandardInput()));

        // Wait for keyboard enter
        Console.ReadKey();
    }
}
