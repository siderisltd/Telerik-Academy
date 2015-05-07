namespace MonopolyConsoleClient
{
    using System;
    using System.Threading;
    using System.IO;

    using Monopoly;
    using Monopoly.Cards;
    using Monopoly.GameLogic;
    using Monopoly.Interfaces;
    using Monopoly.Players;
    using MonopolyConsoleClient.DrawEngine;
    using MonopolyConsoleClient.Models.Players;

    class MonopolyEntryPoint
    {
        static void Main()
        {
            try
            {

                int playersCount = new int();

                #region Console and font resizing and intro screen
                //resize the console 
                ConsoleHelper.SetConsoleFont(2); //Set the font size to  the smallest possible
                Console.WindowHeight = Console.LargestWindowHeight - 1;
                Console.WindowWidth = Console.LargestWindowWidth - 4;
                ConsoleUtils.CenterConsole();
                SplashScreen.splashScreen();
                SplashScreen.WellcomeScreen();
                #endregion Console and font resizing and intro screen

                #region PlayersCount
                while (true)
                {
                    Console.Write("Type number of players as number on a single line : [2 , 3 or 4] : ");
                    string playerCountAsString = Console.ReadLine();

                    if (int.TryParse(playerCountAsString, out playersCount))
                    {
                        playersCount = int.Parse(playerCountAsString);



                        if (playersCount > 1 && playersCount <= 4)
                        {
                            // here will be player initializing and all this will goes to method or class playerInitializing
                            // for now it will be here so you can understand it easly
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!");
                    }
                }

                #endregion PlayersCount

                #region playersInitializing
                Player[] players = new Player[playersCount];

                if (playersCount == 2)
                {
                    Console.Write("Enter 1st player's name : ");
                    players[0] = new Player(1, Console.ReadLine(), Symbols.A);
                    Console.Write("Enter 2nd player's name : ");
                    players[1] = new Player(2, Console.ReadLine(), Symbols.B);

                    //TODO Trqbva da e v masiv za da moje da se izvikvat pored
                }
                if (playersCount == 3)
                {
                    Console.Write("Enter 1st player's name : ");
                    players[0] = new Player(1, Console.ReadLine(), Symbols.A);
                    Console.Write("Enter 2nd player's name : ");
                    players[1] = new Player(2, Console.ReadLine(), Symbols.B);
                    Console.Write("Enter 3rd player's name : ");
                    players[2] = new Player(3, Console.ReadLine(), Symbols.C);
                }
                if (playersCount == 4)
                {
                    Console.Write("Enter 1st player's name : ");
                    players[0] = new Player(1, Console.ReadLine(), Symbols.A);
                    Console.Write("Enter 2nd player's name : ");
                    players[1] = new Player(2, Console.ReadLine(), Symbols.B);
                    Console.Write("Enter 3rd player's name : ");
                    players[2] = new Player(3, Console.ReadLine(), Symbols.C);
                    Console.Write("Enter 4th player's name : ");
                    players[3] = new Player(4, Console.ReadLine(), Symbols.D);
                }
                #endregion playersInitializingplayer

                IDrawingEngine drawEngine = new ConsoleDrawEngine();
                GameManager manager = GameManager.GetInstance(drawEngine);
                manager.Game(players);
                var ChanceListCards = CardInitializer.InitializeChanceList();
                var CommunityListCards = CardInitializer.InitializeCommunityList();
            }
            catch (System.Exception)
            {
                Console.WriteLine("FATAL ERROR !!! :D:D:D");
            }
        }
    }
}
