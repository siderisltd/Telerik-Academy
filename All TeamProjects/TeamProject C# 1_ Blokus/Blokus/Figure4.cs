using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Figure4 : FigureConstructor
    {

        public Figure4(int player)
            : base(player)
        {
            number = 4;
            score = 5;
            figure[4, 4] = figure[3, 4] = figure[3, 3] = figure[2, 3] = figure[2, 2] = player;
        }

        public override void rotate()
        {
            currentPossition = ++currentPossition % 8;

            switch (currentPossition)
            {


                case 1:
                case 5:
                    figure[3, 4] = figure[3, 3] = figure[2, 3] = figure[2, 2] = 0;
                    figure[4, 5] = figure[3, 5] = figure[3, 6] = figure[2, 6] = owner;
                    break;
                case 2:
                case 6:
                    figure[4, 5] = figure[3, 5] = figure[3, 6] = figure[2, 6] = 0;
                    figure[5, 4] = figure[5, 5] = figure[6, 5] = figure[6, 6] = owner;
                    break;
                case 3:
                case 7:
                    figure[5, 4] = figure[5, 5] = figure[6, 5] = figure[6, 6] = 0;
                    figure[4, 3] = figure[5, 3] = figure[5, 2] = figure[6, 2] = owner;
                    break;
                case 0:
                case 4:
                    figure[4, 3] = figure[5, 3] = figure[5, 2] = figure[6, 2] = 0;
                    figure[3, 4] = figure[3, 3] = figure[2, 3] = figure[2, 2] = owner;
                    break;
            }
        }
    }