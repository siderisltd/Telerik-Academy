using System;

public abstract class FigureConstructor
{
    //abstrakten klas, koito samite figuri 6te nasledqvat (ina4e kak da pazim cqlata info za vs figura tuk...)
    //deklaratorite za dostyp 6te bydat updeitnati dopylnitelno
    public int[,] figure; //pazi narisuvanata figura
    public int currentPossition;
    public int owner; //payer nomer
    public bool isPut;
    public int score;
    public int number;
    public FigureConstructor() { }
    public FigureConstructor(int player)
    {
        isPut = false;
        currentPossition = 0;
        owner = player;


        // da se inicializira i zanuli masiva
        figure = new int[9, 9];
        for (short i = 0; i < 8; i++)
        {
            for (short j = 0; j < 8; j++)
                figure[i, j] = 0;
        }
    }

    public abstract void rotate();

    public int[,] GetFigure()
    {
        return figure;
    }
    public void print(int coll, int roww)
    {
        Console.SetCursorPosition(coll, roww);
        for (int rows = 0; rows < 9; rows++)
        {
            for (int cols = 0; cols < 9; cols++)
            {
                if (owner == 1)
                {
                    if (figure[rows, cols] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(figure[rows, cols] + " ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(figure[rows, cols] + " ");
                    }

                }
                if (owner == 2)
                {
                    if (figure[rows, cols] == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(figure[rows, cols] + " ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(figure[rows, cols] + " ");
                    }
                }
                if (owner == 3)
                {
                    if (figure[rows, cols] == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write(figure[rows, cols] + " ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(figure[rows, cols] + " ");
                    }
                }
                if (owner == 4)
                {
                    if (figure[rows, cols] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(figure[rows, cols] + " ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(figure[rows, cols] + " ");
                    }
                }
                Console.BackgroundColor = ConsoleColor.Black;
            }
            roww += 1;
            Console.SetCursorPosition(coll, roww);
        }
       
    }
    public void PrintFigure(int colPos, int rowPos)
    {
        for (int rows = 0; rows < figure.GetLength(0); rows++)
        {
            for (int cols = 0; cols < figure.GetLength(1); cols++)
            {
                if (owner == 1)
                {
                    if (figure[rows, cols] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(figure[rows, cols] + " ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(figure[rows, cols] + " ");
                    }

                }
                if (owner == 2)
                {
                    if (figure[rows, cols] == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(figure[rows, cols] + " ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(figure[rows, cols] + " ");
                    }
                }
                if (owner == 3)
                {
                    if (figure[rows, cols] == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write(figure[rows, cols] + " ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(figure[rows, cols] + " ");
                    }
                }
                if (owner == 4)
                {
                    if (figure[rows, cols] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(figure[rows, cols] + " ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(figure[rows, cols] + " ");
                    }
                }
                Console.BackgroundColor = ConsoleColor.Black;
                //Console.Write(figure[rows,cols] + " ");
            }
            rowPos += 1;
            Console.SetCursorPosition(colPos, rowPos);
        }
    }


}


