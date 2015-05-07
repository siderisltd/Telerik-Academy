using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blokus
{
    class Figure7 : FigureConstructor
    {
       // tegloto na vsqka figura, hubavo e da e i stati4na


        // constructor
        public Figure7(int player)
            : base(player)
        {
            number = 7;
            score = 5;
            //do tuk ima6 masiv pylen s 0

            // da se narisuva figurata v nulevoto systoqnie
            figure[4, 4] = figure[5, 4] = figure[5, 5] = figure[6, 4] = figure[7, 4] = player;
        }

        public override void rotate()
        {
            currentPossition = ++currentPossition % 8;

            switch (currentPossition)
            {
                //poneje tazi figura ne e simetri4na sytoqniqta ne syvpadat po 2ki
                case 1:
                    figure[5, 4] = figure[5, 5] = figure[6, 4] = figure[7, 4] = 0;
                    figure[4, 3] = figure[4, 2] = figure[4, 1] = figure[5, 3] = owner;
                    break;
                case 2:
                    figure[4, 3] = figure[4, 2] = figure[4, 1] = figure[5, 3] = 0;
                    figure[3, 4] = figure[2, 4] = figure[1, 4] = figure[3, 3]= owner;
                    break;
                case 3:
                    figure[3, 4] = figure[2, 4] = figure[1, 4] = figure[3, 3] = 0;
                    figure[4, 5] = figure[4, 6] = figure[4, 7] = figure[3, 5] = owner;
                    break;
                case 4:
                    figure[4, 5] = figure[4, 6] = figure[4, 7] = figure[3, 5] = 0;
                    figure[5, 4] = figure[6, 4] = figure[7, 4] = figure[5, 3] = owner;

                    break;
                case 5:
                    figure[5, 4] = figure[6, 4] = figure[7, 4] = figure[5, 3] = 0;
                    figure[4, 3] = figure[4, 2] = figure[4, 1] = figure[3, 3] = owner;
                    break;
                case 6:
                    figure[4, 3] = figure[4, 2] = figure[4, 1] = figure[3, 3] = 0;
                    figure[3, 4] = figure[2, 4] = figure[1, 4] = figure[3, 5] = owner;
                    break;
                case 7:
                    figure[3, 4] = figure[2, 4] = figure[1, 4] = figure[3, 5] = 0;
                    figure[4, 5] = figure[4, 6] = figure[4, 7] = figure[5, 5] = owner;

                    break;
                
                case 0:
                    figure[4, 5] = figure[4, 6] = figure[4, 7] = figure[5, 5] = 0;
                    figure[5, 4] = figure[5, 5] = figure[6, 4] = figure[7, 4] = owner;
                    break;
            }
        }

    }
}
