/*Problem 8. Binary short

    Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
*/

using System;

class BinaryShort
{
    static void Main()
    {
        Console.WriteLine("Please, enter an integer between -32,768 and 32,767!");
        short shortInt = short.Parse(Console.ReadLine());

        Console.WriteLine("binary representation:\n" + ShortToBinary(shortInt));

        Console.ReadLine();
    }

    static string ShortToBinary(short shortInt)
    {
        char[] binary = {'0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0'};
        for (int i = 0; i < 16; i++)
            if ((shortInt & (1 << i)) != 0)
                binary[15 - i] = '1';
        return new string(binary);
    }
}