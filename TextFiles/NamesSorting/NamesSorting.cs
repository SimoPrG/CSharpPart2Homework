/*Problem 6. Save sorted names

    Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

Example:
input.txt 	output.txt
Ivan        George
Peter       Ivan
Maria       Maria
George      Peter
*/

using System;
using System.IO;
class NamesSorting
{
    static void Main()
    {
        string[] names;

        using (StreamReader reader = new StreamReader(@"..\..\input.txt"))
        {
            names = reader.ReadToEnd().Split(new string[] {"\r\n", "\n", " "}, StringSplitOptions.RemoveEmptyEntries);
        }

        Array.Sort(names);

        using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
        {
            foreach (var name in names)
            {
                writer.WriteLine(name);
            }
        }
    }
}