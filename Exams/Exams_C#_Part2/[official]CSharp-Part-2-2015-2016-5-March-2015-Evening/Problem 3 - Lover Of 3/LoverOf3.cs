using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoverOf3
{
    class Program
    {
        static void Main()
        {
            #region variables
            string[] matrixDimensions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int rows = int.Parse(matrixDimensions[0]);
            int cols = int.Parse(matrixDimensions[1]);

            //chetem si vhoda
            int directionsCount = int.Parse(Console.ReadLine());
            string[] directions = new string[directionsCount];
            for (int i = 0; i < directionsCount; i++)
            {
                directions[i] = Console.ReadLine();
            }


            #endregion variables
            #region MatrixInitializing

            int num = 0;
            int numnum = 0;
            int[,] Field = new int[rows, cols];

            for (int row = Field.GetLength(0) - 1 ; row >= 0; row--)
            {

                for (int col = 0; col < Field.GetLength(1); col++)
                {
                    Field[row, col] = num;
                    num += 3;
                }
                num = 0;
                numnum += 3;
                num = numnum;
            }

            //Print(Field);
            #endregion MatrixInitializing
            
           
            //vinagi zapochva ot nai dolniq lqv ugul


           // Print(Field);   //ako trqbva da si printiram poleto
            
            //logic
            #region logic
            //buleva matrica da ni sledi dali e hodila peshkata tam
            bool[,] isVisited = new bool[rows, cols];

            int pionkaSum = Field[Field.GetLength(0) - 1, 0];
            //cukame, che poleto kudeto e bila peshkata veche e bila tam
            int redowe = Field.GetLength(0) - 1;
            int koloni = 0;
            isVisited[redowe, koloni] = true;

            for (int i = 0; i < directions.Length; i++)
            {

                //da vzemem direkciqta samo i da pazim i stoinostta i
                string[] dir = directions[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string currDir = dir[0];
                int value = int.Parse(dir[1]);


                //int fieldRow = Field.GetLength(0);
                //int fieldCol = Field.GetLength(1);
                //Print(Field);

                switch (currDir)
                {
                    case "RU":
                        for (int j = 1; j < value; j++)
                        {
                            if (redowe - 1 >= 0 && koloni + 1 <= Field.GetLength(1) - 1)
                            {
                                redowe--;
                                koloni++;
                            }

                            if (isVisited[redowe, koloni] == false)
                            {
                                pionkaSum += Field[redowe, koloni];
                                isVisited[redowe, koloni] = true;
                            }
                        }
                        break;
                    case "UR":
                        for (int j = 1; j < value; j++)
                        {
                            if (redowe - 1 >= 0 && koloni + 1 <= Field.GetLength(1) - 1)
                            {
                                redowe--;
                                koloni++;
                            }

                            if (isVisited[redowe, koloni] == false)
                            {
                                pionkaSum += Field[redowe, koloni];
                                isVisited[redowe, koloni] = true;
                            }
                        }
                        break;
                    case "LU":
                        for (int j = 1; j < value; j++)
                        {
                            if (redowe - 1 >= 0 && koloni - 1 >= 0)
                            {
                                redowe--;
                                koloni--;
                            }



                            if (isVisited[redowe, koloni] == false)
                            {
                                pionkaSum += Field[redowe, koloni];
                                isVisited[redowe, koloni] = true;
                            }
                        }
                        break;
                    case "UL":
                        for (int j = 1; j < value; j++)
                        {

                            if (redowe - 1 >= 0 && koloni - 1 >= 0)
                            {
                                redowe--;
                                koloni--;
                            }

                            if (isVisited[redowe, koloni] == false)
                            {
                                pionkaSum += Field[redowe, koloni];
                                isVisited[redowe, koloni] = true;
                            }
                        }
                        break;
                    case "DL":
                        for (int j = 1; j < value; j++)
                        {
                            if (redowe + 1 <= Field.GetLength(0) - 1 && koloni - 1 >= 0)
                            {
                                redowe++;
                                koloni--;
                            }


                            if (isVisited[redowe, koloni] == false)
                            {
                                pionkaSum += Field[redowe, koloni];
                                isVisited[redowe, koloni] = true;
                            }
                        }
                        break;
                    case "LD":
                        for (int j = 1; j < value; j++)
                        {

                            if (redowe + 1 <= Field.GetLength(0) - 1 && koloni - 1 >= 0)
                            {
                                redowe++;
                                koloni--;
                            }

                            if (isVisited[redowe, koloni] == false)
                            {
                                pionkaSum += Field[redowe, koloni];
                                isVisited[redowe, koloni] = true;
                            }
                        }
                        break;
                    case "DR":
                        for (int j = 1; j < value; j++)
                        {
                            if (redowe + 1 <= Field.GetLength(0) - 1 && koloni + 1 <= Field.GetLength(1) - 1)
                            {
                                redowe++;
                                koloni++;
                            }


                            if (isVisited[redowe, koloni] == false)
                            {
                                pionkaSum += Field[redowe, koloni];
                                isVisited[redowe, koloni] = true;
                            }
                        }
                        break;
                    case "RD":
                        for (int j = 1; j < value; j++)
                        {
                            if (redowe + 1 <= Field.GetLength(0) - 1 && koloni + 1 <= Field.GetLength(1) - 1)
                            {
                                redowe++;
                                koloni++;
                            }

                            if (isVisited[redowe, koloni] == false)
                            {
                                pionkaSum += Field[redowe, koloni];
                                isVisited[redowe, koloni] = true;
                            }
                        }
                        break;
                }


            }

            #endregion logic
            //output
            Console.WriteLine(pionkaSum);

        }
        static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int h = 0; h < matrix.GetLength(1); h++)
                {
                    Console.Write(matrix[i, h] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}