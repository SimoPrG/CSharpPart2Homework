/*Problem 16.* Subset with sum S

    We are given an array of integers and a number S.
    Write a program to find if there exists a subset of the elements of the array that has a sum S.

Example:
input array 	        S 	result
2, 1, 2, 4, 3, 5, 2, 6 	14 	yes
*/

/* In this problem I will implement binary solution. I will check if each of the combinations of the array has a sum equal to S.
 * I represent the indexes of the array with ones. If I have an array with length 3 all the combinations are:
 * 0 0 0
 * 0 0 1
 * 0 1 0
 * 0 1 1
 * 1 0 0
 * 1 0 1
 * 1 1 0
 * 1 1 1 - Math.Pow(2, length) - 1
 * 
 * If I have a 1 I add this element to the sum.
 * for example 1 0 1 (5) means that I have to add elements [0] and [2] these are the elements [log2(1)] and [log2(1 0 0(4))]
*/
using System;
using System.IO;

class SubsetWithSumS
{
    static void Main()
    {
        Console.Title = "Subset with sum S";

        // Tell console to get its input from a file, not from the keyboard
        //StreamReader file = new StreamReader(@"..\..\input.txt");  //uncoment this two lines to read from file
        //Console.SetIn(file);                                       //uncoment this two lines to read from file

        //reading the array
        Console.WriteLine("Please, enter the elements of the array separated by space or comma!");
        string[] splitSeparators = { " ", ", ", "," };
        string[] userInput = Console.ReadLine().Split(splitSeparators, StringSplitOptions.RemoveEmptyEntries);
        int[] elements = Array.ConvertAll(userInput, int.Parse);

        Console.Write("Please, enter S: ");
        int s = int.Parse(Console.ReadLine());

        for (int i = 1; i < Math.Pow(2, elements.Length); i++)
        {
            int sum = 0;
            string print = null;
            for (int j = 0; j < elements.Length; j++)
            {
                if ((i & (1<<j)) != 0)
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