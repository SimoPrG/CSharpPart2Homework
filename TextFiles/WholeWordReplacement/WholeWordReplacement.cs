/*Problem 8. Replace whole word

    Modify the solution of the previous problem to replace only whole words (not strings).
*/

using System;
using System.IO;
using System.Text.RegularExpressions;
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
                        writer.WriteLine(Regex.Replace(line, @"\bstart\b", m => m.Value[0] == 'S' ? "Finish" : "finish",
                            RegexOptions.IgnoreCase));
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