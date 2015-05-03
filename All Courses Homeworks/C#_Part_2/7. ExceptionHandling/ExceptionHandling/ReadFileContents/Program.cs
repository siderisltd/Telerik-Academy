//Problem 3. Read file contents

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its 
//contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

namespace ReadFileContents
{
    class ReadFileContents
    {
        static void Main()
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "test.txt");
                StreamReader test = new StreamReader(path);
                using (test)
                {
                    String text = test.ReadToEnd();
                    Console.WriteLine(text);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("There is no such file ...");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The directory is not found");
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown exception occured");
            }
        }
    }
}
