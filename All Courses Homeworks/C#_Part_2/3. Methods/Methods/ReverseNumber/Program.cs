//Problem 7. Reverse number
//Write a method that reverses the digits of given decimal number.


using System;

class Program
{
    static void Main()
    {
        decimal number = decimal.Parse(Console.ReadLine());

        decimal reversedNumber = Reversed(number);

       Console.WriteLine(reversedNumber);
    }

    private static decimal Reversed(decimal number)
    {
        // Правя го на стринг, тъпча го в нов стринг в обратен ред по индексите от цикъла и после го парсвам, за да може да се 
        //използва като стойност в Main()

        string holder = number.ToString();
        string stringRes = "";
        decimal result = new decimal();
        for (int i = holder.Length - 1; i >= 0; i--)
        {
            stringRes += holder[i];
        }
        result = decimal.Parse(stringRes);

        return result;        
    }
}

