/*Problem 11. Format number

    Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
    Format the output aligned right in 15 symbols.
*/

using System;

class FormatNumber
{
    static void Main()
    {
        int number;

        do
        {
            Console.Write("Please, enter an integer: ");
        } while (!int.TryParse(Console.ReadLine(), out number));

        Console.WriteLine("{0, 15:D}\n{0, 15:X}\n{0, 15:P}\n{0, 15:E}\n", number);

        Console.ReadKey();
    }
}