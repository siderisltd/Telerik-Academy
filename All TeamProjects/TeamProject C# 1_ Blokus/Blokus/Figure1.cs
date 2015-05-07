using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Figure1 : FigureConstructor
{

    public Figure1(int player)
        : base(player)
    {
        number = 1;
        score =5;
        figure[4, 4] = figure[4, 3] = figure[4, 2] = figure[3, 3] = figure[5, 3] = player;
    }

    public override void rotate()
    {
        currentPossition = ++currentPossition % 8;

        switch (currentPossition)
        {

            case 0:
            case 4:
                for (short i = 0; i < 8; i++)
                {
                    for (short j = 0; j < 8; j++)
                    {
                        figure[i, j] = 0;
                    }
                }
                figure[4, 4] = figure[4, 3] = figure[4, 2] = figure[3, 3] = figure[5, 3] = owner;
                break;
            case 1:
            case 5:
                figure[4, 3] = figure[4, 2] = figure[3, 3] = figure[5, 3] = 0;
                figure[3, 4] = figure[2, 4] = figure[3, 3] = figure[3, 5] = owner;
                break;
            case 2:
            case 6:
                figure[3, 4] = figure[2, 4] = figure[3, 3] = figure[3, 5] = 0;
                figure[5, 4] = figure[6, 4] = figure[5, 3] = figure[5, 5] = owner;
                break;
            case 3:
            case 7:
                figure[5, 4] = figure[6, 4] = figure[5, 3] = figure[5, 5] = 0;
                figure[4, 5] = figure[4, 6] = figure[3, 5] = figure[5, 5] = owner;
                break;
        }
    }
}
