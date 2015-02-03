/*Problem 1. Allocate array

    Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
    Print the obtained array on the console.
*/

using System;

class AllocateArray
{
    static void Main()
    {
        Console.Title = "Allocate Array";

        int[] myFirstArray = new int[20];
        for (int i = 0; i < myFirstArray.Length; i++)
        {
            myFirstArray[i] = i * 5;
        }

        for (int i = 0; i < myFirstArray.Length; i++)
        {
            Console.WriteLine("myFirstArray[{0,2}] = {1,2}", i, myFirstArray[i]);
        }

        Console.ReadKey();
    }
}