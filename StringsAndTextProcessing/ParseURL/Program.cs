/*Problem 12. Parse URL

    Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts
    from it the [protocol], [server] and [resource] elements.

Example:
URL 	                                                Information
http://telerikacademy.com/Courses/Courses/Details/212 	[protocol] = http
                                                        [server] = telerikacademy.com
                                                        [resource] = /Courses/Courses/Details/212
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Please, enter an URL: ");
        string url = Console.ReadLine();

        Uri uri = new Uri(url);

        Console.WriteLine("[protocol] = {0}", uri.Scheme);
        Console.WriteLine("[server] = {0}", uri.Host);
        Console.WriteLine("[resource] = {0}", uri.AbsolutePath);

        Console.ReadKey();
    }
}