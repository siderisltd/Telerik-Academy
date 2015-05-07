namespace Monopoly.Cards
{
    using System;

    public class GoodLuckCard : ChanceCard
    {
        private const decimal MinCash = 0; 
        private decimal cash;

        public GoodLuckCard(string currentDescription, CardType type, decimal howMuch)
            :base(currentDescription,type)
        {
            this.Cash = howMuch;
        }

        public decimal Cash
        {
            get
            {
                return this.cash;
            }
            protected set
            {
                if (value < MinCash)
                {
                    throw new ArgumentOutOfRangeException("You cannot create a card with minumum cash to pay or be paid");
                }

                this.cash = value;
            }
        }
    }
}
