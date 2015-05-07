using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blokus
{
    public class MoveFigure
    {

        public bool Move(FigureConstructor figura, int[,] Field, int owner, bool wantToEscape)
        {
            bool isPut = false;
            //if (owner == 4)
            //{
            //    redBr = 0;
            //    kolBr = 0;
            //}
            //if (owner == 3)
            //{
            //    redBr = 0;
            //    kolBr = 20;
            //}
            //if (owner == 2)
            //{
            //    redBr = 20;
            //    kolBr = 20;
            //}
            //if (owner == 1)
            //{
            //    redBr = 23;
            //    kolBr = 5;
            //}
            int redBr = 10;
            int kolBr = 10;
            for (int red = 4; red < Field.GetLength(0) - 4; red++)
            {
                for (int kol = 4; kol < Field.GetLength(1) - 4; kol++)
                {
                    if (red - redBr >= 0 && red - redBr < 9 && kol - kolBr >= 0 && kol - kolBr < 9 && figura.figure[red - redBr, kol - kolBr] == owner)
                    {
                        if (owner == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                        }
                        if(owner == 2)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        if(owner == 3)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                        }
                        if(owner == 4)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                        }
                        Console.Write(owner + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        if (Field[red, kol] == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                        }
                        if (Field[red, kol] == 2)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        if (Field[red, kol] == 3)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                        }
                        if (Field[red, kol] == 4)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                        }
                        Console.Write(Field[red, kol] + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                } Console.WriteLine();
            }
            while (isPut == false)
            {
                ConsoleKeyInfo k = new ConsoleKeyInfo();
                k = Console.ReadKey();
                Console.Clear();
                if (k.Key == ConsoleKey.Escape)
                {
                    return true;
                }
                if (k.Key == ConsoleKey.UpArrow)
                {
                    redBr -= 1;
                }
                if (k.Key == ConsoleKey.DownArrow)
                {
                    redBr += 1;
                }
                if (k.Key == ConsoleKey.LeftArrow)
                {
                    kolBr -= 1;
                }
                if (k.Key == ConsoleKey.RightArrow)
                {
                    kolBr += 1;
                }
                for (int rows = 0; rows < figura.figure.GetLength(0); rows++)
                {
                    for (int cols = 0; cols < figura.figure.GetLength(1); cols++)
                    {
                        if (figura.figure[rows, cols] == owner)
                        {
                            if (rows + redBr > Field.GetLength(0) - 5)
                            {
                                redBr -= 1;
                            }
                            if (cols + kolBr > Field.GetLength(1) - 5)
                            {
                                kolBr -= 1;
                            }
                            if (rows + redBr < 4)
                            {
                                redBr += 1;
                            }
                            if (cols + kolBr < 4)
                            {
                                kolBr += 1;
                            }

                        }
                    }
                }
                if (k.Key == ConsoleKey.Enter)
                {
                    if (CheckForMoves.canItFit(figura.figure, Field, redBr, kolBr, owner) == true)
                    {
                        for (int red = 4; red < Field.GetLength(0) - 4; red++)
                        {
                            for (int kol = 4; kol < Field.GetLength(1) - 4; kol++)
                            {
                                if (red - redBr >= 0 && red - redBr < 9 && kol - kolBr >= 0 && kol - kolBr < 9 && figura.figure[red - redBr, kol - kolBr] == owner)
                                {
                                    Field[red, kol] = owner;
                                }
                            }
                        }
                        isPut = true;
                    }
                    else
                    {
                        Console.WriteLine("wrong move");
                    }
                }
                for (int red = 4; red < Field.GetLength(0) - 4; red++)
                {
                    for (int kol = 4; kol < Field.GetLength(1) - 4; kol++)
                    {
                        if (red - redBr >= 0 && red - redBr < 9 && kol - kolBr >= 0 && kol - kolBr < 9 && figura.figure[red - redBr, kol - kolBr] == owner)
                        {
                            if (owner == 1)
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                            }
                            if (owner == 2)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                            }
                            if (owner == 3)
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                            }
                            if (owner == 4)
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                            }
                            Console.Write(owner + " ");
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else
                        {
                            if (Field[red, kol] == 1)
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                            }
                            if (Field[red, kol] == 2)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                            }
                            if (Field[red, kol] == 3)
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                            }
                            if (Field[red, kol] == 4)
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                            }
                            Console.Write(Field[red, kol] + " ");
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                    } Console.WriteLine();
                }
            }
            return false;
        }
    }
}
