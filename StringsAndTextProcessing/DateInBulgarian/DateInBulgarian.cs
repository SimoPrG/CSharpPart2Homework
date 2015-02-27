/*Problem 17. Date in Bulgarian

    Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints
    the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
*/

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class DateInBulgarian
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("bg-BG");
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Въведете дата и час (ДД.ММ.ГГГГ чч:мм:сс): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        //DateTime date = DateTime.Now;

        TimeSpan sixHoursAnd30Mins = new TimeSpan(6, 30, 0);

        Console.WriteLine("След 6 часа и 30 минути ще е {0:dd.MM.yyyy HH:mm:ss dddd}", date + sixHoursAnd30Mins);

        Console.ReadKey();
    }
}