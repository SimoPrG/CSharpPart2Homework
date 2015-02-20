/*Problem 8. Number as array

    Write a method that adds two positive integer numbers represented as arrays of digits
    (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
    Each of the numbers that will be added could have up to 10 000 digits.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberAsArray
{
    static void Main()
    {
        Console.Write("Please, enter the first positive integer: ");
        string input1 = Console.ReadLine();
        Console.Write("Please, enter the second positive integer: ");
        string input2 = Console.ReadLine();

        byte[] byteArray1 = new byte[input1.Length];
        for (int i = 0; i < byteArray1.Length; i++)
        {
            byteArray1[i] = (byte)(input1[i] - '0');
        }

        byte[] byteArray2 = new byte[input2.Length];
        for (int i = 0; i < byteArray2.Length; i++)
        {
            byteArray2[i] = (byte)(input2[i] - '0');
        }

        Array.Reverse(byteArray1);
        Array.Reverse(byteArray2);

        byte[] byteResult = AddIntegers(byteArray1, byteArray2);

        Array.Reverse(byteResult);

        string result = string.Join("", byteResult).TrimStart('0');
        Console.WriteLine("The sum is {0}", result);

        Console.ReadKey();
    }

    static byte[] AddIntegers(byte[] x, byte[] y) //the input of the function should be the numbers as reversed arrays
    {
        int maxLength = x.Length > y.Length ? x.Length : y.Length;
        int minLength = x.Length < y.Length ? x.Length : y.Length;
        byte[] result = new byte[maxLength + 1];

        byte carry = 0;
        int index;
        for (index = 0; index < minLength; index++)
        {
            result[index] = (byte)((carry + x[index] + y[index]) % 10);
            carry = (byte)((carry + x[index] + y[index]) / 10);
        }

        if (maxLength == x.Length)
        {
            while (index < maxLength)
            {
                result[index] = (byte)((x[index] + carry) % 10);
                carry = (byte)((carry + x[index]) / 10);
                index++;
            }
        }

        if (maxLength == y.Length)
        {
            while (index < maxLength)
            {
                result[index] = (byte)((y[index] + carry) % 10);
                carry = (byte)((carry + y[index]) / 10);
                index++;
            }
        }

        result[index] = carry;

        return result; //the result is a reversed array
    }
}