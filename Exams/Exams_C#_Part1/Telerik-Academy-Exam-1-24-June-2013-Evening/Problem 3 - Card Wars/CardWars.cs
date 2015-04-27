using System;

class Program
{
    static void Main()
    {
        int numberOfGames = int.Parse(Console.ReadLine());

        int firstPlayerPoints = 0;
        int secondPlayerPoints = 0;
        int firstPlayergameswon = 0;
        int secondPlayergameswon = 0;

        for (int i = 0; i < numberOfGames; i++)
        {
            string firstCard = Console.ReadLine();
            string firstsecCard = Console.ReadLine();
            string firstthCard = Console.ReadLine();
            string secondFirstCard = Console.ReadLine();
            string secondSecCard = Console.ReadLine();
            string secondThCard = Console.ReadLine();

            int firstXcount = 0;
            int firstYcount = 0;
            int firstZcount = 0;

            int secondXcount = 0;
            int secondYcount = 0;
            int secondZcount = 0;

            switch (firstCard)
            {
                case "2":
                    firstPlayerPoints += 10;
                    break;
                case "3":
                    firstPlayerPoints += 9;
                    break;
                case "4":
                    firstPlayerPoints += 8;
                    break;
                case "5":
                    firstPlayerPoints += 7;
                    break;
                case "6":
                    firstPlayerPoints += 6;
                    break;
                case "7":
                    firstPlayerPoints += 5;
                    break;
                case "8":
                    firstPlayerPoints += 4;
                    break;
                case "9":
                    firstPlayerPoints += 3;
                    break;
                case "10":
                    firstPlayerPoints += 2;
                    break;
                case "A":
                    firstPlayerPoints += 1;
                    break;
                case "J":
                    firstPlayerPoints += 11;
                    break;
                case "Q":
                    firstPlayerPoints += 12;
                    break;
                case "K":
                    firstPlayerPoints += 13;
                    break;
                case "X":
                    firstXcount++;
                    break;
                case "Y":
                    firstYcount++;
                    break;
                case "Z":
                    firstZcount++;
                    break;

                default:
                    break;
            }
            switch (firstsecCard)
            {
                case "2":
                    firstPlayerPoints += 10;
                    break;
                case "3":
                    firstPlayerPoints += 9;
                    break;
                case "4":
                    firstPlayerPoints += 8;
                    break;
                case "5":
                    firstPlayerPoints += 7;
                    break;
                case "6":
                    firstPlayerPoints += 6;
                    break;
                case "7":
                    firstPlayerPoints += 5;
                    break;
                case "8":
                    firstPlayerPoints += 4;
                    break;
                case "9":
                    firstPlayerPoints += 3;
                    break;
                case "10":
                    firstPlayerPoints += 2;
                    break;
                case "A":
                    firstPlayerPoints += 1;
                    break;
                case "J":
                    firstPlayerPoints += 11;
                    break;
                case "Q":
                    firstPlayerPoints += 12;
                    break;
                case "K":
                    firstPlayerPoints += 13;
                    break;
                case "X":
                    firstXcount++;
                    break;
                case "Y":
                    firstYcount++;
                    break;
                case "Z":
                    firstZcount++;
                    break;

                default:
                    break;
            }
            switch (firstthCard)
            {


                case "2":
                    firstPlayerPoints += 10;
                    break;
                case "3":
                    firstPlayerPoints += 9;
                    break;
                case "4":
                    firstPlayerPoints += 8;
                    break;
                case "5":
                    firstPlayerPoints += 7;
                    break;
                case "6":
                    firstPlayerPoints += 6;
                    break;
                case "7":
                    firstPlayerPoints += 5;
                    break;
                case "8":
                    firstPlayerPoints += 4;
                    break;
                case "9":
                    firstPlayerPoints += 3;
                    break;
                case "10":
                    firstPlayerPoints += 2;
                    break;
                case "A":
                    firstPlayerPoints += 1;
                    break;
                case "J":
                    firstPlayerPoints += 11;
                    break;
                case "Q":
                    firstPlayerPoints += 12;
                    break;
                case "K":
                    firstPlayerPoints += 13;
                    break;
                case "X":
                    firstXcount++;
                    break;
                case "Y":
                    firstYcount++;
                    break;
                case "Z":
                    firstZcount++;
                    break;

                default:
                    break;

            }
            switch (secondFirstCard)
            {

                case "2":
                    secondPlayerPoints += 10;
                    break;
                case "3":
                    secondPlayerPoints += 9;
                    break;
                case "4":
                    secondPlayerPoints += 8;
                    break;
                case "5":
                    secondPlayerPoints += 7;
                    break;
                case "6":
                    secondPlayerPoints += 6;
                    break;
                case "7":
                    secondPlayerPoints += 5;
                    break;
                case "8":
                    secondPlayerPoints += 4;
                    break;
                case "9":
                    secondPlayerPoints += 3;
                    break;
                case "10":
                    secondPlayerPoints += 2;
                    break;
                case "A":
                    secondPlayerPoints += 1;
                    break;
                case "J":
                    secondPlayerPoints += 11;
                    break;
                case "Q":
                    secondPlayerPoints += 12;
                    break;
                case "K":
                    secondPlayerPoints += 13;
                    break;
                case "X":
                    secondXcount++;
                    break;
                case "Y":
                    secondYcount++;
                    break;
                case "Z":
                    secondZcount++;
                    break;

                default:
                    break;
            }
            switch (secondSecCard)
            {

                case "2":
                    secondPlayerPoints += 10;
                    break;
                case "3":
                    secondPlayerPoints += 9;
                    break;
                case "4":
                    secondPlayerPoints += 8;
                    break;
                case "5":
                    secondPlayerPoints += 7;
                    break;
                case "6":
                    secondPlayerPoints += 6;
                    break;
                case "7":
                    secondPlayerPoints += 5;
                    break;
                case "8":
                    secondPlayerPoints += 4;
                    break;
                case "9":
                    secondPlayerPoints += 3;
                    break;
                case "10":
                    secondPlayerPoints += 2;
                    break;
                case "A":
                    secondPlayerPoints += 1;
                    break;
                case "J":
                    secondPlayerPoints += 11;
                    break;
                case "Q":
                    secondPlayerPoints += 12;
                    break;
                case "K":
                    secondPlayerPoints += 13;
                    break;
                case "X":
                    secondXcount++;
                    break;
                case "Y":
                    secondYcount++;
                    break;
                case "Z":
                    secondZcount++;
                    break;

                default:
                    break;
            }
            switch (secondThCard)
            {

                case "2":
                    secondPlayerPoints += 10;
                    break;
                case "3":
                    secondPlayerPoints += 9;
                    break;
                case "4":
                    secondPlayerPoints += 8;
                    break;
                case "5":
                    secondPlayerPoints += 7;
                    break;
                case "6":
                    secondPlayerPoints += 6;
                    break;
                case "7":
                    secondPlayerPoints += 5;
                    break;
                case "8":
                    secondPlayerPoints += 4;
                    break;
                case "9":
                    secondPlayerPoints += 3;
                    break;
                case "10":
                    secondPlayerPoints += 2;
                    break;
                case "A":
                    secondPlayerPoints += 1;
                    break;
                case "J":
                    secondPlayerPoints += 11;
                    break;
                case "Q":
                    secondPlayerPoints += 12;
                    break;
                case "K":
                    secondPlayerPoints += 13;
                    break;
                case "X":
                    secondXcount++;
                    break;
                case "Y":
                    secondYcount++;
                    break;
                case "Z":
                    secondZcount++;
                    break;

                default:
                    break;
            }
            if (firstXcount != 0)
            {
                if (firstXcount == secondXcount)
                {
                    firstPlayerPoints += 50;
                    secondPlayerPoints += 50;
                }
                else
                {
                    Console.WriteLine("X card drawn! Player one wins the match!");
                    firstPlayergameswon++;
                    return;
                }
            }
            if (secondXcount !=0)
            {
                if (firstXcount == secondXcount)
                {
                    firstPlayerPoints += 50;
                    secondPlayerPoints += 50;
                }
                else
                {
                    Console.WriteLine("X card drawn! Player two wins the match!");
                    secondPlayergameswon++;
                    return;
                }
            }
            if (firstYcount == 1)
            {
                firstPlayerPoints -= 200;
            }
            if (firstYcount == 2)
            {
                firstPlayerPoints -= 400;
            }
            if (firstYcount == 3)
            {
                firstPlayerPoints -= 600;
            }
            if (secondYcount==1)
            {
                secondPlayerPoints -= 200;
            }
            if (secondYcount == 2)
            {
                secondPlayerPoints -= 400;
            }
            if (secondYcount == 3)
            {
                secondPlayerPoints -= 600;
            }

            if (firstZcount == 1)
            {
                firstPlayerPoints *= 2;
            }
            if (firstZcount == 2)
            {
                firstPlayerPoints *= 4;
            }
            if (firstZcount == 3)
            {
                firstPlayerPoints *= 8;
            }

            if (secondZcount == 1)
            {
                secondPlayerPoints *= 2;
            }
            if (secondZcount == 2)
            {
                secondPlayerPoints *= 4;
            }
            if (secondZcount == 3)
            {
                secondPlayerPoints *= 8;
            }

            //dali sa ravni 

            if (firstPlayerPoints > secondPlayerPoints)
            {
                firstPlayergameswon++;
            }
            if (firstPlayerPoints < secondPlayerPoints)
            {
                secondPlayergameswon++;
            }
            if (firstPlayerPoints == secondPlayerPoints)
            {
                firstPlayerPoints = 0;
                secondPlayerPoints = 0;
                continue;
            }
        }
        if (firstPlayergameswon == secondPlayergameswon)
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}",firstPlayerPoints);
        }
        if (firstPlayergameswon > secondPlayergameswon)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}",firstPlayerPoints);
            Console.WriteLine("Games won: {0}",firstPlayergameswon);
        }
        if (firstPlayergameswon < secondPlayergameswon)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", secondPlayerPoints);
            Console.WriteLine("Games won: {0}", secondPlayergameswon);
        }
    }
}