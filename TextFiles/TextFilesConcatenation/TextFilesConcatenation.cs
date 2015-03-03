/*Problem 2. Concatenate text files

    Write a program that concatenates two text files into another text file.
*/

using System;
using System.IO;
class TextFilesConcatenation
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\TextFile1.txt"))
        {
            string buffer = reader.ReadToEnd();

            using (StreamWriter writer = new StreamWriter(@"..\..\Result.txt"))
            {
                writer.Write(buffer);
            }
        }

        using (StreamReader reader = new StreamReader(@"..\..\TextFile2.txt"))
        {
            string buffer = reader.ReadToEnd();

            using (StreamWriter writer = new StreamWriter(@"..\..\Result.txt", true))
            {
                writer.Write(buffer);
            }
        }
    }
}