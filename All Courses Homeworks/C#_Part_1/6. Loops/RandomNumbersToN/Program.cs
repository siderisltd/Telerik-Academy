//Problem 12.* Randomize the Numbers 1…N
//Write a program that enters an integer n and prints the numbers 1, 2, …, n in random order.


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int number = 0;
        List<int> dynamicArray = new List<int>();
        Random randomnumber = new Random();
        dynamicArray.Add(randomnumber.Next(1, n + 1));
        bool repeat = false;


        for (int i = 0; i < n - 1; i++)
        {

            for (int a = 1; a <= n * 10; a++)
            {
                number = randomnumber.Next(1, n + 1);
                for (int k = 0; k < dynamicArray.Count; k++)
                {
                    if (number == dynamicArray[k])
                    {
                        repeat = true;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (repeat == false)
                {
                    dynamicArray.Add(number);
                }
                repeat = false;

            }

        }
        foreach (var item in dynamicArray)
        {
            Console.Write(item + " ");
        }
    }
}