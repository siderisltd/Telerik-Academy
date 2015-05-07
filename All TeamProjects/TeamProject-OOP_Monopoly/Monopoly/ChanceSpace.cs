namespace Monopoly
{
    using System.Collections.Generic;

    using Monopoly;
    using Monopoly.Cards;
    using Monopoly.Interfaces;
    
    public class ChanceSpace : NotPurchasableSpace, IDrawCard
    {
        private Queue<ChanceCard> chanceCards;

        public ChanceSpace()
            : base("Chance")
        {
            this.chanceCards = CardInitializer.InitializeChanceList();
        }

        public ChanceCard DrawCard()
        {
            ChanceCard topCard = chanceCards.Dequeue();
            return topCard;
        }
    }
}
