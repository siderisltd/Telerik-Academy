using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blokus
{
    class Figure6 : FigureConstructor
    {
         // tegloto na vsqka figura, hubavo e da e i stati4na


        // constructor
        public Figure6(int player)
            : base(player)
        {
            number = 6;
            score = 5;
            //do tuk ima6 masiv pylen s 0

            // da se narisuva figurata v nulevoto systoqnie
            figure[4, 2] = figure[4, 3] = figure[3, 3] = figure[2, 3] = figure[4, 4] = player;
        }

        public override void rotate()
        {
            currentPossition = ++currentPossition % 8;

            switch (currentPossition)
            {
                //poneje tazi figura e simetri4na sytoqniqta syvpadat po 2ki
                case 1:
                case 5:
                    figure[4, 2] = figure[4, 3] = figure[3, 3] = figure[2, 3] = 0;
                    figure[3, 4] = figure[2, 4] = figure[3, 5] = figure[3, 6] = owner;
                    break;

                case 2:
                case 6:
                    figure[3, 4] = figure[2, 4] = figure[3, 5] = figure[3, 6] = 0;
                    figure[4, 5] = figure[4, 6] = figure[5, 5] = figure[6, 5] = owner;
                    break;

                case 3:
                case 7:
                    figure[4, 5] = figure[4, 6] = figure[5, 5] = figure[6, 5] = 0;
                    figure[5, 4] = figure[6, 4] = figure[5, 3] = figure[5, 2] = owner;

                    break;
                case 0:
                case 4:
                    figure[5, 4] = figure[6, 4] = figure[5, 3] = figure[5, 2] =0;
                    figure[4, 2] = figure[4, 3] = figure[3, 3] = figure[2, 3] = owner;
                    break;
            }
        }
    }
}
