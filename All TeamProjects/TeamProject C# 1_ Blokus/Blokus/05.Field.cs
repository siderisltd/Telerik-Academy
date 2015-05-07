using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Blokus
{
    public class Field
    {
        
        public int[,] playField = new int[28, 28];
        public void FillingMatrix()
        {
            for (int rows = 0; rows < playField.GetLength(0); rows++)
            {
                for (int cols = 0; cols < playField.GetLength(1); cols++)
                {
                    if ((rows < 4 || rows > 23) || (cols <4 || cols > 23))
                    {
                        playField[rows, cols] = 5;
                    }
                    else
                    {
                        playField[rows, cols] = 0;
                    }
                }
            }
            playField[3, 3] = 4;
            playField[3, 24] = 3;
            playField[24, 24] = 2;
            playField[24, 3] = 1;
            for (int i = 4; i < playField.GetLength(0) -4; i++)
            {
                for (int j = 4; j < playField.GetLength(1) -4; j++)
                {
                    Console.Write(playField[i, j] + " ");
                }
                Console.WriteLine();
            } 
        }
    }
}
