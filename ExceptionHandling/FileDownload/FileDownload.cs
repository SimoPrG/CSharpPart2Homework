/*Problem 4. Download file

    Write a program that downloads a file from Internet (e.g. Ninja image) and stores it in the current directory.
    Find in Google how to download files in C#.
    Be sure to catch all exceptions and to free any used resources in the finally block.
*/

using System;
using System.Net;

class FileDownload
{
    static void Main()
    {
        Console.Title = "Download File";

        Console.WriteLine("Please, enter the web address of the file you want to download:");
        string webAddress = Console.ReadLine(); //http://telerikacademy.com/Content/Images/news-img01.png

        Console.WriteLine("Please, enter how you want to name the file:");
        string fileName = Console.ReadLine();

        try
        {
            Uri uri = new Uri(webAddress);
            DownloadFile(uri, fileName);
        }
        catch (ArgumentNullException)
        {
            if (webAddress == null)
            {
                Console.WriteLine("Error! No web address provided.");
            }

            if (fileName == null)
            {
                Console.WriteLine("Error! No name given for the file.");
            }
        }
        catch (UriFormatException)
        {
            Console.WriteLine("Error! Invalid web address.");
        }
        catch (WebException)
        {
            Console.WriteLine("An error occurred while downloading the file. Please, check the network connection!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Another download process is in progress. Please, try again later!");
        }
    }

    private static void DownloadFile(Uri uri, string fileName)
    {
        WebClient client = new WebClient();

        try
        {
            client.DownloadFile(uri, fileName);
        }
        finally
        {
            client.Dispose();
        }
    }
}