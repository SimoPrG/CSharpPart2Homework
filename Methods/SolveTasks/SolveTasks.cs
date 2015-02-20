/*Problem 13. Solve tasks

    Write a program that can solve these tasks:
        Reverses the digits of a number
        Calculates the average of a sequence of integers
        Solves a linear equation a * x + b = 0
    Create appropriate methods.
    Provide a simple text-based menu for the user to choose which task to solve.
    Validate the input data:
        The decimal number should be non-negative
        The sequence should not be empty
        a should not be equal to 0
*/

using System;
using System.Linq;

class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("Please, make a choice");
        Console.WriteLine("1 - Reverse the digits of a number");
        Console.WriteLine("2 - Calculate the average of a sequence of integers");
        Console.WriteLine("3 - Solve a linear equation a * x + b = 0");
        switch (Console.ReadKey().KeyChar)
        {
            case '1':
                decimal number = 0;
                do
                {
                    Console.Write("Please, enter an non-negative number: ");
                    number = decimal.Parse(Console.ReadLine());
                } while (number < 0);
                number = ReverseDigits(number);
                Console.WriteLine("Reversed: {0}", number);
                break;
            case '2':
                Console.WriteLine("Please, enter the elements of the array separated by ' ' or ', '");
                int[] elements = Console.ReadLine()
                    .Split(new string[] { " ", ", ", "," }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                while (elements.Length == 0)
                {
                    Console.WriteLine("Please, enter the elements of the array separated by ' ' or ', '");
                    elements = Console.ReadLine()
                        .Split(new string[] { " ", ", ", "," }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse).ToArray();
                }
                double result = CalculateAverage(elements);
                Console.WriteLine("The average is {0}", result);
                break;
            case '3':
                int a = 0;
                int b = 0;
                do
                {
                    Console.Write("Please, enter 'a' != 0: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Please, enter 'b': ");
                    b = int.Parse(Console.ReadLine());
                } while (a == 0);
                result = SolveEquation(a, b);
                Console.WriteLine("The answer is {0}", result);
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }

        Console.ReadKey();
    }

    static decimal ReverseDigits(decimal number)
    {
        string numberString = number.ToString();
        char[] numberArray = numberString.ToCharArray();
        Array.Reverse(numberArray);
        string reversedString = new string(numberArray);
        decimal result = decimal.Parse(reversedString);
        return result;
    }

    static double CalculateAverage(int[] array)
    {
        double result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            result += array[i];
        }
        result /= array.Length;
        return result;
    }

    static double SolveEquation(double a, double b)
    {
        return -b / a;
    }
}