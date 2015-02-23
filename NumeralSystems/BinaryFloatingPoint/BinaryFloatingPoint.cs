/*Problem 9.* Binary floating-point

    Write a program that shows the internal binary representation of given 32-bit signed floating-point number
    in IEEE 754 format (the C# type float).

Example:
number 	sign 	exponent 	mantissa
-27,25 	1 	    10000011 	10110100000000000000000
*/

using System;
using System.Threading;
using System.Globalization;

class BinaryFloatingPoint
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

        Console.Write("Please, enter a floating-point number: ");
        float f = float.Parse(Console.ReadLine());

        Console.WriteLine("binary: " + FloatToBinary(f));

        Console.ReadKey();
    }

    static string FloatToBinary(float f)
    {
        string binary = null;
        byte[] bytes = BitConverter.GetBytes(f);
        for (int i = bytes.Length - 1; i >= 0; i--)
            binary += Convert.ToString(bytes[i], 2).PadLeft(8, '0');
        return binary;
    }
}