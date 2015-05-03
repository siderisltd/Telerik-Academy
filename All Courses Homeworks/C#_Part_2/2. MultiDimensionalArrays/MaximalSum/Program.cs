//Problem 2. Maximal sum
//Write a program that reads a rectangular matrix of size N x M and finds in it the 
//square 3 x 3 that has maximal sum of its elements.


using System;

class Program
{
    static void Main()
    {
        //int matrixRows = int.Parse(Console.ReadLine());
        //int matrixCols = int.Parse(Console.ReadLine());

        int sum = 0;
        int bestSum = 0;


        int[,] matrix = new int[,]
        {
            {1,2,1,4,5,6},
            {2,1,4,5,6,7},
            {1,6,10,10,10,1},
            {1,5,10,60,10,8},
            {27,7,20,10,10,4},
            {1,1,1,11,1,1}
            
        };
      
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                sum += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + 
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                    + matrix[row+2,col] + matrix[row+2,col+1] + matrix[row+2,col+2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
                sum = 0;
            }
        }

        Console.WriteLine(bestSum);
    }
}

