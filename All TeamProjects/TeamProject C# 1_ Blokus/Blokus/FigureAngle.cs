﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blokus
{
    public class FigureAngle : Figure
    {
        private const int score = 5; // tegloto na vsqka figura, hubavo e da e i stati4na


        // constructor
        public FigureAngle(int player)
            : base(player)
        {
            //do tuk ima6 masiv pylen s 0

            // da se narisuva figurata v nulevoto systoqnie
            figure[5, 2] = figure[5, 3] = figure[5, 4]=figure[4,4]=figure[3,4] = player;
        }

        public override void rotate()
        {
            currentPossition = ++currentPossition % 8;

            switch (currentPossition)
            {
                //poneje tazi figura e simetri4na sytoqniqta syvpadat po 2ki
                case 0:
                case 4:
                    for (short i = 0; i < 8; i++)
                    {
                        for (short j = 0; j < 8; j++)
                            figure[i, j] = 0;
                    }

                    figure[5, 2] = figure[5, 3] = figure[5, 4] = figure[4, 4] = figure[3, 4] = owner;
                    break;

                case 1:
                case 5: // tuk znaem ot kakvo systoqnie idvame i promenqme direktno masiva po indeksi
                    // vmesto da vyrtim nanovo cikul, kojto da go nulira, kakto v konstruktora
                    // za po-slojnite figure mai nqma smisal da se pravi taka, a kato case 0 i 4
                    for (short i = 0; i < 8; i++)
                    {
                        for (short j = 0; j < 8; j++)
                            figure[i, j] = 0;
                    }

                    figure[5, 6] = figure[5, 5] = figure[5, 4] = figure[4, 4] = figure[3, 4] = owner;
                    break;

                case 2:
                case 6: for (short i = 0; i < 8; i++)
                    {
                        for (short j = 0; j < 8; j++)
                            figure[i, j] = 0;
                    }

                    figure[3, 2] = figure[3, 3] = figure[3, 4] = figure[4, 4] = figure[5, 4] = owner;
                    break;
                case 3:
                case 7:
                    {
                        for (short i = 0; i < 8; i++)
                        {
                            for (short j = 0; j < 8; j++)
                                figure[i, j] = 0;
                        }

                        figure[3, 6] = figure[3, 5] = figure[3, 4] = figure[4, 4] = figure[5, 4] = owner;
                        break;
                    }
            }
        }
    }


}
