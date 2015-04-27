//Problem 3. Check for a Play Card
//Classical play cards use the following signs to designate the 
//card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a 
//string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:


using System;

class Program
{
    static void Main()
    {
        bool isTrueCard = false;
        //string input = "K";
        string input = Console.ReadLine();
        string[] standardCards = new string[15];
        for (int i = 2; i <= 10; i++)
        {
            standardCards[i] = Convert.ToString(i);
        }
        standardCards[11] = "J";
        standardCards[12] = "Q";
        standardCards[13] = "K";
        standardCards[14] = "A";
        for (int i = 0; i < standardCards.Length; i++)
        {
            if (input == standardCards[i])
            {
                isTrueCard = true;
            }
        }
        Console.WriteLine(isTrueCard?"yes":"no");
    }
}
