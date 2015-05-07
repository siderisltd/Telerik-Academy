namespace MonopolyConsoleClient.DrawEngine
{
    using System;
    using System.IO;
    using System.Threading;

    using Monopoly.Interfaces;
    using Monopoly.Players;
    using Monopoly;
    using Monopoly.Dices;
    using System.Text;

    internal class ConsoleDrawEngine : IDrawingEngine
    {
        private string[][,] dices;
        private StringBuilder sb = new StringBuilder();

        public ConsoleDrawEngine()
        {

        }

        public void DrawText(int x, int y, string text)
        {
            this.PrintTextAtPosition(x, y, text);
        }

        public void DrawPlayer(Player player, Position oldPosition)
        {
            this.PrintTextAtPosition(oldPosition.X, oldPosition.Y, " ");
            this.PrintTextAtPosition(player.PosX, player.PosY, player.ToString());
        }

        public void DrawField()
        {
            StreamReader reader = new StreamReader(@"../../../Monopoly/Files/field.txt");

            //int row = 0;
            using (reader)
            {
                string currentLine = reader.ReadLine();

                while (currentLine != null)
                {
                    for (int i = 0; i < currentLine.Length; i++)
                    {
                        sb.AppendLine(currentLine);
                        currentLine = reader.ReadLine();
                        if (currentLine == null)
                        {
                            break;
                        }
                    }
                    currentLine = null;
                   // row++;

                }
            }
            this.DrawText(0, 0, sb.ToString());
        }

        public void ClearScreen()
        {
            Console.Clear();
        }

        public void DrawDices(int firstValue, int secondValue)
        {

            //Roll();

            //int defaultCol = this.cursorRow;
            //int secondDiceDefaultCol = this.secondDiceCursorCol;
            ////int defaultRow = this.CursorRow;

            //int cycleRotations = Math.Max(FirstDiceValue, SecondDiceValue);

            ////gets random dice everyTime the cycle rotates and it rotates Value times /which is random also/
            //for (int i = 0; i < cycleRotations; i++)
            //{
            //    Roll();

            //    for (int row = 0; row < dices[FirstDiceValue].GetLength(0); row++)
            //    {
            //        Console.SetCursorPosition(this.cursorCol, this.cursorRow);
            //        for (int col = 0; col < dices[FirstDiceValue].GetLength(1); col++)
            //        {
            //            Console.Write(dices[FirstDiceValue][row, col]);
            //        }

            //        Console.SetCursorPosition(this.secondDiceCursorRow, this.secondDiceCursorCol);
            //        for (int col = 0; col < dices[FirstDiceValue].GetLength(1); col++)
            //        {
            //            Console.Write(dices[SecondDiceValue][row, col]);
            //        }
            //        secondDiceCursorCol++;
            //        this.cursorRow++;
            //        Console.SetCursorPosition(this.cursorCol, this.cursorRow);
            //    }

            //    this.cursorRow = defaultCol;
            //    this.secondDiceCursorCol = secondDiceDefaultCol;

            //    Thread.Sleep(930);
            //}








        //    int cycleRotations = Math.Max(firstValue, secondValue);
        //    int cursorCol = 5;
        //    int cursorRow = 0;
        //    int defaultCol = cursorRow;
        //    int secondDiceCursorCol = cursorCol;
        //    int secondDiceCursorRow = cursorRow + 12;
        //    int secondDiceDefaultCol = secondDiceCursorCol;

        //    for (int i = 0; i < cycleRotations; i++)
        //    {
        //        for (int row = 0; row < dices[firstValue].GetLength(0); row++)
        //        {
        //            Console.SetCursorPosition(cursorCol, cursorRow);
        //            for (int col = 0; col < dices[firstValue].GetLength(1); col++)
        //            {
        //                Console.Write(dices[firstValue][row, col]);
        //            }
              
        //            Console.SetCursorPosition(secondDiceCursorRow, secondDiceCursorCol);
        //            for (int col = 0; col < dices[firstValue].GetLength(1); col++)
        //            {
        //                Console.Write(dices[secondValue][row, col]);
        //            }

        //            secondDiceCursorCol++;
        //            cursorRow++;
        //            Console.SetCursorPosition(cursorCol, cursorRow);
        //        }
                
        //        cursorRow = defaultCol;
        //        secondDiceCursorCol = secondDiceDefaultCol;

        //        Thread.Sleep(930);
        //        this.ClearScreen();
        //    }

        //    Console.WriteLine();
        }

        private void PrintTextAtPosition(int x, int y, string text)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(text);
        }
    }
}
