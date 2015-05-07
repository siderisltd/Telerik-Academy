using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blokus
{
    class Figure8 : FigureConstructor
    {


        // constructor
        public Figure8(int player)
            : base(player)
        {
            //do tuk ima6 masiv pylen s 0
            number = 8;
            score = 5;
            // da se narisuva figurata v nulevoto systoqnie
            figure[4, 4] = figure[4, 5] = figure[5, 5] = figure[6, 5] = figure[6, 4] = player;
        }

        public override void rotate()
        {
            currentPossition = ++currentPossition % 8;

            switch (currentPossition)
            {
                //poneje tazi figura e simetri4na sytoqniqta syvpadat po 2ki
                case 1:
                case 5: 
                    figure[4, 5] = figure[5, 5] = figure[6, 5] = figure[6, 4] =0; 
                    figure[5, 4] = figure[5, 3] = figure[5, 2] = figure[4, 2] = owner;
                    break;

                case 2:
                case 6:
                    figure[5, 4] = figure[5, 3] = figure[5, 2] = figure[4, 2] = 0;
                    figure[4, 3] = figure[3, 3] = figure[2, 3] = figure[2, 4] = owner;

                    break;
                case 3:
                case 7:
                        figure[4, 3] = figure[3, 3] = figure[2, 3] = figure[2, 4] = 0;
                        figure[3, 4] = figure[3, 5] = figure[3, 6] = figure[4, 6] = owner;
                        break;
                case 4:
                case 0:
                        figure[3, 4] = figure[3, 5] = figure[3, 6] = figure[4, 6] = 0;
                        figure[4, 5] = figure[5, 5] = figure[6, 5] = figure[6, 4] = owner;
                        break;

            }
        }
    }
}
