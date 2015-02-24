/*Problem 2. Reverse string

    Write a program that reads a string, reverses it and prints the result at the console.

Example:
input 	output
sample 	elpmas
*/

using System;

class StringReversing
{
    static void Main()
    {
        string alpha = "ABCDEFGHIJKLMNOPQRSTUVQXYZ";
        Console.WriteLine(alpha);

        string reverseAlpha = ReverseString(alpha);
        Console.WriteLine("Reversed:\n{0}", reverseAlpha);

        Console.ReadKey();
    }

    static string ReverseString (string str)
    {
        char[] array = str.ToCharArray();
        Array.Reverse(array);
        return new string(array);
   }
}