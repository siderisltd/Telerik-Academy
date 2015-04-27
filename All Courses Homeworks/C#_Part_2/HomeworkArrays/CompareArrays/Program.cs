//Problem 2. Compare arrays
//Write a program that reads two integer arrays from the console and compares them element by element.


using System;

class Program
{
    static void Main()
    {
        Console.Write("How much numbers we will compare : ");
        int numbersCount = int.Parse(Console.ReadLine());
        int[] firstArr = new int[numbersCount];
        int[] secondArr = new int[numbersCount];
        Console.WriteLine("ENTER ELEMENTS");

        for (int i = 0; i < numbersCount; i++)
        {
            Console.Write("firstArr [{0}] element = ",i);
            firstArr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < numbersCount; i++)
        {
            Console.Write("secondArr [{0}] element = ",i);
            secondArr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < numbersCount; i++)
        {
            if (firstArr[i] == secondArr[i])
            {
                Console.WriteLine("firstArr[{0}] //{1}// = secondArr[{2}] //{3}//",i,firstArr[i],i,secondArr[i]);
            }
            else if (firstArr[i] != secondArr[i])
            {
                Console.WriteLine("firstArr[{0}] //{1}// != secondArr[{2}] //{3}//", i, firstArr[i], i, secondArr[i]);
            }
        }
    }
}
