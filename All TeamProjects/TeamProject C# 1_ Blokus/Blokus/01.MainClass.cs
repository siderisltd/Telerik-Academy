using System;
using System.IO;

namespace Blokus
{
    class MainClass
    {
        public static int playerCount;
        public static void Main(string[] args)
        {

            //var test = new Figure5(2);

            //for (int i = 0; i < 15; i++)
            //{
            //    test.print();
            //    test.rotate();
            //}
            #region Console and font resizing
            //resize the console 
            ConsoleHelper.SetConsoleFont(5); //Set the font size to  the smallest possible
            Console.WindowHeight = Console.LargestWindowHeight - 1;
            Console.WindowWidth = Console.LargestWindowWidth - 4;
            ConsoleUtils.CenterConsole();
            #endregion Console and font resizing

            #region splashScreen
            ConsoleHelper.SplashScreen();
            Console.Write("{0,15}", "Choose how many players will play: ");
            #endregion splashScreen

            #region PlayersCount

            while (true)
            {

                string playerCountAsString = Console.ReadLine();

                if (int.TryParse(playerCountAsString, out playerCount))
                {
                    playerCount = int.Parse(playerCountAsString);


                    if (playerCount > 1 && playerCount <= 4)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You can play only with 2, 3 or 4 players");
                    }
                }
                else
                {
                    Console.WriteLine("You can play only with 2, 3 or 4 players");
                }
            }
            #endregion PlayersCount

            Player[] players = new Player[playerCount];
            #region playersInitializing
            if (playerCount == 2)
            {
                Console.Write("Enter 1st player's name : ");
                players[0] = new Player(1, Console.ReadLine());
                players[0].fillingStack();
                Console.Write("Enter 2nd player's name : ");
                players[1] = new Player(2, Console.ReadLine());
                players[1].fillingStack();

                //TODO Trqbva da e v masiv za da moje da se izvikvat pored
            }
            if (playerCount == 3)
            {
                Console.Write("Enter 1st player's name : ");
                players[0] = new Player(1, Console.ReadLine());
                players[0].fillingStack();
                Console.Write("Enter 2nd player's name : ");
                players[1] = new Player(2, Console.ReadLine());
                players[1].fillingStack();
                Console.Write("Enter 3rd player's name : ");
                players[2] = new Player(3, Console.ReadLine());
                players[2].fillingStack();
            }
            if (playerCount == 4)
            {
                Console.Write("Enter 1st player's name : ");
                players[0] = new Player(1, Console.ReadLine());
                players[0].fillingStack();
                Console.Write("Enter 2nd player's name : ");
                players[1] = new Player(2, Console.ReadLine());
                players[1].fillingStack();
                Console.Write("Enter 3rd player's name : ");
                players[2] = new Player(3, Console.ReadLine());
                players[2].fillingStack();
                Console.Write("Enter 4th player's name : ");
                players[3] = new Player(4, Console.ReadLine());
                players[3].fillingStack();

            }
            #endregion playersInitializingplayer
            Console.Clear();
            bool GameOver = false;
            bool isFigLeft = false;
            int currentPlayer = 0;

