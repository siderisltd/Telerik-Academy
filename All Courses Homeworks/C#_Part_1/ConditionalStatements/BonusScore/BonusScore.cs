//Problem 2. Bonus Score
//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.


using System;

class BonusScore
{
    static void Main()
    {
        int bonusScore = new int();   // Holds the value of the bonus score
        Random randomBonus = new Random();  // Initialize a random number 
        bonusScore = randomBonus.Next(1, 10); // generate a random number and assign to bonusscore integer
        int number = bonusScore; // this is only for the output
        bool notNormal = bonusScore < 0 || bonusScore > 9; // Generating a bolean variable for exception bonus score

        if (notNormal == false)
        {
            switch (bonusScore)
            {
                case 1:
                case 2:
                case 3:
                    bonusScore *= 10;
                    break;
                case 4:
                case 5:
                case 6:
                    bonusScore *= 100;
                    break;
                case 7:
                case 8:
                case 9:
                    bonusScore *= 1000;
                    break;
                default:
                    break;
            }
            Console.WriteLine("number = {0}\r\nBonus score = {1}", number, bonusScore);
        }
        else
        {
            Console.WriteLine("invalid score");
        }

    }
}
