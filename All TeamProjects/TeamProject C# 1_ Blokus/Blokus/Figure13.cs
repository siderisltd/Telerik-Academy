﻿using System;


public class Figure13 : FigureConstructor
{
   // tegloto na vsqka figura, hubavo e da e i stati4na


    // constructor
    public Figure13(int player)
        : base(player)
    {
        number = 13;
        score = 4;
        //do tuk ima6 masiv pylen s 0

        // da se narisuva figurata v nulevoto systoqnie
        figure[4, 4] = figure[4, 5] = figure[5, 5] = figure[5, 6] = player;
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
                        figure[i, j] = 0;
                }

                figure[4, 4] = figure[4, 5] = figure[5, 5] = figure[5, 6] = owner;
                break;



            case 1:
                // tuk znaem ot kakvo systoqnie idvame i promenqme direktno masiva po indeksi
                // vmesto da vyrtim nanovo cikul, kojto da go nulira, kakto v konstruktora
                // za po-slojnite figure mai nqma smisal da se pravi taka, a kato case 0 i 4
                figure[4, 4] = figure[4, 5] = figure[5, 5] = figure[5, 6] = 0;
                figure[4, 4] = figure[5, 4] = figure[5, 3] = figure[6, 3] = owner;
                break;

            case 2:
                figure[4, 4] = figure[5, 4] = figure[5, 3] = figure[6, 3] = 0;
                figure[4, 4] = figure[4, 3] = figure[3, 3] = figure[3, 2] = owner;
                break;

            case 3:
                figure[4, 4] = figure[4, 3] = figure[3, 3] = figure[3, 2] = 0;
                figure[4, 4] = figure[3, 4] = figure[3, 5] = figure[2, 5] = owner;
                break;

            case 4:
                figure[4, 4] = figure[3, 4] = figure[3, 5] = figure[2, 5] = 0;
                figure[4, 4] = figure[4, 5] = figure[3, 5] = figure[3, 6] = owner;
                break;

            case 5:
                figure[4, 4] = figure[4, 5] = figure[3, 5] = figure[3, 6] = 0;
                figure[4, 4] = figure[5, 4] = figure[5, 5] = figure[6, 5] = owner;
                break;


            case 6:
                figure[4, 4] = figure[5, 4] = figure[5, 5] = figure[6, 5] = 0;
                figure[4, 4] = figure[4, 3] = figure[5, 3] = figure[5, 2] = owner;
                break;
            //       
            case 7:
                figure[4, 4] = figure[4, 3] = figure[5, 3] = figure[5, 2] = 0;
                figure[4, 4] = figure[3, 4] = figure[3, 3] = figure[2, 3] = owner;
                break;

        }
    }
}