            Field constructField = new Field();
            constructField.FillingMatrix();
            while (!GameOver)
            {

                isFigLeft = false;
                // DRAW FIELD I FIRST PLAYER'S STACK
                if (CheckForMoves.haveTurn(players[currentPlayer].playerStack, constructField.playField, currentPlayer + 1) == false)
                {
                    players[currentPlayer].hasMoves = false;
                }
                for (int i = 0; i < playerCount; i++)
                {
                    if (players[i].hasMoves == true)
                    {
                        break;
                    }
                    if (i == playerCount - 1)
                    {
                        if (players[i].hasMoves == false)
                        {
                            GameOver = true;
                        }
                    }
                }
                // CHECK IF PLAYER HAS MOVES 
                if (players[currentPlayer].hasMoves == true)
                {
                    int currentFigure = new int();
                    // FIRSTPLAYER CHOOSE FIGURE 
                    bool ret;
                    bool wantToEscape = false;
                    while (true)
                    {
                        int counter = 0;
                        int curCol = 48;
                        int curRow = 0;
                        foreach (var fig in players[currentPlayer].playerStack)
                        {
                            if (fig.isPut == false)
                            {
                                Console.SetCursorPosition(curCol,curRow);
                                Console.Write("[{0}]",fig.number);
                                Console.SetCursorPosition(curCol, curRow + 1);
                                fig.PrintFigure(curCol, curRow);
                                counter++;
                                curRow += 12;
                                
                            }
                            if (counter > 3)
                            {
                                curCol += 12; // 22 beshe za distanciqta pri risuvaneto
                                curRow -= 48;
                                counter = 0;
                            }
                        }
                        Console.SetCursorPosition(0, 22);
                        ret = false;
                        isFigLeft = false;
                        Console.WriteLine("It is player {0} turn:", currentPlayer + 1);
                        Console.Write("Chose a figure number: ");
                        string playerChoise = Console.ReadLine();

                        if (int.TryParse(playerChoise, out currentFigure))
                        {
                            currentFigure = int.Parse(playerChoise);

                            if (players[currentPlayer].playerStack[currentFigure - 1].isPut == true)
                            {


                                while (players[currentPlayer].playerStack[currentFigure - 1].isPut == true)
                                {
                                    Console.Write("Chose a figure that is not alredy used: ");
                                    playerChoise = Console.ReadLine();
                                    if (int.TryParse(playerChoise, out currentFigure))
                                    {
                                        currentFigure = int.Parse(playerChoise);
                                    }
                                    else
                                    {
                                        Console.Write("Chose a figure that is not alredy used: ");
                                        playerChoise = Console.ReadLine();
                                    }
                                }
                            }
                            if (currentFigure >= 1 && currentFigure <= 21)
                            {
                                Console.Write("Choose rotation: ");
                                while (true)
                                {
                                    ConsoleKeyInfo k = Console.ReadKey();
                                    
                                    if (k.Key == ConsoleKey.Spacebar)
                                    {
                                        players[currentPlayer].playerStack[currentFigure - 1].rotate();
                                        Console.WriteLine();
                                        players[currentPlayer].playerStack[currentFigure - 1].print(0,26);
                                        

                                    }
                                    if (k.Key == ConsoleKey.Enter)
                                    {
                                        Console.Clear();
                                        MoveFigure fig = new MoveFigure();
                                        wantToEscape = fig.Move(players[currentPlayer].playerStack[currentFigure - 1], constructField.playField, currentPlayer + 1, wantToEscape);
                                        if (wantToEscape == true)
                                        {
                                            ret = true;
                                            break;
                                        }
                                        else
                                        {
                                            players[currentPlayer].playerScore += players[currentPlayer].playerStack[currentFigure - 1].score;
                                            isFigLeft = true;
                                            players[currentPlayer].playerStack[currentFigure - 1].isPut = true;
                                        }
                                    }
                                    if (isFigLeft)
                                    {
                                        currentPlayer++;
                                        if (currentPlayer > playerCount - 1)
                                        {
                                            currentPlayer = 0;
                                        }
                                        ret = true;
                                        break;

                                    }
                                    if (k.Key == ConsoleKey.Escape)
                                    {
                                        ret = true;
                                        break;

                                    }

                                }
                                if (ret)
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Figures are integers from 1 to 21");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Figures are integers from 1 to 21");
                        }
                    }
                }
                Console.Clear();
                for(int i=0;i<playerCount;i++)
                {
                    Console.WriteLine("{0} has {1} points", players[i].playerName, players[i].playerScore);
                }

                // PLAYER CHOOSE ROTATION

                // FIRSTPLAYER CHOOSE PLACE ON FIELD OR CHOOSE ANOTHER FIGURE

                // IF FIGURE IS LEFT ON THE FIELD --> NEXTPLAYER
            }
            //{

            //}
            // WINNER 






            //Player first = new Player(1,"Ivan");






        }
    }
}
