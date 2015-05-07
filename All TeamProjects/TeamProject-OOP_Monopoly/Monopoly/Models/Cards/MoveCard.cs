namespace Monopoly.Cards
{
    using System;
    using Monopoly.Interfaces;

    public class MoveCard : ChanceCard, ICard
    {
        private const int MinSquaresToMove = 0;
        //private const int MaxSquaresToMove = Max element of the field. - Add it please :)

        private int squaresToMove;

        //Constructor for card that will only move player
        public MoveCard(string currentDescription, CardType type, int moveSquares)
            : base(currentDescription, type)
        {
            this.SquaresToMove = moveSquares;
        }

        //constructor for cards that will move the player and money will be exchanged.
        public MoveCard(string currentDescription, int moveSquares, CardType type)
            : base(currentDescription, type)
        {
            this.SquaresToMove = moveSquares;
        }

        public int SquaresToMove
        {
            get
            {
                return this.squaresToMove;
            }
            private set
            {
                if (value < MinSquaresToMove /* || value > MaxSquaresToMove */)
                {
                    throw new ArgumentOutOfRangeException("Invalid position to move from the chance card");
                }

                this.squaresToMove = value;
            }
        }
    }
}
