/*Problem 2. Random numbers

    Write a program that generates and prints to the console 10 random values in the range [100, 200].
*/

using System;

class RandomNumbers
{
    static void Main()
    {
        Console.Title = "Random Numbers";

        byte[] randomNumbers = new byte[10];
        Random Generator = new Random();

        //Generator.NextBytes(randomNumbers); //works only for byte and you cannot give a range

        for (int i = 0; i < randomNumbers.Length; i++)
        {
            randomNumbers[i] = (byte)Generator.Next(100, 201);//minValue is inclusive, maxValue is exclusive
        }

        Console.WriteLine(string.Join(", ", randomNumbers));

        Console.ReadKey();
    }
}
