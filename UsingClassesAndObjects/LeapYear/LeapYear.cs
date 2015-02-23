/*Problem 1. Leap year

    Write a program that reads a year from the console and checks whether it is a leap one.
    Use System.DateTime.
*/

namespace LeapYear
{
    using System;
    class LeapYear
    {
        static void Main()
        {
            Console.Title = "Leap Year"; //setting the name of the console

            Console.Write("Please, enter a year to check whether it is a leap one: ");
            try // I exercise exception handlings here.
            {
                Int32 year = Convert.ToInt32(Console.ReadLine());
                bool isLeapYear = DateTime.IsLeapYear(year); //this is a use of System.DateTime
                if (isLeapYear)
                {
                    Console.WriteLine("Year {0} is a leap one!", year);
                }
                else
                {
                    Console.WriteLine("Year {0} is NOT a leap one!", year);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadKey(); //keeping the console opened
        }
    }
}