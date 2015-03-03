/*Problem 7. Replace sub-string

    Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
    Ensure it will work with large files (e.g. 100 MB).
*/

using System;
using System.IO;
class SubStringReplacement
{
    static void Main()
    {
        try
        {
            using (StreamReader reader = new StreamReader(@"..\..\big.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\temp.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line.Replace("start", "finish"));
                    }
                }
            }

            File.Delete(@"..\..\big.txt");
            File.Move(@"..\..\temp.txt", @"..\..\big.txt");
        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: {0}.", exc.Message);
        }
    }
}