/*Problem 3. Read file contents

    Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
    reads its contents and prints it on the console.
    Find in MSDN how to use System.IO.File.ReadAllText(…).
    Be sure to catch all possible exceptions and print user-friendly error messages.
*/

using System;
using System.IO;

class FileContentsReader
{
    static void Main()
    {
        Console.Title = "Read File Contents";

        Console.WriteLine(@"Please, enter the file name along with its file path");
        string fileAndPath = Console.ReadLine(); // ..\..\ExceptionHandling.txt

        try
        {
            string textFromFile = File.ReadAllText(fileAndPath);
            Console.WriteLine(textFromFile);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Error! The file name and the file path are not provided.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Error! The file name and the file path provided are invalid.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error! The file is not found.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Error! The directory is not found.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Error! The length of the path is too big.");
        }
        catch (IOException)
        {
            Console.WriteLine("Error! The file could not be read.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error! Access denied.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Error! This program has no support.");
        }
    }
}