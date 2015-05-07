using System;
using System.Linq;


namespace Blokus
{
    class Player
    {
        public FigureConstructor[] playerStack;
        public int playerNumber;
        public int playerScore;
        public bool hasMoves;
        public int blokusLeft;
        public string playerName;
        public string playerColor;
        public Player(int playerNumber,string name)
        {
            this.playerNumber = playerNumber;
            this.playerName = name;
            playerStack = new FigureConstructor[21];
            playerScore = 0;
            hasMoves = true;
            blokusLeft = 21;
            playerColor = "black";
        }


        public void fillingStack()
        {
            playerStack[0] = new Figure1(playerNumber);
            playerStack[1] = new Figure2(playerNumber);
            playerStack[2] = new Figure3(playerNumber);
            playerStack[3] = new Figure4(playerNumber);
            playerStack[4] = new Figure5(playerNumber);
            playerStack[5] = new Figure6(playerNumber);
            playerStack[6] = new Figure7(playerNumber);
            playerStack[7] = new Figure8(playerNumber);
            playerStack[8] = new Figure9(playerNumber);
            playerStack[9] = new Figure10(playerNumber);
            playerStack[10] = new Figure11(playerNumber);
            playerStack[11] = new Figure12(playerNumber);
            playerStack[12] = new Figure13(playerNumber);
            playerStack[13] = new Figure14(playerNumber);
            playerStack[14] = new Figure15(playerNumber);
            playerStack[15] = new Figure16(playerNumber);
            playerStack[16] = new Figure17(playerNumber);
            playerStack[17] = new Figure18(playerNumber);
            playerStack[18] = new Figure19(playerNumber);
            playerStack[19] = new Figure20(playerNumber);
            playerStack[20] = new Figure21(playerNumber);
        }
        public int[,] PutBlokus(int blokusIndex)
        {
            playerStack[blokusIndex].isPut = true;
            playerScore += playerStack[blokusIndex].score;
            return playerStack[blokusIndex].figure;
        }
        
        
        

    }
}
