/*Problem 3. Line numbers

    Write a program that reads a text file and inserts line numbers in front of each of its lines.
    The result should be written to another text file.
*/

using System;
using System.IO;
class LineNumbers
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\TextFile.txt"))
        {
            string line = reader.ReadLine();
            int count = 1;

            using (StreamWriter writer = new StreamWriter(@"..\..\Result.txt"))
            {
                while (line != null)
                {
                    writer.WriteLine("{0}. {1}", count, line);
                    count++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}