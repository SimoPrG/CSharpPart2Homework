/*Problem 1. Odd lines

    Write a program that reads a text file and prints on the console its odd lines.
*/

using System;
using System.IO;
class OddLines
{
    static void Main()
    {
        using(StreamReader reader = new StreamReader(@"..\..\TextFile.txt"))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                reader.ReadLine();
                line = reader.ReadLine();               
            }
        }

        Console.ReadKey();
    }
}