using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blokus
{
    public class CheckForMoves
    {
        public static bool haveTurn(FigureConstructor[] mozajka, int[,] field, int player)
        {
            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (canBePlaced(mozajka[i].figure, field, player) == true) { return true; }
                    mozajka[i].rotate();
                }
            }
            return false;
        }
        public static bool canBePlaced(int[,] matrix, int[,] field, int player)
        {
            for (int redPole = 0; redPole < 19; redPole++)
            {
                for (int kolPole = 0; kolPole < 19; kolPole++)
                {
                    if (canItFit(matrix, field, redPole, kolPole, player) == true) { return true; }
                }
            }
            return false;
        }
        public static bool canItFit(int[,] matrix, int[,] field, int redPole, int kolPole, int player)
        {
            bool imaLiUgul = false;
            bool imaLiSused = false;
            //ako si zapazim nqkude w nachaloto kolko sa ni dulgi i kolko shiroki figurkite shte e dosta po lesno i mojem da izpolzwame towa
            for (int redFigure = 0; redFigure < 9; redFigure++)
            {
                for (int kolFigura = 0; kolFigura < 9; kolFigura++)
                {
                    if (matrix[redFigure, kolFigura] == player && field[redPole + redFigure, kolPole + kolFigura] != 0) { return false; }
                    else
                    {
                        if (imaLiUgul == false && matrix[redFigure, kolFigura] == player)
                        {
                            imaLiUgul = imaLiDopirSusUgul(matrix, redFigure, kolFigura, field, redPole, kolPole);
                        }
                        if (imaLiSused == false && matrix[redFigure, kolFigura] == player)
                        {
                            imaLiSused = imaLiDopirSusSused(matrix, redFigure, kolFigura, field, redPole, kolPole);
                        }
                        else if (imaLiSused == true)
                        {
                            return false;
                        }
                    }
                }
            }
            if (imaLiUgul == true) { return true; }
            return false;
        }
        public static bool imaLiDopirSusUgul(int[,] matrix, int redFigura, int kolFigura, int[,] field, int redPole, int kolPole)
        {
            if (matrix[redFigura, kolFigura] == field[redPole + redFigura - 1, kolPole + kolFigura - 1] ||
               matrix[redFigura, kolFigura] == field[redPole + redFigura - 1, kolPole + kolFigura + 1] ||
               matrix[redFigura, kolFigura] == field[redPole + redFigura + 1, kolPole + kolFigura - 1] ||
               matrix[redFigura, kolFigura] == field[redPole + redFigura + 1, kolPole + kolFigura + 1])
            {
                return true;
            }
            else { return false; }
        }
        public static bool imaLiDopirSusSused(int[,] matrix, int redFigura, int kolFigura, int[,] field, int redPole, int kolPole)
        {
            if (redFigura > 0)
            {
                if (matrix[redFigura, kolFigura] == field[redPole + redFigura - 1, kolPole + kolFigura])
                {
                    return true;
                }
            }
            if (kolFigura < 8)
            {
                if (matrix[redFigura, kolFigura] == field[redPole + redFigura, kolPole + kolFigura + 1])
                {
                    return true;
                }
            }
            if (redFigura < 8)
            {
                if (matrix[redFigura, kolFigura] == field[redPole + redFigura + 1, kolPole + kolFigura])
                {
                    return true;
                }
            }
            if (kolFigura > 0)
            {
                if (matrix[redFigura, kolFigura] == field[redPole + redFigura, kolPole + kolFigura - 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
