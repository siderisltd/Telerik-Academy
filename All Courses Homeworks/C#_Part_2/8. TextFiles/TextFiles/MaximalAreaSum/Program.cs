//Problem 5. Maximal area sum
//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
// The first line in the input file contains the size of matrix N.
// Each of the next N lines contain N numbers separated by space.
// The output should be a single number in a separate text file.


using System;
using System.IO;
using System.Linq;

namespace MaximalAreaSum
{
    class Program
    {
        static void Main()
        {
            //41
            StreamReader sr = new StreamReader(@"../../Files/matrix.txt");
            StreamWriter sw = new StreamWriter(@"../../Files/result.txt");
            string firstLine = sr.ReadLine();
            int length = int.Parse(firstLine);
            int[,] matrix = new int[length,length];
            int sum = 0;
            int bestSum = 0;
            string numbersInMatrix = string.Empty;
            while (firstLine != null)
            {
                firstLine = sr.ReadLine();
                //numbersInMatrix.Append(firstLine);
                numbersInMatrix += firstLine;
                numbersInMatrix += " ";
            }
            int[] numbers = numbersInMatrix.Split(new char[] { ' ','\n','\r' }, 
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int index = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = numbers[index];
                    index++;
                }
            }

            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                {
                    sum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows + 1, cols] + matrix[rows + 1, cols + 1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }
            using (sw)
            {
                sw.WriteLine(bestSum);
            }
        }
    }
}
