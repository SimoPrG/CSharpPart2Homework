/*Problem 3. Correct brackets

    Write a program to check if in a given expression the brackets are put correctly.

Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
*/

using System;
using System.Linq;

class CorrectBrackets
{
    static void Main()
    {
        string expression = "((a+b)/5-d)";
        Console.WriteLine("{0} brackets {1} corect.",
            expression, AreBracketsCorrect(expression) ? "are" : "are NOT");

        expression = ")(a+b))";
        Console.WriteLine("{0} brackets {1} corect.",
            expression, AreBracketsCorrect(expression) ? "are" : "are NOT");

        Console.ReadKey();
    }

    static bool AreBracketsCorrect(string expression)
    {
        if (expression.Count(c => c == '(') == expression.Count(c => c == ')'))
            return true;
        return false;
    }
}