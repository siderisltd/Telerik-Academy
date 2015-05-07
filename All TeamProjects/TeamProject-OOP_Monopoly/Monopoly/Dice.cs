using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleStuffs;
using System.Threading;

namespace Monopoly
{
    public class Dice : IRotateble
    {
        private Random random = new Random();

        private int CursorRow;
        private int CursorCol;

        public int Value { get; private set; }

        private string[][,] dices;
        
        //Sets default random Value of the dice
        public Dice(int cursorRow, int cursorCol)
        {
            this.CursorCol = cursorCol;
            this.CursorRow = cursorRow;
            dices = new string[6][,];
            dices[0] = SplashScreen.MakeDices(@"../../Files/Dices/DiceOne.txt", dices[0]);
            dices[1] = SplashScreen.MakeDices(@"../../Files/Dices/DiceTwo.txt", dices[1]);
            dices[2] = SplashScreen.MakeDices(@"../../Files/Dices/DiceThree.txt", dices[2]);
            dices[3] = SplashScreen.MakeDices(@"../../Files/Dices/DiceFour.txt", dices[3]);
            dices[4] = SplashScreen.MakeDices(@"../../Files/Dices/DiceFive.txt", dices[4]);
            dices[5] = SplashScreen.MakeDices(@"../../Files/Dices/DiceSix.txt", dices[5]);
            this.Value = random.Next(1, 7);
        }

        //Rotate the dice runtime
        private int RotateDice(int start, int end)
        {
            this.Value = random.Next(start, end);
            return this.Value;
        }

        // This will visualize the dice till rotations
        public void ShowDiceRotation()
        {
            RotateDice(2,8);

            int defaultCol = this.CursorCol;
            int defaultRow = this.CursorRow;

            int diceNumber = this.Value;
            //gets random dice everyTime the cycle rotates and it rotates Value times /which is random also/
            for (int i = 0; i < diceNumber; i++)
            {
                RotateDice(0,6);

                for (int row = 0; row < dices[Value].GetLength(0); row++)
                {
                    Console.SetCursorPosition(this.CursorRow, this.CursorCol);

                    for (int col = 0; col < dices[Value].GetLength(1); col++)
                    {
                        //Console.SetCursorPosition(this.CursorRow, this.CursorCol);
                        Console.Write(dices[Value][row, col]);
                        //CursorRow++;
                    }
                    //this.CursorRow = defaultRow;
                    this.CursorCol++;
                    Console.SetCursorPosition(this.CursorRow, this.CursorCol);
                }
                this.CursorCol = defaultCol;

                Thread.Sleep(930);
            }
           // return diceNumber;
        }

        public Dice Clone(int xPos, int yPos)
        {
            var newDice = new Dice(xPos, yPos);
            newDice.Value = this.Value;
            newDice.dices = (string[][,])this.dices.Clone();
            newDice.random = new Random();
            return newDice;
        }
    }
}
