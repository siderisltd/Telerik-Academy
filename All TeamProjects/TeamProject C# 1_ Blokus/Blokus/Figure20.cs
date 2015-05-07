using System;


public class Figure20 : FigureConstructor
{
    // tegloto na vsqka figura, hubavo e da e i stati4na


	// constructor
	public Figure20 (int player) : base(player)
    {
        number = 20;
        score = 2;
		//do tuk ima6 masiv pylen s 0

		// da se narisuva figurata v nulevoto systoqnie
		figure [4, 4] = figure [4, 5] = player;
	}

	public override void rotate()
    {
		currentPossition = ++currentPossition%8;

		switch (currentPossition)
        {
			//poneje tazi figura e simetri4na sytoqniqta syvpadat po 2ki
			case 1:
			case 5:
                figure[4, 5] = 0;
				figure [5, 4] = owner;
				break;
	
			case 2:
            case 6:
				figure [5, 4] = 0;
				figure [4, 3] = owner;
				break;

		    case 3:
		    case 7: figure [4, 3] = 0;
				    figure [3, 4] = owner;
				    break;
		    case 4:
		    case 0:
                {
				    figure [3, 4] = 0;
				    figure [4, 5] = owner;
				    break;
			    }
		}
	}
}


