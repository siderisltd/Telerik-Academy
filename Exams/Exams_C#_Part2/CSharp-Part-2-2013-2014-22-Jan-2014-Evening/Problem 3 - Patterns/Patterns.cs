using System;
using System.Linq;


namespace Patterns
{
    class Program
    {
        static void Main()
        {
            //input
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = ReadingMatrix(n);
            //output variables
            int result = new int();
            bool hasPattern = false;
            //main logic and checks
            

            for (int rows = 0; rows < matrix.GetLength(0) - 2 ; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 4; cols++)
                {
                    if (matrix[rows, cols] + 1 == matrix[rows,cols + 1])
                    {
                        if (matrix[rows,cols + 1] + 1 == matrix[rows,cols + 2])
                        {
                            if (matrix[rows,cols + 2]  + 1 == matrix[rows + 1,cols +2])
                            {
                                if (matrix[rows + 1, cols + 2] + 1== matrix[rows + 2, cols + 2])
                                {
                                    if (matrix[rows + 2,cols + 2] + 1== matrix[rows + 2,cols + 3])
                                    {
                                        if (matrix[rows + 2,cols+3] + 1== matrix[rows + 2, cols + 4])
                                        {
                                            hasPattern = true;
                                            int sum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows, cols + 2] +
                                                matrix[rows + 1, cols + 2] + matrix[rows + 2, cols + 2] +
                                                matrix[rows + 2, cols + 3] + matrix[rows + 2, cols + 4];
                                            if (sum > result)
                                            {
                                                result = sum;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }

            
            //patternComparer


            //if no pattern
            #region no pattern
            if (hasPattern == false)
            {
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    for (int cols = rows; cols < rows + 1; cols++)
                    {
                        result += matrix[rows, cols];
                    }
                }
            }
            #endregion no pattern

            //output
            Console.WriteLine((hasPattern ?"YES" : "NO") + " " + result);
        }

        private static int[,] ReadingMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int index = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    int currentDigit = input[index];
                    matrix[rows, cols] = currentDigit;
                    index++;
                }
                index = 0;
                if (rows != matrix.GetLength(0) - 1)
                {
                    input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                }

            }
            return matrix;
        }
    }
}