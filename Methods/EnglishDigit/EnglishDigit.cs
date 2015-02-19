/*Problem 3. English digit

    Write a method that returns the last digit of given integer as an English word.

Examples:
input 	output
512 	two
1024 	four
12309 	nine
*/

using System;

class EnglishDigit
{
    static void Main()
    {
        Console.Write("Please, enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The last digit of {0} is {1}", n, GetLastDigit(n));
        Console.ReadKey();
    }

    static string GetLastDigit(int number)
    {
        switch (number % 10)
        {
            case 0: return ("zero");
            case 1: return ("one");
            case 2: return ("two");
            case 3: return ("three");
            case 4: return ("four");
            case 5: return ("five");
            case 6: return ("six");
            case 7: return ("seven");
            case 8: return ("eight");
            case 9: return ("nine");
            default: return ("");
        }
    }
}