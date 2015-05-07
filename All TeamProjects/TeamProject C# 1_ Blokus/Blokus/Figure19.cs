

using System;


public class Figure19: FigureConstructor
{

            
    public Figure19(int player) : base(player)
    {
        number = 19;
        score = 3;
        figure[4, 4] = figure[4, 5] = figure[4,6] = player;
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
                        figure[i, j] = 0;
                }

                figure[4, 4] = figure[4, 5] = figure [4,6] = owner;
                break;

            case 1:
            case 5: 
                figure[4, 5] = figure[4, 6] = 0;
                figure[5, 4] = figure[6, 4] = owner;
                break;
            case 2:
            case 6: figure[5, 4] = figure[6, 4] = 0;
                    figure[4, 3] = figure[4, 2] = owner;
                    break;
            case 3:
            case 7:                
                    figure[4, 3] = figure[4, 2] = 0;
                    figure[3, 4] = figure[2, 4] = owner;
                    break;
           
        }
    }
}

