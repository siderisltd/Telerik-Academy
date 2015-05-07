using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Figure12 : FigureConstructor
{

    public Figure12(int player) : base(player)
    {
        number = 12;
        score = 5; 
        figure[4, 4] = figure[4, 5] = figure[4, 6] = figure[4, 7] = figure[4, 8] = player;
    }

    public override void rotate()
    {
        currentPossition = ++currentPossition % 8;

        switch (currentPossition)
        {
            case 1:
            case 5: 
                figure[4, 5] = figure[4, 6] = figure[4, 7] = figure[4, 8] = 0;
                figure[5, 4] = figure[6, 4] = figure[7, 4] = figure[8, 4] = owner;
                break;

            case 2:
            case 6:
                figure[5, 4] = figure[6, 4] = figure[7, 4] = figure[8, 4] = 0;
                figure[4, 3] = figure[4, 2] = figure[4, 1] = figure[4, 0] = owner;
                break;

            case 3:
            case 7:                
                figure[4, 3] = figure[4, 2] = figure[4, 1] = figure[4, 0] = 0;
                figure[3, 4] = figure[2, 4] = figure[1, 4] = figure[0, 4] = owner;
                break;
            case 0:
            case 4:
                figure[3, 4] = figure[2, 4] = figure[1, 4] = figure[0, 4] = 0;
                figure[4, 5] = figure[4, 6] = figure[4, 7] = figure[4, 8] = owner;
                break;

        }
    }
}