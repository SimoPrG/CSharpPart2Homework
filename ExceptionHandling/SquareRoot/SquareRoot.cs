/*Problem 1. Square root

    Write a program that reads an integer number and calculates and prints its square root.
        If the number is invalid or negative, print Invalid number.
        In all cases finally print Good bye.
    Use try-catch-finally block.
*/

using System;

class SquareRoot
{
    static void Main()
    {
        Console.Title = "Square root";

        int number = 0;
        string input;

        Console.Write("Please, enter an integer to find its square root: ");
        input = Console.ReadLine();

        try
        {
            number = int.Parse(input);

            if (number < 0)
            {
                throw new ArithmeticException("Negative number");
            }
            double result = Math.Sqrt(number);
            Console.WriteLine("Square root of {0} is {1}", number, result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error! Your input \"{0}\" is not an integer.", input);
        }
        catch (ArithmeticException ae)
        {
            if (ae.Message == "Negative number")
            {
                Console.WriteLine("Error! You have entered the negative number {0}." +
                    "The program works only with non-negative integers.", number);
            }
            else
            {
                Console.WriteLine("Unknow arithmetic error!"); //this line will never print.
            }
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Error! Input missing."); // in the console type Ctrl+Z and press Enter to get this error. This is like reading from an empty file.
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}