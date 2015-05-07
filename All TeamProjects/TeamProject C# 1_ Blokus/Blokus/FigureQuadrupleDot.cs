


using System;


public class FigureQuadrupleDot : Figure
{
    private const int score = 4; // tegloto na vsqka figura, hubavo e da e i stati4na


    // constructor
    public FigureQuadrupleDot(int player)
        : base(player)
    {
        //do tuk ima6 masiv pylen s 0

        // da se narisuva figurata v nulevoto systoqnie
        figure[4, 4] = figure[4, 5] = figure[4, 6] = figure[4, 7] = player;
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

                figure[4, 4] = figure[4, 5] = figure[4, 6] = figure[4, 7]= owner;
                break;

            case 1:
            case 5: // tuk znaem ot kakvo systoqnie idvame i promenqme direktno masiva po indeksi
                // vmesto da vyrtim nanovo cikul, kojto da go nulira, kakto v konstruktora
                // za po-slojnite figure mai nqma smisal da se pravi taka, a kato case 0 i 4
                figure[4, 5] = 0;
                figure[4, 6] = 0;
                figure[4, 7] = 0;
                figure[5, 4] = owner;
                figure[6, 4] = owner;
                figure[7, 4] = owner;
                break;

            case 2:
            case 6: figure[5, 4] = 0;
                figure[6, 4] = 0;
                figure[7, 4] = 0;
                figure[4, 3] = owner;
                figure[4, 2] = owner;
                figure[4, 1] = owner;
                break;
            case 3:
            case 7:
                {
                    figure[4, 3] = 0;
                    figure[4, 2] = 0;
                    figure[4, 1] = 0;
                    figure[3, 4] = owner;
                    figure[2, 4] = owner;
                    figure[1, 4] = owner;
                    break;
                }
        }
    }
}