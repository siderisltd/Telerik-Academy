namespace Monopoly.Cards
{
    using System;
    using Monopoly.Interfaces;

    public abstract class ChanceCard : ICard
    {
        private const int MinDescLen = 1;

        private string description;
        private CardType cardType;

        public ChanceCard(string currentDescription, CardType type)
        {
            this.Description = currentDescription;
            this.CardType = type;
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            private set
            {
                if (value.Length < MinDescLen)
                {
                    throw new ArgumentException("Card description length lower than {0}", MinDescLen.ToString());
                }

                this.description = value;
            }
        }

        public CardType CardType
        {
            get
            {
                return this.cardType;
            }

            private set
            {
                this.cardType = value;
            }
        }
    }
}
