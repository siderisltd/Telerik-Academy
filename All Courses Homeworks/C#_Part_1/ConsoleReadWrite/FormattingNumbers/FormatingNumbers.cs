//Problem 5. Formatting Numbers

//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

using System;
using System.Threading;
using System.Globalization;

    class FormatingNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string aString = Console.ReadLine();
            int a; 
            bool isParsed = int.TryParse(aString, out a);
            bool isCorrectFormat = a >= 0 && a <= 500 && isParsed == true;
            while (isParsed == false && isCorrectFormat == false )
            {
                Console.WriteLine("Enter correct format");
                aString = Console.ReadLine();
                isParsed = int.TryParse(aString, out a);
                isCorrectFormat = a >= 0 && a <= 500 && isParsed == true;

            }
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            string hexFormattedA = string.Format("{0,-10:X}", a);
            Console.Write("{0,-10}",hexFormattedA +" |"+ Convert.ToString(a,2).PadLeft(10,'0')+"|");
            Console.Write("{0,10:F2}",b);
            Console.Write("|");
            Console.Write("{0,-10:F3}", c);
            Console.WriteLine("|");





        }
    }
