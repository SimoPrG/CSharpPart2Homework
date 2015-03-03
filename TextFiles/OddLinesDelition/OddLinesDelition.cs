/*Problem 9. Delete odd lines

    Write a program that deletes from given text file all odd lines.
    The result should be in the same file.
*/

using System;
using System.IO;
class OddLinesDelition
{
    static void Main()
    {
        string filename = @"..\..\File.txt";
        string tempfile = @"..\..\temp.txt";
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                using (StreamWriter writer = new StreamWriter(tempfile))
                {
                    int index = 1;
                    while (!reader.EndOfStream)
                    {
                        if (index % 2 == 1)
                        {
                            reader.ReadLine();
                        }
                        else
                        {
                            writer.WriteLine(reader.ReadLine());
                        }
                        index++;
                    }
                }
            }

            File.Delete(filename);
            File.Move(tempfile, filename);
        }
        catch (IOException exc)
        {

            Console.WriteLine("Error: {0}.", exc.Message);
        }
    }
}