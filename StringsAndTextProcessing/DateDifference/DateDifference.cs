/*Problem 16. Date difference

    Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days
*/

using System;
using System.Globalization;
using System.Threading;

class DateDifference
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("bg-BG");
        CultureInfo bg = new CultureInfo("bg-BG");

        Console.Write("Enter the first date (dd.MM.YYYY): ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the second date (dd.MM.YYYY): ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("There are {0} days between the two dates.", Math.Abs((firstDate - secondDate).Days));

        Console.ReadKey();
    }
}