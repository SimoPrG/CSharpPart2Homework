/*Problem 5. Workdays

    Write a method that calculates the number of workdays between today and given date, passed as parameter.
    Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
*/

using System;
using System.Text;
using System.Threading;
using System.Globalization;

class Workdays
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("bg-BG");
        Console.OutputEncoding = Encoding.Unicode;
        Console.Title = "Workdays";

        Console.Write("Please, enter a future date in 2015 (DD.MM): ");
        DateTime futureDate = DateTime.Parse(Console.ReadLine());
        DateTime currentDate = DateTime.Now.Date;

        DateTime[] holiday = new DateTime[12]; //this array will keep the holiday days
        holiday[0]  = new DateTime(2015, 1, 1);
        holiday[1]  = new DateTime(2015, 3, 2);
        holiday[2]  = new DateTime(2015, 3, 3);
        holiday[3]  = new DateTime(2015, 4, 10);
        holiday[4]  = new DateTime(2015, 4, 13);
        holiday[5]  = new DateTime(2015, 5, 1);
        holiday[6]  = new DateTime(2015, 5, 6);
        holiday[7]  = new DateTime(2015, 9, 21);
        holiday[8]  = new DateTime(2015, 9, 22);
        holiday[9]  = new DateTime(2015, 12, 24);
        holiday[10] = new DateTime(2015, 12, 25);
        holiday[11] = new DateTime(2015, 12, 31);

        int workdays = 0;
        while (currentDate < futureDate)
        {
            currentDate = currentDate.AddDays(1);

            if (currentDate.DayOfWeek != DayOfWeek.Saturday &&
                currentDate.DayOfWeek != DayOfWeek.Sunday)
            {
                int index = Array.IndexOf(holiday, currentDate);
                if (index < 0)
                {
                    workdays++;
                }
            }
        }

        Console.WriteLine("There {0} {1} working day{2} until {3:d}",
            workdays == 1 ? "is" : "are", workdays, workdays == 1 ? "" : "s", futureDate);

        Console.ReadKey();
    }
}