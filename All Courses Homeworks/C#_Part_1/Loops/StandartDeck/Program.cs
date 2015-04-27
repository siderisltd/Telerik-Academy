using System;

class Program
{
    static void Main()
    {
        string cardName = "JQKA";
        for (int cards = 2; cards <= 10; cards++)
        {
            for (int suits = 1; suits <= 4; suits++)
            {
                switch (suits)
                {
                    case 1:
                        Console.Write(cards + " of spades, ");
                        break;
                    case 2:
                        Console.Write(cards + " of clubs, ");
                        break;
                    case 3:
                        Console.Write(cards + " of hearts, ");
                        break;
                    case 4:
                        Console.Write(cards + " of diamonds");
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
        }
        for (int i = 0; i < 4; i++)
        {
            for (int suits = 1; suits <= 4; suits++)
            {
                switch (suits)
                {
                    case 1:
                        Console.Write(cardName[i] + " of spades, ");
                        break;
                    case 2:
                        Console.Write(cardName[i] + " of clubs, ");
                        break;
                    case 3:
                        Console.Write(cardName[i] + " of hearts, ");
                        break;
                    case 4:
                        Console.Write(cardName[i] + " of diamonds");
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
