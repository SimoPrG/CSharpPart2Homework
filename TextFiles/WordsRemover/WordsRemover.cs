/*Problem 12. Remove words

    Write a program that removes from a text file all words listed in given another text file.
    Handle all possible exceptions in your methods.
*/

using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;
class WordsRemover
{
    static void Main(string[] args)
    {
        string list = @"..\..\list.txt";
        string input = @"..\..\input.txt";
        List<string> result = new List<string>();
        List<string> listOfWords = new List<string>();

        try
        {
            using (StreamReader reader = new StreamReader(list))
            {
                while (!reader.EndOfStream)
                {
                    string[] words = reader.ReadLine()
                        .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    listOfWords.AddRange(words);
                }
            }
            using (StreamReader reader = new StreamReader(input))
            {
                while (!reader.EndOfStream)
                {
                    string[] words = reader.ReadLine()
                        .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Where(x => !listOfWords.Contains(x))
                        .ToArray();

                    result.AddRange(words);
                }
            }

            using (StreamWriter writer = new StreamWriter(input))
            {
                writer.Write(String.Join(Environment.NewLine, result));
            }
        }
        catch (DirectoryNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileLoadException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (EndOfStreamException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (IOException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (ArgumentNullException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}