/*Problem 4. Triangle surface

    Write methods that calculate the surface of a triangle by given:
        Side and an altitude to it;
        Three sides;
        Two sides and an angle between them;
    Use System.Math.
*/

using System;

namespace TriangleSurface
{
    class TriangleSurface
    {        
        static void Main()
        {
            Console.Title = "Triangle Surface";

            Console.WriteLine("Please, choose how to calculate the triangle area:");
            Console.WriteLine("1 - side and altitude");
            Console.WriteLine("2 - three sides");
            Console.WriteLine("3 - two sides and an angle between them");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Please, enter a side: ");
                    int side = int.Parse(Console.ReadLine());
                    Console.Write("Please, enter an altitude: ");
                    int altitude = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area: {0}", CalculateBySideAndAltitude(side, altitude));
                    break;
                case 2:
                    Console.Write("Please, enter side 'a': ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Please, enter side 'b': ");
                    int b = int.Parse(Console.ReadLine());
                    Console.Write("Please, enter side 'c': ");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area: {0}", CalculateByThreeSides(a, b, c));
                    break;
                case 3:
                    Console.Write("Please, enter side 'a': ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Please, enter side 'b': ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("Please, enter an angle in degrees: ");
                    int angle = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area: {0}", CalculateByTwoSidesAndAngle(a, b, angle));
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.ReadKey();
        }

        static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        static double CalculateByTwoSidesAndAngle(double a, double b, double angle)
        {
            return a * b * Math.Sin(ConvertToRadians(angle)) / 2;
        }

        static double CalculateBySideAndAltitude(double a, double h)
        {
            return a * h / 2;
        }

        static double CalculateByThreeSides(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
