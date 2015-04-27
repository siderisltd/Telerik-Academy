//Problem 3. Sequence n matrix
//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of 
//several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.


using System;

class Program
{
    static void Main()
    {
        string[,] matrix = new string[3,4];

        matrix[0, 0] = "ha";
        matrix[0, 1] = "fifi";
        matrix[0, 2] = "ho";
        matrix[0, 3] = "hi";
        matrix[1, 0] = "fo";
        matrix[1, 1] = "ha";
        matrix[1, 2] = "hi";
        matrix[1, 3] = "xx";
        matrix[2, 0] = "xxx";
        matrix[2, 1] = "ho";
        matrix[2, 2] = "ha";
        matrix[2, 3] = "xx";

        //proverka na pravite redove i izvajdane na nai golemiq string v promenliva, koqto durji kakuv e toi i kolko puti se
        //sadurja
        int bestStraitLineCount = -1;
        int count = 1;
        string word = string.Empty;
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
            {
                string currentWord = matrix[rows, cols];
                if (currentWord == matrix [rows,cols + 1] && bestStraitLineCount <= count)
                {
                    count++;
                    bestStraitLineCount = count;
                    word = matrix[rows, cols];
                }
            }
            count = 1;
        }
        //Console.WriteLine(word);
        //Console.WriteLine(bestStraitLineCount);


        // proverka na vertikalite i stoinostite im i pravene na sushtoto 

        string rowsWord = string.Empty;
        int numberRowWord = -1;

        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                string currentWord = matrix[rows, cols];
                if (currentWord == matrix[rows + 1, cols] && numberRowWord <= count)
                {
                    count++;
                    numberRowWord = count;
                    rowsWord = matrix[rows, cols];
                }
            }
            count = 1;
        }

        //Console.WriteLine(numberRowWord);
        //Console.WriteLine(rowsWord);
        // proverka na diagonalite 


        int diagonalCount = -1;
        count = 1;
        string wordDiagonal = string.Empty;
        string currWord = string.Empty;
        currWord = matrix[0, 0];

        for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
            {
                if (currWord == matrix[rows + 1, cols + 1] && diagonalCount <= count)
                {
                    count++;
                    diagonalCount = count;
                    wordDiagonal = matrix[rows + 1, cols + 1];
                    currWord = wordDiagonal;
                  
                }
            }
            count = 1;
        }

        Console.WriteLine(diagonalCount);
        Console.WriteLine(wordDiagonal);

        // В момента го правя 18.02 23:54 и май няма да мога да го довърша, остава да оправя  :D
        // диагоналите и да ги сравня само кое е най голямото иначе за редове или за колони си работи перфектно



        


        //for (int i = 0; i < matrix.GetLength(0); i++)
        //{
        //    for (int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        Console.Write(matrix[i,j] + " | ");
        //    }
        //    Console.WriteLine();
        //}
    }
}

