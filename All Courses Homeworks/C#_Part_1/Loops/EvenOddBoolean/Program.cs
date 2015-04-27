//Problem 10. Odd and Even Product
//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string number = Console.ReadLine();
        List<int> numbers = new List<int>();
        int oddProduct = 1;
        int evenProduct = 1;
        
        string[] splitedNumbers = number.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int index = 0; index < splitedNumbers.Length; index++)
        {
            numbers.Add(int.Parse(splitedNumbers[index]));
        }
        for (int i = 0; i < numbers.Count; i++)
        {
            if (i % 2 == 0)
            {
                evenProduct *= numbers[i];
            }
            else
            {
                oddProduct *= numbers[i];
            }
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("Product =" + evenProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product" + oddProduct);
            Console.WriteLine("even_product" + evenProduct);
        }

    }
}
