﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FigureQuintupleDot13 : Figure
{
    private const int score = 5;

    public FigureQuintupleDot13(int player) : base(player)
    {
        figure[4, 4] = figure[4, 5] = figure[5, 4] = figure[5, 5] = figure[5, 6] = player;
    }

    public override void rotate()
    {
        currentPossition = ++currentPossition % 8;

        switch (currentPossition)
        {

            case 0:
                for (short i = 0; i < 8; i++)
                {
                    for (short j = 0; j < 8; j++)
                    {
                        figure[i, j] = 0;
                    }
                }
                figure[4, 4] = figure[4, 5] = figure[5, 4] = figure[5, 5] = figure[5, 6] = owner;
                break;
            case 1:
                figure[4, 5] = figure[5, 4] = figure[5, 5] = figure[5, 6] = 0;
                figure[4, 3] = figure[5, 3] = figure[5, 4] = figure[6, 3] = owner;
                break;
            case 2:
                figure[4, 3] = figure[5, 3] = figure[5, 4] = figure[6, 3] = 0;
                figure[3, 2] = figure[3, 3] = figure[3, 4] = figure[4, 3] = owner;
                break;
            case 3:
                figure[3, 2] = figure[3, 3] = figure[3, 4] = figure[4, 3] = 0;
                figure[2, 5] = figure[3, 4] = figure[3, 5] = figure[4, 5] = owner;
                break;
            case 4:
                for (short i = 0; i < 8; i++)
                {
                    for (short j = 0; j < 8; j++)
                    {
                        figure[i, j] = 0;
                    }
                }
                figure[4, 4] = figure[4, 3] = figure[5, 2] = figure[5, 3] = figure[5, 4] = owner;
                break;
            case 5:
                figure[4, 3] = figure[5, 2] = figure[5, 3] = figure[5, 4] = 0;
                figure[2, 3] = figure[3, 3] = figure[3, 4] = figure[4, 3] = owner;
                break;
            case 6:
                figure[2, 3] = figure[3, 3] = figure[3, 4] = figure[4, 3] = 0;
                figure[3, 4] = figure[3, 5] = figure[3, 6] = figure[4, 5] = owner;
                break;
            case 7:
                figure[3, 4] = figure[3, 5] = figure[3, 6] = figure[4, 5] = 0;
                figure[4, 5] = figure[5, 4] = figure[5, 5] = figure[6, 5] = owner;
                break;
        }
    }
}


