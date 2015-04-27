//Problem 4. Download file
//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block

using System;
using System.IO;
using System.Net;

namespace DownloadFile
{
    class DownloadFile
    {
        static void Main()
        {
            try
            {
                WebClient client = new WebClient();
                client.DownloadFile("http://academy.telerik.com/images/default-album/programming-champion-telerik-academy.png?sfvrsn=2", @"ninja.jpg");
                Console.WriteLine("Download complete !");

            }
            catch (WebException)
            {

                Console.WriteLine("There is no such web address");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Out of memory");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Argument null");
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown exception occured");
            }
        }
    }
}
