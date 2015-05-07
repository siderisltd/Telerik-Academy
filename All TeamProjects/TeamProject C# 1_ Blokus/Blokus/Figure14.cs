using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blokus
{
    public class Figure14 : FigureConstructor
    {
        // tegloto na vsqka figura, hubavo e da e i stati4na


        // constructor
        public Figure14(int player)
            : base(player)
        {
            number = 14;
            score = 4;
            //do tuk ima6 masiv pylen s 0

            // da se narisuva figurata v nulevoto systoqnie
            figure[4, 4] = figure[4, 5] = figure[5, 5] = figure[5, 4] = player;
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

                    figure[4, 4] = figure[4, 5] = figure[5, 5] = figure[5, 4] = owner;
                    break;



                case 1:
                    // tuk znaem ot kakvo systoqnie idvame i promenqme direktno masiva po indeksi
                    // vmesto da vyrtim nanovo cikul, kojto da go nulira, kakto v konstruktora
                    // za po-slojnite figure mai nqma smisal da se pravi taka, a kato case 0 i 4
                    figure[4, 4] = figure[4, 5] = figure[5, 5] = figure[5, 4] = 0;
                    figure[4, 4] = figure[4, 5] = figure[5, 5] = figure[5, 4] = owner;
                    break;

                case 2:
                    figure[4, 4] = figure[4, 5] = figure[5, 5] = figure[5, 4] = 0;
                    figure[4, 4] = figure[4, 5] = figure[5, 5] = figure[5, 4] = owner;
                    break;


            }
        }
    }
}
