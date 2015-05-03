//Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4:

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.Clear();

        int[,] aMatrix = new int[n, n];
        int num = 1;
        for (int row = 0; row < aMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < aMatrix.GetLength(1); col++)
            {
                aMatrix[col, row] = num;
                num++;
            }
        }
        Console.WriteLine("a)");
        Console.WriteLine();
        Print(aMatrix);

        int[,] bMatrix = new int[n, n];
        num = 1;
        int reversedNum = 2 * n;
        int power = 1;
        for (int row = 0; row < bMatrix.GetLength(0); row++)
        {

            for (int col = 0; col < bMatrix.GetLength(1); col++)
            {

                if (row % 2 == 0)
                {
                    bMatrix[col, row] = num;
                }
                else
                {
                    if (col == 0)
                    {
                        reversedNum = n * power;
                    }
                    bMatrix[col, row] = reversedNum;
                    reversedNum--;
                }
                num++;
            }
            power++;
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("b)");
        Console.WriteLine();
        Print(bMatrix);




        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("c)");
        Console.WriteLine();

        int[,] cMatrix = new int[n, n];
        num = 1;
        int rowBackCounter = 1;
        int colBackCounter = 0;
        int maxCount = n * n;
        for (int row = n - 1; row >= 0; row--)
        {
            for (int col = 0; col < cMatrix.GetLength(1); )
            {
                cMatrix[row, col] = num;
                if (num == maxCount)
                {
                    break;
                }
                else if (row == n - 1 && col != n - 1)
                {
                    row -= rowBackCounter;
                    col -= colBackCounter;
                    rowBackCounter++;
                    colBackCounter++;
                }
                else if (row == n - 1 || col == n - 1)
                {
                    colBackCounter--;
                    rowBackCounter--;
                    col -= colBackCounter;
                    row -= rowBackCounter;
                }
                else
                {
                    row++;
                    col++;
                }
                num++;
            }
            Print(cMatrix);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("d)");
            Console.WriteLine();


            int[,] dMatrix = new int[n, n];
            num = 1;
            int rows = 0;
            int cols = 0;
            maxCount = n * n;
            string direction = "down";

            for (int i = num; i <= maxCount + 1; i++)
            {

                if (direction == "down")
                {
                    if (rows + 1 > dMatrix.GetLength(0) || dMatrix[rows, cols] != 0)
                    {
                        direction = "right";
                        rows--;
                        cols++;

                    }
                    else
                    {
                        dMatrix[rows, cols] = num;
                        rows++;
                        num++;
                    }
                }
                if (direction == "right")
                {

                    if (cols + 1 > dMatrix.GetLength(1) || dMatrix[rows, cols] != 0)
                    {
                        direction = "up";
                        cols--; ;
                        rows--; ;
                    }
                    else
                    {
                        dMatrix[rows, cols] = num;
                        cols++;
                        num++;
                    }

                }
                if (direction == "up")
                {
                    if (rows < 0 || dMatrix[rows, cols] != 0)
                    {
                        direction = "left";
                        cols--;
                        rows++;
                    }
                    else
                    {
                        dMatrix[rows, cols] = num;
                        rows--;
                        num++;
                    }
                }
                if (direction == "left")
                {
                    if (cols < 0 || dMatrix[rows,cols] != 0)
                    {
                        direction = "down";
                        cols++;
                        rows++;
                    }
                    else
                    {
                        dMatrix[rows, cols] = num;
                        cols--;
                        num++;
                    }

                }

                i = num;
            }




            Print(dMatrix);
        }
    }
    static void Print(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-4}",matrix[row,col]);
            }
            Console.WriteLine();
        }
    }
}

