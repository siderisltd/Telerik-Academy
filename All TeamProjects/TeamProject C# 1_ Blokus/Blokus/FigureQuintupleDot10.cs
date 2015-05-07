using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FigureQuintupleDot10 : Figure
{
    private const int score = 5; 

    public FigureQuintupleDot10(int player) : base(player)
    {        
        figure[4, 4] = figure[4, 5] = figure[4, 6] = figure[4, 7] = figure[4, 8] = player;
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
                figure[4, 4] = figure[4, 5] = figure[4, 6] = figure[4, 7] = figure[4, 8] = owner;
                break;

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
        }
    }
}