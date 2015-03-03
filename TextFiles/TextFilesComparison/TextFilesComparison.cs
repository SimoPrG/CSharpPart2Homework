/*Problem 4. Compare text files

    Write a program that compares two text files line by line and prints the number of lines that are the same
    and the number of lines that are different.
    Assume the files have equal number of lines.
*/

using System;
using System.IO;
class TextFilesComparison
{
    static void Main()
    {
        int sameLines = 0;
        int differentLines = 0;

        using (StreamReader reader1 = new StreamReader(@"..\..\TextFile1.txt"))
        {
            using (StreamReader reader2 = new StreamReader(@"..\..\TextFile2.txt"))
            {
                string line1 = reader1.ReadLine();
                string line2 = reader2.ReadLine();

                while (line1 != null && line2 != null)
                {
                    if (line1 == line2)
                    {
                        sameLines++;
                    }
                    else
                    {
                        differentLines++;
                    }

                    line1 = reader1.ReadLine();
                    line2 = reader2.ReadLine();
                }
            }
        }

        Console.WriteLine("Same lines: {0}", sameLines);
        Console.WriteLine("Different lines: {0}", differentLines);

        Console.ReadLine();
    }
}