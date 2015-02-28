/*Problem 2. Enter numbers

    Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
        If an invalid number or non-number text is entered, the method should throw an exception.
    Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
*/

using System;

class NumbersEntry
{
    static void Main()
    {
        Console.Title = "Enter Numbers";

        int start = 1;
        int end = 100;
        int[] tenNumbers = new int[10];

        try
        {
            tenNumbers[0] = ReadNumber(start, end);
            for (int i = 1; i < tenNumbers.Length; i++)
            {
                tenNumbers[i] = ReadNumber(tenNumbers[i - 1], end);
            }

            Console.WriteLine(string.Join(" ", tenNumbers));
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine(ane.Message);
        }
        catch(FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (ArgumentOutOfRangeException aoore)
        {
            Console.WriteLine(aoore.Message);
        }
    }

    private static int ReadNumber(int start, int end)
    {
        Console.Write("Please, enter an integer between {0} and {1} excluding: ", start, end);
        string input = Console.ReadLine();

        int number = int.Parse(input); //int.Parse is already throwing FormatException so we dont need to implement it

        if (number <= start || number >= end)
        {
            string message = string.Format("The entered integer is out of the range({0}..{1}).", start, end);
            throw new ArgumentOutOfRangeException(message);
        }

        return number;
    }
}